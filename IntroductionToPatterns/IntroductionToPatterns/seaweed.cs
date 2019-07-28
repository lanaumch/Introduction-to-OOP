using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class seaweed : organicFood, IFood
    {
        public seaweed()
        { }

        public seaweed(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new seaweed(this.taste, this.calories, this.name);
        }
        public override string printType()
        {
            return this.name+" is seaweed" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
