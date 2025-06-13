namespace Online2.Models
{
    public class Assignment
    {
        public int Id { get; set; } // PRIMARY KEY
        public string Code { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string Telephone { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Status { get; set; }
        public string ServiceCode { get; set; } // FOREIGN KEY referencing Services.ServiceCode
        public string DeviceCode { get; set; } // FOREIGN KEY referencing Devices.DeviceCode
    }

}
