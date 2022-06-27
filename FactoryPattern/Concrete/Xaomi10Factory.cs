using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Abstract;

namespace FactoryPattern.Concrete
{
    internal class Xaomi10Factory : ITelephoFactory
    {

        public ITelephone geTelephone(string model, string batarya, string en, string boy)
        {
            return new Xaomi10(model,batarya,en,boy);
        }
    }
}
