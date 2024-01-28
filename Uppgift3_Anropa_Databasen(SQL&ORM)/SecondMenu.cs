using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift3_Anropa_Databasen_SQL_ORM_.Models;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_
{
    internal class SecondMenu
    {
        public static void Menu2() 
        {
            bool Q = true;
            using SchoolDbContext context = new SchoolDbContext();
            do
            {
                var students = context.TblStudents.Where(s => s.Klass > 0);
                WriteOutInfo.studentInfo(context, students);

                List<string> listOfClass = new List<string>();

                listOfClass.Add("\tklass 1");
                listOfClass.Add("\tklass 2");
                listOfClass.Add("\tklass 3");
                listOfClass.Add("\tGå tillbaka till föregående meny");

                int nextchoice = ArrowMenu.startMenuArrow(listOfClass, "\tvilken klass vill du se?");

                switch (nextchoice)
                {
                    case 0:
                        students = context.TblStudents.Where(s => s.Klass == 1);
                        WriteOutInfo.studentInfo(context, students);
                        break;
                    case 1:
                        students = context.TblStudents.Where(s => s.Klass == 2);
                        WriteOutInfo.studentInfo(context, students);
                        break;
                    case 2:
                        students = context.TblStudents.Where(s => s.Klass == 3);
                        WriteOutInfo.studentInfo(context, students);
                        break;
                    case 3:
                        Console.WriteLine("Tryck på vlafri tangent för att återgå till föregående meny");
                        Console.ReadKey();
                        Q = false;
                        break;
                }


            }
            while (Q);
        }

    }
}
