using Microsoft.EntityFrameworkCore;
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
            foreach (var s in students.Include(s => s.KlassNavigation))
            {
                Console.WriteLine($"Förnamn: {s.Förnamn}");
                Console.WriteLine($"Efternamn: {s.Efternamn}");
                Console.WriteLine($"Klass: {s.KlassNavigation?.KlassNamn}");
                Console.WriteLine(new string('*', 10));
            }
            
            Console.ReadLine();
        }

        public static void StaffInffo(SchoolDbContext context, IQueryable<TblPersonal> personals)
        {
            Console.Clear();
            foreach (var p in personals.Include(p => p.TitelNavigation))
            {
                Console.WriteLine($"PersonalID: {p.PersonalId} ");
                Console.WriteLine($"Namn: {p.Förnamn} {p.Efternamn} ");
                Console.WriteLine($"Befattning: {p.TitelNavigation?.Titel} ");
                Console.WriteLine(new string ('*',10));
            }
            Console.ReadLine();
        }
    }
}
