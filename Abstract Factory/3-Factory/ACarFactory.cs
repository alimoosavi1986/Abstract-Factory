using Abstract_Factory._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._3_Factory
{
    public abstract class ACarFactory
    {
        public abstract IEconomy GetEconomy();
        public abstract IPremium GetPremium();
    }
}
