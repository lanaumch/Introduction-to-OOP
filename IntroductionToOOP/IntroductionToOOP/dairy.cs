using System;

namespace IntroductionToOOP
{
    public class dairy : animalSource
    {
        public dairy(string taste, int calories, string name) : base(taste, calories, name)
        {
            this.name = name;
            this.calories = calories;
            this.taste = taste;
        }
        public override string printType()
        {
            return this.name + " is dairy" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
