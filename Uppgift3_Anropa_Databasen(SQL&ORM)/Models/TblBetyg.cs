using System;
using System.Collections.Generic;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_.Models
{
    public partial class TblBetyg
    {
        public int BetygId { get; set; }
        public string? Betyg { get; set; }
        public int? Betygpoäng { get; set; }
    }
}
