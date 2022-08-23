using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class About
    {
        [Key]
        public int AboutİD { get; set; }
        [StringLength(1000)]
        public string AboutDetails { get; set; }
        [StringLength(1000)]
        public string Aboutİmage{ get; set; }
    }
}
