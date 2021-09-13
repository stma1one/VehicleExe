using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExe
{
    //מחלקת מכוניות- יורשת מכלי רכב - סוג של כלי רכב
    public class Cars:Vehicle
    {
        protected int engineVolume;

        //פעולה הבונה מקבלת את כל הפרמטרים שדרושים לפעולה הבונה של מחלקת הבסיס
        //ומטפלת רק בתכונות החדשות
        public Cars(int wheels,int maxs,int volume):base(wheels,maxs)
        {
            engineVolume = volume;
        }

        public int GetEngineVolume()
        {
            return engineVolume;
        }
        public void SetEngineVolume(int v)
        {
            engineVolume = v;
        }

        //הפעולה דורסת את הפעולה של כלי רכב
        public override void PlaySound()
        {
          
            //הפעלת פעולה של ההורה
            base.PlaySound();

            Console.WriteLine("this is what a car sounds like:");
            Console.WriteLine("VAVUM VAVUM");
        }
        //פעולה שקיימת רק ברכב
        public void Break()
        {
            speed = 0;
        }
    }
}
