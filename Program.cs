using System;

namespace VehicleExe
{
    class Program
    {
        /// <summary>
        /// פעולה המקבלת מערך של כלי רכב ומדפיסה 
        /// את נתוני כלי הרכב על ידי קריאה לפעולת
        /// ToString()
        /// </summary>
        /// <param name="v"> מערך כלי רכב</param>
        public static void PrintVehicles(Vehicle[] v)
        {
            Console.WriteLine("These Are The Vehicles:");
            for (int i = 0; i < v.Length; i++)
            {
                //ירושה בפעולה
                //זהה לקריאה 
                //Console.WriteLine(v[i].ToString());
                Console.WriteLine(v[i]);
            }
        }
        static void Main(string[] args)
        {
            //שימו לב שכרגע המערך מכיל 5 תאים אך כולם ריקים 
            //null!
            Vehicle[] v = new Vehicle[5];
            //האובייקטים ייווצרו רק בזמן ריצה. כאשר הפעולה הבונה תופעל
            v[0] = new Vehicle(12, 50000);
            v[1] = new Cars(4, 250, 2800);
            v[2] = new Tesla(4, 2800);
            v[3] = new MotorCycle();
            v[4] = new Bicycle(false, 2);

            //קוקו...השמיעו קול
            for (int i = 0; i < v.Length; i++)
            {
                //פולימורפיזם בהתגלמותו
                v[i].PlaySound();
                Console.WriteLine("-----------------------");

            }
            //נעדכן את המהירות של כל המכוניות ל10 חוץ מטסלה שתעבור למהירות רידיקולוס
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] is Tesla)
                    ((Tesla)v[i]).Redicolous();
                else
                    v[i].SetSpeed(10);
            }

            PrintVehicles(v);

            //נעצור רק את המכוניות!

            for (int i = 0; i < v.Length; i++)
            {
                //מספיק לבדוק שכלי הרכב הוא מכונית 
                //כי כל מה שיורש ממכונית הוא סוג של מכונית
                if (v[i] is Cars)
                {
                    //אחרי שוידאנו שההמרה בטוחה...
                    //לא לשכוח לבצע את ההמרה....

                    ((Cars)v[i]).Break();
                }
            }
            Console.WriteLine("Only Cars should have 0 kph");
            PrintVehicles(v);

        }
    }
}
