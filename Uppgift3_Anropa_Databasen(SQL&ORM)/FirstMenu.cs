using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift3_Anropa_Databasen_SQL_ORM_.Models;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_
{
    internal class FirstMenu
    {
        public static void Menu1()
        {
            using SchoolDbContext context = new SchoolDbContext();
            bool Q = true;

            List<string> list = new List<string>();

            list.Add("\tSortera på förnamn i fallande ordning");
            list.Add("\tSortera på Efternamn i fallande ordning");
            list.Add("\tSortera på förnamn i stignade ordning");
            list.Add("\tSortera på Efternamn i stigande ordning");
            list.Add("\tVisa en lista på alla elever");
            list.Add("\tLägga till Pesronal");
            list.Add("\tLägga till Student");
            list.Add("\tAvsluta");

            while (Q)
            {
                int choice = ArrowMenu.startMenuArrow(list, "\tGör ditt val i menyn");

                Console.Clear();
                var students = context.TblStudents.Where(s => s.Klass != 0);

                switch (choice)
                {
                    case 0:
                        students = students.OrderBy(s => s.Förnamn);
                        WriteOutInfo.studentInfo(context, students);
                        break;
                    case 1:
                        students = students.OrderBy(s => s.Efternamn);
                        WriteOutInfo.studentInfo(context, students);
                        break;
                    case 2:
                        students = students.OrderByDescending(s => s.Förnamn);
                        WriteOutInfo.studentInfo(context, students);
                        break;
                    case 3:
                        students = students.OrderByDescending(s => s.Efternamn);
                        WriteOutInfo.studentInfo(context, students);
                        break;
                    case 4:
                        SecondMenu.Menu2();
                        break;

                    case 5:
                        InsertInfo.InsertStaff(context);
                        break;
                    case 6:
                        InsertInfo.InsertStudentInfo(context);
                        break;
                    case 7:
                        Console.WriteLine("Programmet avslutas tryck på valfri tangent");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                }
                Console.Clear();
                Q = true;
            }
        }

    }
}
