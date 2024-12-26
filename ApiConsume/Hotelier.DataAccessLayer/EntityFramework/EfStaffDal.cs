using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.Repositories;
using Hotelier.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var values = context.Staff.Count();
            return values;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var values = context.Staff.OrderByDescending(x => x.StaffId).Take(4).ToList();
            return values;
        }
    }
}
