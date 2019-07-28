using System;

namespace IntroductionToPlugins
{
    public class inorganicFood : Food
    {
        public inorganicFood()
        { }
        public inorganicFood(string taste, int calories, string name)
        {}

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