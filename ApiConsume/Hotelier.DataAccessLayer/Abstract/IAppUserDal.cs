using Hotelier.EntityLayer.Concrate;

namespace Hotelier.DataAccessLayer.Abstract
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
    }
}
