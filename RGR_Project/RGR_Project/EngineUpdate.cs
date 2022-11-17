﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public class EngineUpdate : IStrategyBehaviour
    {
        private int avgspeed = 75;
        private int deliverytime = 30;
        public int GetNewAvgSpeed 
        {
            get { return avgspeed; } 
        }
        public int GetNewDeliveryTime 
        {
            get { return deliverytime; }
        }
        public void StrategyRun() {
            Console.WriteLine("A new engine has been updated");    
        }
    }
}
