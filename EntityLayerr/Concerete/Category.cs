using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; } 
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } //SİLMEK YERİNE PASİF HALE GETİRCEZ

    }
}
