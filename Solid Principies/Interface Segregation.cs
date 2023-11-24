using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principies
{
    public interface IWorker
    {
        void Work();
        void TakeBreak();
    }

    public class Manager : IWorker
    {
        public void Work()
        {
            // methods
        }

        public void TakeBreak()
        {
            // methods
        }
    }

    public class Robot : IWorker
    {
        public void Work()
        {
            // Robot  methods
        }

        public void TakeBreak()
        {
            //
        }
    }

   //Burda class daxilinde istesek manageri islede bilerik istesek 
   //de robotu ve sonra yeni bir worker gelse onu Iworkerden implement edib
   //istifade ede bilerik

}
