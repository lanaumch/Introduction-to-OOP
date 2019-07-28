using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class poultry : animalSource
    {
        public poultry()
        { }
        public poultry(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public override string printType()
        {
            return this.name + " is poultry" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
