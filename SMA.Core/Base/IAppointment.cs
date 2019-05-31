using System;

namespace SMA.Core.Base
{
    public interface IAppointment
    {
        int Id { get; set; }
        DateTime AppointmentDate { get; set; }
        ICustomer Customer { get; set; }
        IEmployee EmployeeToServe { get; set; }
    }
}