using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift3_Anropa_Databasen_SQL_ORM_.Models;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_
{
    internal class InsertInfo
    {
    public static void InsertStaff(SchoolDbContext context)
        {
            Console.WriteLine("Ange data för den anställda");
            Console.WriteLine("Förnamn: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("1. Rektor\n2. Admin\n3. Lärare");
            Console.WriteLine("Titel: ");
            int titel = Convert.ToInt32(Console.ReadLine());


            TblPersonal p1 = new TblPersonal()
            {
                Förnamn = firstname,
                Efternamn = lastname,
                Titel = titel
            };
            context.TblPersonals.Add(p1);
            context.SaveChanges();
        }


        public static void InsertStudentInfo(SchoolDbContext context)
        {
            Console.WriteLine("Ange data för eleven");
            Console.WriteLine("Personnummer: ");
            string personNumber = Console.ReadLine();
            Console.WriteLine("Förnamn: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("1. klass21\n2.klass22 \n3.klass23");
            Console.WriteLine("Klass: ");
            int className = Convert.ToInt32(Console.ReadLine());


            TblStudent s1 = new TblStudent()
            {
                Personnumner = personNumber,
                Förnamn = firstname,
                Efternamn = lastname,
                Klass = className
            };
            context.TblStudents.Add(s1);
            context.SaveChanges();
        }

    }
}
