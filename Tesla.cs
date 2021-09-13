using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExe
{
    //טסלה הוא סוג של מכונית (שהיא סוג של כלי רכב
   public  class Tesla:Cars
    {
        const int MAXSPEED = 1000;
        //ניתן לשלוח לפעולה הבונה של מחלקת הבסיס גם ערכים קבועים
        public Tesla(int wheels,int volume):base(wheels,MAXSPEED,volume)
        {
            
        }
        public override void PlaySound()
        {
            base.PlaySound();
            Console.WriteLine("This is what Tesla Sounds Like");
            Console.WriteLine("VUSH VUSH");
        }

        //מעלה את המהירות למקסימום
        public void Redicolous()
        {
            speed = MAXSPEED;
        }
    }
}
