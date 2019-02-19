using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionhwk
{
    class Program
    {
        static void Main(string[] args)
        {
          ICar cr = ChooseCar.carEngine("V16");
            cr.revEngine();
        }
    }

  

   public interface ICar
    {
        void revEngine();
    }

    public class EngineTypeV8 : ICar 
    {
        public void revEngine()
        {
            Console.WriteLine("vroom");
        }
    }

    public class EngineTypeV12 : ICar
    {
        public void revEngine()
        {
            Console.WriteLine("VRoom");
        }
    }

    public class EngineTypeV16 : ICar
    {
        public void revEngine()
        {
            Console.WriteLine("VROOOOOM");
        }
    }
    class ChooseCar
    {
        public static  ICar carEngine(string ce)
        {
            if (ce == "V16")
            {
                return new EngineTypeV16();
            }
            else
            {
                return new EngineTypeV8();
            }
        }
    }
}

