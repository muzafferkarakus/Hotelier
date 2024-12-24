namespace Hotelier.EntityLayer.Concrate
{
    public class WorkLocation
    {
        public int WorkLocationId { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
