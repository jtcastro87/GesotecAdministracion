using System;

namespace Common
{
    public class RequestModel
    {
        public string Ticket { get; set; }
        public string Employee { get; set; }
        public string Area { get; set; }
        public string Department { get; set; }
        public string ExtIP { get; set; }
        public string Category { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateTime { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public bool Assigned { get; set; }

    }
}
