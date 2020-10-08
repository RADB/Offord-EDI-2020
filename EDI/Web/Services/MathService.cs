using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using EDI.Web.Interfaces;

namespace EDI.Web.Services
{
    public class MathService : IMathService
    {
        public int GetRandomPercent(int minimum, int maximum)
        {
            try
            {
                Random rnd = new Random();
                int percent = rnd.Next(minimum, maximum);

                return percent;
            }
            catch (Exception ex)
            {
                Log.Error("GetRandomPercent failed:" + ex.Message);

                return -1;
            }
        }
        public int GetRandomNumber(int minimum, int maximum)
        {
            try
            {
                Random rnd = new Random();
                int number = rnd.Next(minimum, maximum);

                return number;
            }
            catch (Exception ex)
            {
                Log.Error("GetRandomNumber failed:" + ex.Message);

                return -1;
            }
        }
                
        public int GetPercent(int numerator, int denominator)
        {
            try
            {
                int percent = (int)Math.Round(((decimal)numerator / (decimal)denominator * 100),0, MidpointRounding.AwayFromZero);

               return percent;
            }
            catch (Exception ex)
            {
                Log.Error("GetPercent failed:" + ex.Message);

                return -1;
            }
        }
    }
}