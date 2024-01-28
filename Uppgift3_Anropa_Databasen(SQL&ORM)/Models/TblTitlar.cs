using System;
using System.Collections.Generic;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_.Models
{
    public partial class TblTitlar
    {
        public TblTitlar()
        {
            TblPersonals = new HashSet<TblPersonal>();
        }

        public int TitelId { get; set; }
        public string? Titel { get; set; }

        public virtual ICollection<TblPersonal> TblPersonals { get; set; }
    }
}
