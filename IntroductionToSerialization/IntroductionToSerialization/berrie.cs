using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class berrie : plantSource
    {
        public berrie()
        { }
        public berrie(string taste, int calories, string name) : base(taste, calories, name)
        {}
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

