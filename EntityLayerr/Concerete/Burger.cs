using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class Burger
    {
        [Key]
        public int BurgerİD { get; set; }
        [StringLength(50)]
        public string BurgerName { get; set; }
        [StringLength (500)]
        public string BurgerImage { get; set; }
        public int BurgerPrice { get; set; }
        [StringLength(500)]
        public string BurgerSpecification { get; set; }

    }
}
