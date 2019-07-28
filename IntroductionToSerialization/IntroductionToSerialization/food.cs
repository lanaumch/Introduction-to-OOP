using System;
using System.Xml.Serialization;

namespace IntroductionToSerialization
{
    [Serializable]
    [XmlInclude(typeof(berrie))]
    [XmlInclude(typeof(cereal))]
    [XmlInclude(typeof(dairy))]
    [XmlInclude(typeof(fish))]
    [XmlInclude(typeof(fruit))]
    [XmlInclude(typeof(mushroom))]
    [XmlInclude(typeof(nut))]
    [XmlInclude(typeof(poultry))]
    [XmlInclude(typeof(seaweed))]
    [XmlInclude(typeof(vegetable))]
    [XmlInclude(typeof(inorganicFood))]

    public abstract class Food
    {
        public string taste { get; set; }
        public int calories { get; set; }
        public string name { get; set; }

        public Food()
        { }

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
