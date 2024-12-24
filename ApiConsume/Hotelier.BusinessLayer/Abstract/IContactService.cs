using Hotelier.EntityLayer.Concrate;

namespace Hotelier.BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        public int TGetContactCount();
    }
}
