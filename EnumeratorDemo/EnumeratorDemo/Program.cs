using System;
using System.Collections.Generic;

namespace EnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单的例子
            int[] number_array = new int[] {1, 2, 3, 4, 5};
            foreach (var k in number_array)
            {
                Console.WriteLine(k);
            }
            
            //这个student类实现了IComparable<T>接口 ,但是没有实现IEnumerable<T>接口,
            //不能用foreach遍历.下面的代码对这个没有实现IEnumerable<T>
            Student[] students=new Student[5];
            List<Student>studentList=new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                Student student = new Student() {Age = 4-i};
                studentList.Add(student);
                students[i] = student;
            }
            //foreach (Student student in students)
            //{
            //    Console.WriteLine("Student.Age:"+student.Age);
            //}
            StudentCompare compare=new StudentCompare();
            studentList.Sort(compare);//添加一个比较器
            studentList.Sort();
            //这里有个问题Student类没有实现IEnumerator接口也是可以使用foreach进行枚举的
            foreach (var student in studentList)
            {
                Console.WriteLine("Student.Age:" + student.Age);
            }
            Console.ReadKey();
        }
    }
}
