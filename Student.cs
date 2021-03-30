using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgrNamespace
{   public enum Month
    {
        Empty, January, Feburary, March, April, May, June, July, August, September, October, November, December
    }
    public enum Grade
    {
        Empty,Freshman, Sophmore, Junior, Senior
    }
    [Serializable()]
    public class Student
    {
        public int Id { get; set; } 
        public string Fname { get; set; }  
        public string Lname { get; set; }
        public string Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public Grade Grade { get; set; }

        public Student(int id, string fname, string lname, string address, Month month, Grade grade)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Address = address;
            this.MonthOfAdmission = month;
            this.Grade = grade;
        }
        public Student()
        {

        }
    }
}
