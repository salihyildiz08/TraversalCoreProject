using BusinessLayer.Absract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
           return _commentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListFilter(int id)
        {
            return _commentDal.GetListFilter(x=>x.DestinationID==id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
