using eUseControl.Domain.Entities;
using System;

namespace eUseControl.BusinessLogic.Service
{
    public class CommentService : ModelService<Comment>
    {
        public ServiceResponse<IHasComments> LoadComments(IHasComments comment)
        {
            var type = comment.GetType();
            try
            {
                DbContext.Set(type).Attach(comment);
                DbContext.Entry(comment).Collection(x => x.Comments).Load();
                return Success(comment);
            }
            catch(Exception e)
            {
                return Failure<IHasComments>(e.Message);
            }
        }
	}
}
