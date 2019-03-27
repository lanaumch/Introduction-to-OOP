using System;

namespace IntroductionToOOP
{
    public class organicFood : Food
    {
        public organicFood(string taste, int calories, string name)
        {
            this.name = name;
            this.calories = calories;
            this.taste = taste;
        }
        public organicFood() { }
        public string foodMeal { get; set; }
        public override string printType()
        {
            return " organic "+base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
