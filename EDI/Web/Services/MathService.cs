﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using EDI.Web.Interfaces;

namespace EDI.Web.Services
{
    public class MathService : IMathService
    {
        private readonly ISharedService _sharedService;

        public MathService(
            ISharedService sharedService)
        {            
            _sharedService = sharedService;
        }
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
                _sharedService.WriteLogs("GetRandomPercent failed:" + ex.Message, false);

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
                _sharedService.WriteLogs("GetRandomNumber failed:" + ex.Message, false);

                return -1;
            }
        }
                
        public int GetPercent(int numerator, int denominator)
        {
            try
            {
                // use min to ensure not over 100% 
                int percent = Math.Min((int)Math.Round(((decimal)numerator / (decimal)denominator * 100),0, MidpointRounding.AwayFromZero),100);

               return percent;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetPercent failed:" + ex.Message, false);

                return -1;
            }
        }

        private int GetPercentComplete(int percentComplete, int numberOfQuestionnaires)
        {
            try
            {
                int percent = (int)Math.Round(((decimal)percentComplete / (decimal)numberOfQuestionnaires), 0, MidpointRounding.AwayFromZero);
                return percent;
            }
            catch (Exception ex)
            {

                _sharedService.WriteLogs("GetPercentComplete failed:" + ex.Message, false);

                return -1;
            }
        }

        public int GetPercentComplete(int numerator, int denominator, int numberOfQuestionnaires)
        {
            try
            {                
                int percentComplete = GetPercentComplete(GetPercent(numerator, denominator), numberOfQuestionnaires);
                return percentComplete;
            }
            catch (Exception ex)
            {

                _sharedService.WriteLogs("GetPercentComplete failed:" + ex.Message, false);

                return -1;
            }
        }
    }
}