using System;
using System.Collections.Generic;

namespace Uppgift3_Anropa_Databasen_SQL_ORM_.Models
{
    public partial class KpersonalHarKur
    {
        public int? PersonalId { get; set; }
        public int? KurskodNy { get; set; }

        public virtual TblKur? KurskodNyNavigation { get; set; }
        public virtual TblPersonal? Personal { get; set; }
    }
}
