using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el día: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el día: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de clase Date
    Date dateObject = new Date(day, month, year);               //Parametrización de datos, Día/mes/Año
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
