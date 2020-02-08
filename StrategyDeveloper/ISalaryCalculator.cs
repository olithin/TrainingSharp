using System.Collections;
using System.Collections.Generic;

namespace StrategyDeveloper
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> report);
    }
}