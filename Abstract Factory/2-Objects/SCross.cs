using Abstract_Factory._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._2_Objects
{
    public class SCross : IPremium
    {
        public string ShowPremium()
        {
            return "S-Cross";
        }
    }
}
