﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class Register
    {
        [Key]
        public int RegisterID { get; set; }
        [StringLength(100)]
        public string Mail { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string PasswordAgain { get; set; }
    }
}
