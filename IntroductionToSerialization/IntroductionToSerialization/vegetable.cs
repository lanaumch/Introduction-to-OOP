﻿using System;

namespace IntroductionToSerialization
{
    [Serializable]
    public class vegetable : plantSource
    {
        public vegetable()
        { }
        public vegetable(string taste, int calories, string name) : base(taste, calories, name)
        {}
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
