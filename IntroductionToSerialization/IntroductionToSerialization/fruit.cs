using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class fruit : plantSource
    {
        public fruit()
        { }
        public fruit(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public override string printType()
        {
            return this.name + " is fruit" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}