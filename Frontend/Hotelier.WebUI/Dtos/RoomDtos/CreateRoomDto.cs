using System.ComponentModel.DataAnnotations;

namespace Hotelier.WebUI.Dtos.RoomDtos
{
    public class CreateRoomDto
    {
        [Required(ErrorMessage ="Lütfen Oda Numaranızı Yazınız")]
        public string RoomNumber { get; set; }
        public string CoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string WiFi { get; set; }
        public string Description { get; set; }
    }
}
