using Hotelier.EntityLayer.Concrate;

namespace Hotelier.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWaiting(int id);
        int TGetBookingCount();
        List<Booking> TLast6BookingList();
    }
}
