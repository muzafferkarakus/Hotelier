using Hotelier.EntityLayer.Concrate;

namespace Hotelier.BusinessLayer.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();
    }
}
