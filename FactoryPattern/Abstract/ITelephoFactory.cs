using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Abstract
{
    internal interface ITelephoFactory
    {
        ITelephone geTelephone(string model, string batarya, string en, string boy);
    }
}
