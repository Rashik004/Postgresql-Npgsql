using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpgSql
{
    using NpgSql.Contexts;
    using NpgSql.Models;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            using (var ctx = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "New Student" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            using (var ctx = new PcPoolContext())
            {
                var user = new PcPoolModels.User() {FirstName = "first of all"};

                Console.WriteLine("In context");
                try
                {
                    ctx.Users.Add(user);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }



            Console.WriteLine("done!");
            Console.ReadKey();
        }
    }
}
