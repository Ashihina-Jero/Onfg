namespace Online2.Models
{
    public class Service
    {
        public string ServiceCode { get; set; } // PRIMARY KEY
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public bool IsInOperation { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Connected { get; set; }
    }

}
