using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class nut : plantSource, IFood
    {
        public nut()
        { }
        public nut(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new nut(this.taste, this.calories, this.name);
        }
        public override string printType()
        {
            return this.name + " is nut" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}

