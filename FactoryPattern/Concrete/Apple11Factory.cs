using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Abstract;

namespace FactoryPattern.Concrete
{
    internal class Apple11Factory : ITelephoFactory
    {
        public ITelephone geTelephone(string model, string batarya, string en, string boy)
        {
            return new Apple11(model,batarya,en,boy);
        }
    }
}
