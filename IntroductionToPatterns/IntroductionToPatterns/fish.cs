﻿using System;

namespace IntroductionToPlugins
{
    [Serializable]
    public class fish : animalSource, IFood
    {
        public fish()
        { }
        public fish(string taste, int calories, string name) : base(taste, calories, name)
        {}
        public IFood Clone()
        {
            return new fish(this.taste, this.calories, this.name);
        }
        public override string printType()
        {
            return this.name + " is fish" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}

