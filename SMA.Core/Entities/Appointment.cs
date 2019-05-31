using SMA.Core.Base;
using System;

namespace SMA.Core.Entities
{
    public class Appointment : IAppointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public ICustomer Customer { get; set; }
        public IEmployee EmployeeToServe { get; set; }
    }
}
