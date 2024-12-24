using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.Repositories;
using Hotelier.EntityLayer.Concrate;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfSendMessageDal : GenericRepository<SendMessage>, ISendMessageDal
    {
        public EfSendMessageDal(Context context) : base(context)
        {
        }

        public int GetSendMessageCount()
        {
            var context = new Context();
            return context.SendMessages.Count();
        }
    }
}
