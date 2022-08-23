using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(300)]
        public string ContactMessage{ get; set; }
        [StringLength(300)]
        public string ContactEmail { get; set; }
        [StringLength(300)]
        public string ContactName { get; set; }
        public int ContactNumber { get; set; }
    }
}
