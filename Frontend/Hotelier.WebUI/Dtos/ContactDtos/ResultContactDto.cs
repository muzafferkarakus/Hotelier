﻿namespace Hotelier.WebUI.Dtos.ContactDtos
{
    public class ResultContactDto
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
