using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class dairy : animalSource, IFood
    {
        public dairy()
        { }
        public dairy(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new dairy(this.taste, this.calories, this.name);
        }
        public override string printType()
        {
            return this.name + " is dairy" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
