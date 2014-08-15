﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
namespace controller
{
   public  class MainviewController
    {
        
        public int ProcessorUsages()
        {
            PerformanceCounter pf_processorCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            int processorUsage = (int)pf_processorCounter.NextValue();
            return processorUsage;
        }
        
        public float MemoryUsage()
        {
            PerformanceCounter pf_MemoryCounter_Total = new PerformanceCounter("Memory", "Free & Zero Page List Bytes", "");
            float total = (pf_MemoryCounter_Total.NextValue() / 1024)/1024;
            PerformanceCounter pf_MemoryCounter_Avaiable = new PerformanceCounter("Memory", "Available MBytes", "");
            float memoryFree = pf_MemoryCounter_Avaiable.NextValue();
            float percentage = (total - memoryFree) / total;
            return memoryFree;
        }

        
    }
}
