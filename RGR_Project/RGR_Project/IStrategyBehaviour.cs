using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_Project
{
    public interface IStrategyBehaviour
    {
        int GetNewAvgSpeed { get; }
        int GetNewDeliveryTime { get; }
        public void StrategyRun();
    }
}
