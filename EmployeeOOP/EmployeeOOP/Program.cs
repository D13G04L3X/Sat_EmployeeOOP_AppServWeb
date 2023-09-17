using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year, id;
    string firstName, lastName;
    decimal salary;
    bool isActive;
    decimal commissionPercentage, hourValue, sales, baseCommission;
    int hours;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de clase Date
    Date dateObject = new Date(day, month, year);               //Parametrización de datos, Día/mes/Año
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.WriteLine("*******************");
    Console.WriteLine("* SALARY EMPLOYEE *");
    Console.WriteLine("*******************");

    Console.WriteLine("Ingresar nombres: ");
    firstName = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Ingresar apellidos: ");
    lastName = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Ingresar salario devengado: ");
    salary = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("");

    Employee salaryEmployee = new SalaryEmployee()
    {
        Id = 12345,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };

    Console.WriteLine("");

    Console.WriteLine("***********************");
    Console.WriteLine("* COMMISSION EMPLOYEE *");
    Console.WriteLine("***********************");

    Console.WriteLine("Ingresa el procentaje de comisión:");
    commissionPercentage = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingresa las ventas:");
    sales = Convert.ToDecimal(Console.ReadLine());

    Employee commissionEmployee = new CommissionEmployee()
    {
        Id = 12345,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentage = commissionPercentage,
        Sales = sales,
    };

    Console.WriteLine(commissionEmployee);

    Console.WriteLine("");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
