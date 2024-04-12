    namespace SOLID.OCPWithDelegate;
    public class LowSalaryCalculate
    {
        public decimal Calculate(decimal salary) => salary * 2;
    }

    public class MiddleSalaryCalculate 
    {
        public decimal Calculate(decimal salary)=> salary * 4;
    }
    public class HighSalaryCalculate 
    {
        public decimal Calculate(decimal salary)=> salary * 6;
    }

    public class ManagerSalaryCalcualte 
    {
        public decimal Calculate(decimal salary)=> salary * 7;
    }


    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary, Func<decimal,decimal>  calculateDelegate) => calculateDelegate(salary);
    }

  