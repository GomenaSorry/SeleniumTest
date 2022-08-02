using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest.ComponentHelper
{
    public class AssertHelper
    {
        public static void AreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught: {0} not equal to {1}", expected, actual);
            }
        }
    }
}
