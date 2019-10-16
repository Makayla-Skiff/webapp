using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SLTPage.Data
{
    public class Department_Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DID { get; set; }
        public string DHead { get; set; }
        public string DName { get; set; }
        
    }
    
}
