using System;

namespace IntroductionToSerialization
{
    public class berrie : plantSource
    {
        public berrie(string taste, int calories, string name) : base(taste, calories, name)
        {
            this.name = name;
            this.calories = calories;
            this.taste = taste;
        }
        public override string printType()
        {
            return this.name + " is berrie" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}

