using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    // not implement DIP

    //internal class SirenAlert
    //{
    //    public void Alert()
    //    {
    //        Console.WriteLine("danger detects");
    //    }
    //}

    //internal class BaseDefenseController
    //{
    //    private SirenAlert alert;

    //    public void StartAlert()
    //    {
    //        alert.Alert();
    //    }
    //}


    //  implement DIP

    internal interface IAlert
    {
        public void Alert();
    }
    internal class SirenAlert : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Siren detects danger!");
        }
    }

    internal class DroneDispatchAlert : IAlert
    {
        public void Alert()
        {
            Console.WriteLine("Drone danger detects!");
        }
    }

    internal class BaseDefenseController 
    {
        private IAlert alert;

        public void StartAlert()
        {
            alert.Alert();
        }
    }
}
