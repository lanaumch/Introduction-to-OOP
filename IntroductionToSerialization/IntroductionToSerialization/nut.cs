using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class nut : plantSource
    {
        public nut()
        { }
        public nut(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public override string printType()
        {
            return this.name + " is nut" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}

