using Hotelier.DtoLayer.Dtos.BookingDtos;
using Hotelier.EntityLayer.Concrate;

namespace Hotelier.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWaiting(int id);
        int GetBookingCount();
        List<Booking> Last6BookingList();
    }
}
