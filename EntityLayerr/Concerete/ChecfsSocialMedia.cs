using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class ChecfsSocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        [StringLength(300)]
        public string Checfsİnstagram { get; set; }
        [StringLength(300)]
        public string ChecfsFacebook { get; set; }
        [StringLength(300)]
        public string ChecfsLinkedin { get; set; }

        //İLİŞKİ
        public int Chefsid { get; set; }
        public virtual OurChefs Chefs { get; set; }
    }
}
