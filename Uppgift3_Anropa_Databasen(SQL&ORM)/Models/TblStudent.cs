using System;
using System.Collections.Generic;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_.Models
{
    public partial class TblStudent
    {
        public int StudentId { get; set; }
        public string Personnumner { get; set; } = null!;
        public string? Förnamn { get; set; }
        public string? Efternamn { get; set; }
        public int? Klass { get; set; }

        public virtual TblKlasser? KlassNavigation { get; set; }
    }
}
