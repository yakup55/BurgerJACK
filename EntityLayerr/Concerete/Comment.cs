using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concerete
{
    public class Comment
    {
        [Key]
        public int CommentİD { get; set; }
        [StringLength(50)]
        public string CommentName { get; set; }
        [StringLength(100)]
        public string CommentMail { get; set; }
        [StringLength(50)]
        public string CommentSubject { get; set; }
        [StringLength(500)]
        public string CommentMessage { get; set; }

        //İLİŞKİ
        public int Burgerid { get; set; }
        public virtual Burger Burgers { get; set; }

    }
}
