using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class poultry : animalSource, IFood
    {
        public poultry()
        { }
        public poultry(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new poultry(this.taste, this.calories, this.name);
        }
        public override string printType()
        {
            return this.name + " is poultry" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
