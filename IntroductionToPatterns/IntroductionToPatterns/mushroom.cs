using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class mushroom : organicFood, IFood
    {
        public mushroom()
        { }
        public mushroom(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new mushroom(this.taste, this.calories, this.name);
        }
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
