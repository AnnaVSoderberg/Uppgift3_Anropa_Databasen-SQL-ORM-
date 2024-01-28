using System;
using System.Collections.Generic;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_.Models
{
    public partial class TblPersonal
    {
        public int PersonalId { get; set; }
        public string? Förnamn { get; set; }
        public string? Efternamn { get; set; }
        public int? Titel { get; set; }

        public virtual TblTitlar? TitelNavigation { get; set; }
    }
}
