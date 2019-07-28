using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroductionToPlugins;

namespace UnknownMeat
{
    [Serializable]
    public class UnknownMeat: meat
    {
        public UnknownMeat()
        { }
        public UnknownMeat(string taste, int calories, string name) : base(taste, calories, name)
        { }
        public override string printType()
        {
            return this.name + " is poultry" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
