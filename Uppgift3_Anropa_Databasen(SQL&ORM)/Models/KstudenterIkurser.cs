using System;
using System.Collections.Generic;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_.Models
{
    public partial class KstudenterIkurser
    {
        public int? KurskodNy { get; set; }
        public int? StudentId { get; set; }

        public virtual TblKur? KurskodNyNavigation { get; set; }
        public virtual TblStudent? Student { get; set; }
    }
}
