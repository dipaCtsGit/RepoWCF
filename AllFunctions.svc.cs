using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Test
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AllFunctions" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AllFunctions.svc or AllFunctions.svc.cs at the Solution Explorer and start debugging.
    public class AllFunctions : IAllFunctions
    {
        public void DoWork()
        {
        }

        public string fn_GetRemainder(float x, float y)
        {
            try
            {
                float r;

                if (x == 0 || y == 0)
                {
                    return "Cannot divide by zero.";
                }
                else
                {
                    if (x > y)
                        r = x % y;
                    else
                        r = y % x;

                    return "The remainder is : " + r;
                }

            }
            catch (Exception ex)
            {
                return "Error in" + ex.Message;
            }
        }

        public string fn_GetPrime(int x)
        {
            try
            {
                int i = 0;
                int count = 0;
                for ( i = 1; i <= x; i++)
                {
                    if (x % i ==0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    return x + " is a prime number."; 
                else
                    return x + " is not a prime number.";

            }
            catch (Exception ex)
            {
                return "Error in" + ex.Message;
            }
        }
    }
}
