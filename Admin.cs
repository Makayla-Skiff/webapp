using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SLTPage.Data
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int RID { get; set; }
        public string Role { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }

        public int DID { get; set; }
        [ForeignKey("DID")]
        public Department_Owner DOP { get; set; }

    }

}
