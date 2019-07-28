using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class mushroom : organicFood
    {
        public mushroom()
        { }
        public mushroom(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public override string printType()
        {
            return this.name + " is mashroom" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
