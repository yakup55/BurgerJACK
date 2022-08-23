using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class OurChefs
    {
        [Key]
        public int OurID { get; set; }
        [StringLength(50)]
        public string ChefsNameSurName { get; set; }
        [StringLength(500)]
        public string ChecfsAbout{ get; set; }
        [StringLength(300)]
        public string Checfsİmage { get; set; }
        [StringLength(200)]
        public string ChefsPassword { get; set; }
        public int ChefsAge { get; set; }

        public ICollection<ChecfsSocialMedia> Medias { get; set; }

    }
}
