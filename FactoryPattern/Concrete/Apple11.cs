using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FactoryPattern.Abstract;

namespace FactoryPattern.Concrete
{
    internal class Apple11 :ITelephone
    {
        private readonly string _model;
        private readonly string _batarya;
        private readonly string _en;
        private readonly string _boy;

        public Apple11(string model, string batarya,string en, string boy)
        {
            this._model = model;
            this._batarya= batarya;
            this._en= en;
            this._boy= boy;
        }
        public string getModel()
        {
            return _model;
        }

        public string getBatarya()
        {
            return _batarya;
        }

        public string getEn()
        {
            return _en;
        }

        public string getBoy()
        {
            return _boy;
        }
    }
}
