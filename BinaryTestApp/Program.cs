using BinaryTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensorService = new BinarySensorsService(new List<SensorModel>()
            {
                new SensorModel(2, (float)1.1235),
                new SensorModel(5, (float)0.9876543)
            });

            sensorService.SensorValuesWrite();

            Console.ReadKey();
        }
    }
}
