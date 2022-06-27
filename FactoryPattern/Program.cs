using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Abstract;
using FactoryPattern.Concrete;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern in Design Patterns");
            Console.WriteLine("");
            //Withot Factory
            Apple11 apple11=new Apple11("Apple11","2400","50","100");
            Console.WriteLine("Without Factory, "+apple11.getBatarya());
            Xaomi10 xaomi10 = new Xaomi10("Xaomi10","2000","40","30");
            Console.WriteLine("Without Factory, " + xaomi10.getBatarya());
            Console.WriteLine("");

            //With Factory
            ITelephone telXaomi=Factory.GetTelephone( "Xaomi10","Xaomibatarya","en","boy"); 
            ITelephone telApple=Factory.GetTelephone( "Apple11","Applebatarya","en","boy"); 

            Console.WriteLine("With Factory, " + telXaomi.getBatarya());
            Console.WriteLine("With Factory, " + telApple.getBatarya());
            Console.WriteLine("");

            //With Abstract Factroy ile 
            Apple11Factory apple11Factory = new Apple11Factory();
            ITelephone telephone = apple11Factory.geTelephone("Apple11","Applebatarya","AppleEn","AppleBoy");
            Xaomi10Factory xaomi10Factory = new Xaomi10Factory();
            ITelephone telephone2 = xaomi10Factory.geTelephone("Xaomi10","XaomiBatarya","XaomiEn","XaomiBoy");

            Console.WriteLine("With AbstractFactory," + telephone.getBatarya());
            Console.WriteLine("With AbstractFactory," + telephone2.getBatarya());

            Console.ReadKey();
        }
    }
}
