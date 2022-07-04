using Abstract_Factory._1_Interface;
using Abstract_Factory._2_Objects;
using Abstract_Factory._3_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._4_SubClasses
{
    public class MarutiFactory : ACarFactory
    {
        public override IEconomy GetEconomy()
        {
            return new Alto();
        }

        public override IPremium GetPremium()
        {
            return new SCross();
        }
    }
}
