using System;

namespace SMA.Core.Base
{
    public interface IAppointment
    {
        DateTime AppointmentDate { get; set; }
        ICustomer Customer { get; set; }
        IEmployee EmployeeToServe { get; set; }
        int Id { get; set; }
    }
}