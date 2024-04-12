namespace SOLID.OCPWithInterface;
public interface ISalaryCalculate
{
    decimal Calculate(decimal salary);
}

public class LowSalaryCalculate : ISalaryCalculate
{
    public decimal Calculate(decimal salary) => salary * 2;
}

public class MiddleSalaryCalculate : ISalaryCalculate
{
    public decimal Calculate(decimal salary) => salary * 4;
}

public class HighSalaryCalculate : ISalaryCalculate
{
    public decimal Calculate(decimal salary) => salary * 6;
}

public class ManagerSalaryCalcualte : ISalaryCalculate
{
    public decimal Calculate(decimal salary) => salary * 7;
}


public class SalaryCalculator
{
    public decimal Calculate(decimal salary, ISalaryCalculate salaryCalculate) => salaryCalculate.Calculate(salary);
}