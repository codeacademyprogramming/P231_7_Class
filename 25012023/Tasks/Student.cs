using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        public byte Point;

        public bool IsGradueted()
        {
            if (Point >= 65)
                return true;
            else 
                return false;
        }

        public string GetInfo()
        {
            return $"FullName: {FullName} - GroupNo: {GroupNo} - Point: {Point} - Graduated: {IsGradueted()}";
        }
    }
}
