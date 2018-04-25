using System;

namespace EnumeratorDemo
{
    /// <summary>
    /// 实现IComprable<T>接口
    /// </summary>
    public class Student:IComparable<Student>
    {
        public Student()
        {
            
        }

        public int Age { get; set; }        

        /// <summary>
        /// 实现IComparable接口,用于排序
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            if (this.Age == other.Age)
            {
                return 0;
            }
            else if (this.Age < other.Age)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}