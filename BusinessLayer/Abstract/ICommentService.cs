using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetList();
        void CommentAdd(Comment comment);  
        void CommentUpdate(Comment comment);
        void CommentDelete(Comment comment);
        Comment GetCommentİD(int id);    
    }
}
