using System;

namespace IntroductionToSerialization
{
    public class Food
    {
        public string taste { get; protected set; }
        public int calories { get; protected set; }
        public string name { get; protected set; }

        public virtual string printType()
        {
            return "food";
        }
        public virtual string printValue()
        {
            return "";
        }
    }
}
