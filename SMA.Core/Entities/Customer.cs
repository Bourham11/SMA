using SMA.Core.Base;
using System;

namespace SMA.Core.Entities
{
    public class Customer :  ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string CustomerType { get; set; }
        public bool HasAppointment { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime UpcomingAppointmentDate { get; set; }
        public int DaysForNextAppointment { get; set; }
        public IEmployee PreferedEmployee { get; set; }
    }
}
