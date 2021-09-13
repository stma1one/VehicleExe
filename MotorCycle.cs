using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExe
{
    public class MotorCycle:Vehicle
    {
        const int MAXSPEED = 40;
        const int MAXWHEELS = 2;
        //לא חייבים שתמיד יהיו פרמטרים... אפשר להעביר גם קבועים
        public MotorCycle():base(MAXWHEELS,MAXSPEED)
        {

        }
        public override void PlaySound()
        {
            base.PlaySound();
            Console.WriteLine("This is What a MotorCycle sounds like");
            Console.WriteLine("ZOOM ZIIM");
        }
    }
}
