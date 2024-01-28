using System;
using System.Collections.Generic;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_.Models
{
    public partial class TblKur
    {
        public int KurskodNy { get; set; }
        public string? Kursnamn { get; set; }
        public int? Poäng { get; set; }
    }
}
