﻿using System;

namespace IntroductionToSerialization
{
    public class seaweed : organicFood
    {
        public seaweed(string taste, int calories, string name) : base(taste, calories, name)
        {
            this.name = name;
            this.calories = calories;
            this.taste = taste;
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
