using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class cereal : plantSource, IFood
    {
        public cereal()
        { }
        public cereal(string taste, int calories, string name) : base(taste, calories, name)
        {
            this.name = name;
            this.calories = calories;
            this.taste = taste;
        }
        public IFood Clone()
        {
            return new cereal(this.taste, this.calories, this.name);
        }
        public override string printType()
        {
            return this.name + " is cereal" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
