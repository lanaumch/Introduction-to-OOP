using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class fruit : plantSource, IFood
    {
        public fruit()
        { }
        public fruit(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new fruit(this.taste, this.calories, this.name);
        }
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