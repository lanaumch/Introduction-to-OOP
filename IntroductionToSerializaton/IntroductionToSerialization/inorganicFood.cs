using System;

namespace IntroductionToSerialization
{
    public class inorganicFood : Food
    {
        public inorganicFood(string taste, int calories, string name)
        {
            this.name = name;
            this.calories = calories;
            this.taste = taste;
        }

        public override string printType()
        {
            return this.name + " is inorganic " + base.printType();

        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}