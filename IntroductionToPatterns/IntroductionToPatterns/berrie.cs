using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class berrie : plantSource, IFood
    {
        public berrie()
        { }
        public berrie(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new berrie(this.taste, this.calories, this.name);
        }
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

