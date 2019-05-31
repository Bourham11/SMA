using SMA.Core.Base;
using System;

namespace SMA.Core.Entities
{
    public class Employee : IPerson,IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal BasicSalary { get ; set ; }
        public bool HasLoan { get; set; }
        public decimal LoanAmount { get ; set ; }
        public DateTime LoanDate { get ; set ; }
        public bool HasPenelty { get ; set ; }
        public int PeneltyId { get ; set ; }
        public bool HasBonus { get; set ; }
        public int BonusId { get ; set ; }
        public string WorkShift { get ; set ; }
        public decimal SalaryToGet { get ; set ; }
    }
}
