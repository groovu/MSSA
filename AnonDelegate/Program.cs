using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRepoTutorial;

namespace AnonDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //delegatesEx();

            //Predicate: represents a method that defines a critera
            List<Employee> eList = new List<Employee>();
            eList.Add(new Employee() { Id = 102, Name = "Alice", Address = "Apple St" });
            eList.Add(new Employee() { Id = 101, Name = "Bob", Address = "Bone St" });
            eList.Add(new Employee() { Id = 103, Name = "Char", Address = "Caramel St" });
            Predicate<Employee> p = new Predicate<Employee>(FindEmp);

            Employee select = eList.Find(p);

            //Anon method
            Employee e2 = eList.Find(
                delegate (Employee e1)
                {
                    return e1.Id == 101;
                });
            Employee e3 = eList.Find(n => n.Name == "Alice");
        }
        private static bool FindEmp(Employee e)
        {
            return e.Id == 101;
        }

        private static void delegatesEx()
        {
            bool result = Check(100);
            Mydel pointer = new Mydel(Check);

            bool resultnew = pointer(100);

            pointer += Check2;

            bool result2 = pointer(100); // two methods in pointer; do all the results return? no, only the last one.
                                         // so its not a mapping, but more like a check?


            Mydel anonDel = delegate (int num) // anon method
            {
                return (num > 10);
            };

            bool anonResult = anonDel(100);

            Mydel lambdaEx = (num) => { return num > 30; }; //(<parameters>), () is the function.
                                                            //signature of delegate (Mydel) gives you what the return is.
        }

        public delegate bool Mydel(int num); //+= more methods.
        public static bool Check(int num)
        {
            return (num > 10);
        }
        public static bool Check2(int num)
        {
            return (num < 10);
        }
    }
    
}
