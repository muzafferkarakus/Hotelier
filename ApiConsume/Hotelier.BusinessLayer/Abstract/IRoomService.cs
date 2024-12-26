using Hotelier.EntityLayer.Concrate;

namespace Hotelier.BusinessLayer.Abstract
{
    public interface IRoomService : IGenericService<Room>
    {
        int TRoomCount();
    }
}
