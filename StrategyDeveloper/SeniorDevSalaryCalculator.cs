using System.Collections.Generic;
using System.Linq;

namespace StrategyDeveloper
{
    public class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
            reports
                .Where(r => r.Level == DeveloperLevel.Senior)
                .Select(r => r.CalculateSalary() * 5)
                .Sum();
    }
}