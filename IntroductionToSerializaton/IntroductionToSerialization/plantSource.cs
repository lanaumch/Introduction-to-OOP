using System;

namespace IntroductionToSerialization
{
    public class plantSource : organicFood
    {
        public plantSource(string taste, int calories, string name)
        {
            this.name = name;
            this.calories = calories;
            this.taste = taste;
        }
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
