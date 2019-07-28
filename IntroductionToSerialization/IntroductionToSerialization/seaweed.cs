using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class seaweed : organicFood
    {
        public seaweed()
        { }

        public seaweed(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public override string printType()
        {
            return this.name+" is seaweed" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
