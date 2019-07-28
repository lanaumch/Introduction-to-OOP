using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class fish : animalSource
    {
        public fish()
        { }
        public fish(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public override string printType()
        {
            return this.name + " is fish" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}

