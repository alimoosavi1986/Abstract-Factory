using Abstract_Factory._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._2_Objects
{
    public class Elantra : IPremium
    {
        public string ShowPremium()
        {
            return "Elantra";
        }
    }
}
