// using SOLID.NotOCP;
// using SOLID.OCPWithInterface;
using SOLID.LSP;
// using SOLID.NotLSP;
using SOLID.OCPWithDelegate; 

SalaryCalculator salaryCalculator = new();

//Not Open Closed Principle
// Console.WriteLine($"Low Salary :{salaryCalculator.Calculate(1000, SalaryType.Low)}");
// Console.WriteLine($"Low Middle :{salaryCalculator.Calculate(1000, SalaryType.Middle)}");
// Console.WriteLine($"Low High :{salaryCalculator.Calculate(1000, SalaryType.High)}");

//Open Closed Principle With Interface
// Console.WriteLine($"Low Salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
// Console.WriteLine($"Low Middle :{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
// Console.WriteLine($"Low High :{salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");

//Open Closed Principle with Delegate
Console.WriteLine($"Low Salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Low Salary :{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
Console.WriteLine($"Low Salary :{salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");


//Not Liskov Substitution Principle
BasePhone phone =new IPhone();
// phone.Call();
// phone.TakePhoto();

// phone =new Nokia3310();
// phone.Call();
// phone.TakePhoto();

// Liskov Substitution Principle
phone.Call();
((ITakePhoto)phone).TakePhoto();

phone =new Nokia3310();
phone.Call();

