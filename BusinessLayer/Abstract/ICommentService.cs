using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CommentDelete(Comment category);
        //void CommentUpdate(Comment category);
        List<Comment> GetList(int id);
        //Comment GetById(int id);

    }
}
