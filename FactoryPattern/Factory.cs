using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Factory
    {
        public void Main()
        {
            new NavigationBar();
            Console.WriteLine(Welcome());
            Console.WriteLine(new NavigationBar());
        }
        public class NavigationBar
        {
            //No Factory
            //public NavigationBar() => new Button { Type = "Default Button" };
            public NavigationBar() => ButtonFactory.CreateButton();
        }

        public class DropDownMenu
        {
            public DropDownMenu() => ButtonFactory.CreateButton();
        }

        public class ButtonFactory
        {
            public static Button CreateButton()
            {
                return new Button { Type = "Default Button" };
            }
        }

        public class Button
        {
            public string Type { get; set; }
        }
        public string Welcome()
        {
            return "Welcome To Factory Pattern";
        }

        
    }
}
