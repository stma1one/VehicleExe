using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExe
{
  public class Vehicle
    {
 
        private int MaxSpeed;       //מהירות מקסימלית
        protected int wheels;//מספר גלגלים
        protected int speed;//מהירות נוכחית

        //פעולה בונה
        public Vehicle(int wheels,int MaxSpeed)
        {
            this.wheels = wheels;
            speed = 0;
            this.MaxSpeed = MaxSpeed;
        }

        //פעולות קובעות ומאחזרות
        public int GetWheels()
        {
            return wheels;
        }
        public void SetWheels(int w)
        {
            wheels = w;
        }
        public int GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(int speed)
        {
            if (speed < MaxSpeed)
                this.speed = speed;
        }
        //פעולה וירטואלית להשמעת צליל
        public virtual void PlaySound()
        {
            Console.WriteLine("this is what Vehicle sounds:");
            Console.WriteLine("VRUM VRUM");
        }

        //פעולה מתארת
        public override string ToString()
        {
            return $"this is a vehicle running on {wheels} wheels and speed of {speed} up to {MaxSpeed}";
        }
    }
}
