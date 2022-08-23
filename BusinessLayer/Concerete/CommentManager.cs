using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concerete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
          _commentDal.Insert(comment);
        }

        public void CommentDelete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void CommentUpdate(Comment comment)
        {
            _commentDal.Update(comment);    
        }

        public Comment GetCommentİD(int id)
        {
            return _commentDal.Get(x => x.CommentİD == id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.List();
        }
    }
}
