using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExe
{
    //אופניים סוג של כלי רכב
    public class Bicycle:Vehicle
    {
        const int MAXSPEED = 50;
        //מכיוון שאין ירושה לאופנים- ההרשאה תהיה פרטית
        private bool hasHelpers;//האם יש גלגלי עזר

        public Bicycle(bool helpers,int wheels):base(wheels,MAXSPEED)
        {
            hasHelpers = helpers;
        }
        public bool GetHasHelpers()
        {
            return hasHelpers;
        }
        public void SetHasHelpers(bool has)
        {
            hasHelpers = has;
        }
        public override void PlaySound()
        {
            base.PlaySound();
            Console.WriteLine("This is what Bicycle Sounds like");
            Console.WriteLine("GLING GLING");
        }
    }
}
