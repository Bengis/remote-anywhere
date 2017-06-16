using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BOL
{
    public class Counter
    {
        public delegate void CounterCPUUpdateHandler(String salida);
        public event CounterCPUUpdateHandler cpuUpdated;

        public Boolean end = false;

        public void GetCounter()
        {
            try
            {
                String appName = "RemoteAnywhere";
                PerformanceCounter process_cpu = new PerformanceCounter("Process", "% Processor Time", appName);
                PerformanceCounter ramCounter = new PerformanceCounter("Process", "Working Set", appName);
                float cpu, ram;
                String salida;
                while (!(end))
                {
                    cpu = process_cpu.NextValue();
                    ram = ramCounter.NextValue();
                    ram = ram / 1024 / 1024;
                    ram = (float)(Math.Truncate((double)ram * 100.0) / 100.0);
                    cpu = (float)(Math.Truncate((double)cpu * 100.0) / 100.0);
                    salida = "CPU: " + (cpu) + " %; RAM: " + (ram) + " MB ";
                    Thread.Sleep(1000);
                    if ((cpuUpdated != null) && (!end))
                    {
                        cpuUpdated(salida);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
