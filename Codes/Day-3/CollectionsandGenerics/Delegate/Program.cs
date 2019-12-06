using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //1.
    delegate string FacilityInvoker(int args);
    //class FacilityInvoker
    //{
    //    private object _target;
    //    private System.Reflection.MethodInfo _method;
    //    public string Invoke(int args)
    //    {

    //    }
    //}

    class Facilities
    {
        public string GetAttendanceSheet(int number)
        {
            return $"got {number} sheets";
        }
        public string GetMarkers(int number)
        {
            return $"got {number} markers";
        }
    }
    class Helper
    {
        public string HelpTrainer(FacilityInvoker invoker, int args)
        {
            return invoker.Invoke(args);
        }
    }
    class Trainer
    {
        public void AvailFacility()
        {
            Facilities facilities = new Facilities();
            Helper anil = new Helper();

            FacilityInvoker invoker = new FacilityInvoker(facilities.GetMarkers);

            string data = anil.HelpTrainer(invoker, 2);
            Console.WriteLine(data);
        }
    }
    class Program
    {
        static void Main()
        {
            Trainer joy = new Trainer();
            joy.AvailFacility();
        }
    }
}
