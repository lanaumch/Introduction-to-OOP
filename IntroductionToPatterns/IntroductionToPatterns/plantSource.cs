using System;

namespace IntroductionToPlugins
{
    public abstract class plantSource : organicFood
    {
        public plantSource()
        { }
        public plantSource(string taste, int calories, string name)
            :base(taste, calories, name) {}
        public override string printType()
        {
            return " plant source" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
