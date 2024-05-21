using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidatorTest
{
    public class EmailTestBase
    {

       // Not working as intended
        public TestContext TestContext { get; set; }

        public T GetTestSetting<T>(string name, T defaultValue)
       {
            T returnValue = defaultValue;

            try
           {
                var temp = TestContext.Properties[name];
                if (temp != null)
                {
                    returnValue = (T)Convert.ChangeType(temp, typeof(T));
                }
           }

            catch
            {
                //ignore
            }
            return returnValue;
       }
    }
}
