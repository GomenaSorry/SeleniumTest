using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.Settings;

namespace SeleniumTest.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }

    }
}
