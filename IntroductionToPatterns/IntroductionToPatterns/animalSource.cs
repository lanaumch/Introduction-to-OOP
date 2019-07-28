﻿using System;

namespace IntroductionToPlugins
{
    public abstract class animalSource : organicFood
    {
        public animalSource()
        { }
        public animalSource(string taste, int calories, string name):base(taste,calories,name)
        {
            this.calories = calories;
            this.taste = taste;
            this.name = name;
        }
        public override string printType()
        {
            return " animal source" + base.printType();
        }
        public override string printValue()
        {
            return "Taste: " + taste + ". Calories: " + calories + ".";
        }
    }
}
