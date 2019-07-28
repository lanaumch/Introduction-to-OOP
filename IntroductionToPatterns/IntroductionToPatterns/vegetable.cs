using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class vegetable : plantSource, IFood
    {
        public vegetable()
        { }
        public vegetable(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new vegetable(this.taste, this.calories, this.name);
        }
        public override string printType()
        {
            return this.name + " is vegetable" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
