using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Abstract;

namespace FactoryPattern.Concrete
{
    internal class Xaomi10 : ITelephone
    {
        private string model;
        private string batarya;
        private string en;
        private string boy;

        public Xaomi10(string model, string batarya, string en, string boy)
        {
            this.model = model;
            this.batarya = batarya;
            this.en = en;
            this.boy = boy;
        }
        public string getModel()
        {
            return model;
        }

        public string getBatarya()
        {
            return batarya;
        }

        public string getEn()
        {
            return en;
        }

        public string getBoy()
        {
            return boy;
        }
    }
}
