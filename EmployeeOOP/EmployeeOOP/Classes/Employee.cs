using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public abstract class Employee                  //Para definir la clase abstrata con un método abstracto como get value to pay
    {
        #region Properties

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }       //elvis (?) Permite que sea Nuleable osea null o empty
        public Date? BirthDate { get; set; }
        public Date? HiringDate { get; set; }
        public bool? IsActive { get; set; }         //true

        #endregion

        #region Methods

        public Employee()
        {

        }

        public abstract decimal GetValueToPay();

        public override string ToString()           //Nace ToString de la clase String, override es sobreescribir
        {
            return $" INFORMACIÓN EMPLEADO \n\t " +
                $"ID: {Id} \n\t " +
                $"Nombres: {FirstName} \n\t " +
                $"Apellidos: {LastName} \n\t " +
                $"Fecha de cumpleaños: {BirthDate} \n\t " +
                $"Fecha de contratación: {HiringDate} \n\t " +
                $"¿Empleado Activo?: {IsActive} \n\t ";
        }

        #endregion

    }
}
