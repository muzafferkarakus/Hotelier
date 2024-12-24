using Hotelier.EntityLayer.Concrate;

namespace Hotelier.DataAccessLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        public int GetContactCount();
    }
}
