using System;
using System.Collections.Generic;

namespace EnumeratorDemo
{
    /// <summary>
    /// 学生类的比较器的实现
    /// </summary>
    public class StudentCompare : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Age==y.Age)
            {
                return 0;
            }
            else if(x.Age>y.Age)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}