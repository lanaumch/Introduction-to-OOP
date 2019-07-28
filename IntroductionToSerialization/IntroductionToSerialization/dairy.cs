using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class dairy : animalSource
    {
        public dairy()
        { }
        public dairy(string taste, int calories, string name) : base(taste, calories, name)
        {}
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
