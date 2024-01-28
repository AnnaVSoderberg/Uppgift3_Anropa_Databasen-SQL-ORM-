using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift3_Anropa_Databasen_SQL_ORM_.Models;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_
{
    internal class WriteOutInfo
        {
        public static void studentInfo(SchoolDbContext context, IQueryable<TblStudent> students)
        {
            Console.Clear();
            foreach (var s in students)
            {
                Console.WriteLine($"Förnamn: {s.Förnamn}");
                Console.WriteLine($"Efternamn: {s.Efternamn}");
                Console.WriteLine($"Klass: {s.Klass}");
                Console.WriteLine(new string('*', 10));
            }
            
            Console.ReadLine();
        }
    }
}
