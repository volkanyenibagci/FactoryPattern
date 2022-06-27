using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Abstract;

namespace FactoryPattern.Concrete
{
    internal class Factory
    {
        public static ITelephone GetTelephone(string model,string batarya,string en, string boy) 
        {
            ITelephone telephone;
            if (model=="Apple11")
            {
                telephone = new Apple11(model,batarya,en,boy);
            }
            else if (model == "Xaomi10")
            {
                telephone = new Xaomi10(model,batarya,en,boy);
            }
            else
            {
                throw new Exception("Geçerli bir model değildir");
            }
            return telephone;

        }
    }
}
