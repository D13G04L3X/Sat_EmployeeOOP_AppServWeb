﻿using System;
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
                $"\n\tCommission Percentage......{(CommissionPercentage/100) * Sales}:P2";
        }

        #endregion
    }
}
