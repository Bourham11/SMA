using System;

namespace SMA.Core.Base
{
    public interface ICustomer : IPerson
    {
        DateTime AppointmentDate { get; set; }
        string CustomerType { get; set; }
        int DaysForNextAppointment { get; set; }
        bool HasAppointment { get; set; }
        IEmployee PreferedEmployee { get; set; }
        DateTime UpcomingAppointmentDate { get; set; }
    }
}