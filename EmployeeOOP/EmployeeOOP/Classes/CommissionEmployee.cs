using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee      //Se hace la herencia de la clase
    {
        #region Properties
        public decimal CommissionPercentage { get; set; }
        public decimal Sales { get; set; }          //Ventas

        #endregion

        #region Methods

        public override decimal GetValueToPay()
        {
            return (CommissionPercentage/100) * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentage......{ConvertPercentage(CommissionPercentage):P2}" +
                $"\n\tSales......................{Sales:C2}" +                           //Currency, valor monetario de 2 cifras
                $"\n\tValue to pay...............{GetValueToPay():C2}";
        }

        private object ConvertPercentage(decimal commissionPercentage)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
