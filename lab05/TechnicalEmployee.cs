﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_lab01
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(String name) : base(name, 75000)
        {

        }
        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }

    }
}
