using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {
        #region Properties                          
        //Al definir las propiedades, no es necesario el método constructor
        public decimal Salary { get; set; }         //Decimal fué creado para valores monetarios

        #endregion

        #region Methods

        public SalaryEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +                 //Traigo la lógica y la información del método ToString de la clase padre, en este caso lo que hay dentro de Employee se concatena con la nueva información
                $"Salario Devengado: {Salary : C2}\n\t ";
        }

        #endregion
    }
}
