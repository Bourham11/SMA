using System;
using System.Collections.Generic;
using System.Text;

namespace SMA.Core.Base
{
   public interface IEmployee
    {
         decimal BasicSalary { get; set; }
         bool HasLoan { get; set; }
         decimal LoanAmount { get; set; }
         DateTime LoanDate { get; set; }
         bool HasPenelty { get; set; }
         int PeneltyId { get; set; }
         bool HasBonus { get; set; }
         int BonusId { get; set; }
         string WorkShift { get; set; }
         decimal SalaryToGet { get; set; }

    }
}
