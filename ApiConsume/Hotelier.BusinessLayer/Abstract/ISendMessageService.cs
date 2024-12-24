using Hotelier.EntityLayer.Concrate;

namespace Hotelier.BusinessLayer.Abstract
{
    public interface ISendMessageService : IGenericService<SendMessage>
    {
        public int TGetSendMessageCount();
    }
}
