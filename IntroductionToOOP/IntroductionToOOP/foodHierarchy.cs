using System;

namespace IntroductionToOOP
{
    class foodHierarchy
    {
        public static void Main(string[] args)
        {
            inorganicFood salt = new inorganicFood("salty", 0, "Salt");
            Console.WriteLine(salt.printType());
            Console.WriteLine(salt.printValue());
            mushroom chanterelle = new mushroom("salty", 20, "Chanterelle");
            Console.WriteLine(chanterelle.printType());
            Console.WriteLine(chanterelle.printValue());
            seaweed kelp = new seaweed("salty", 25, "Kelp");
            Console.WriteLine(kelp.printType());
            Console.WriteLine(kelp.printValue());
            fruit grapefruit = new fruit("bitter", 42, "Grapefruit");
            Console.WriteLine(grapefruit.printType());
            Console.WriteLine(grapefruit.printValue());
            vegetable garlic = new vegetable("pungent", 143, "Garlic");
            Console.WriteLine(garlic.printType());
            Console.WriteLine(garlic.printValue());
            cereal corn = new cereal("sweet", 123, "Corn");
            Console.WriteLine(corn.printType());
            Console.WriteLine(corn.printValue());
            berrie cranberry = new berrie("sour", 46, "Cranberry");
            Console.WriteLine(cranberry.printType());
            Console.WriteLine(cranberry.printValue());
            nut hazelnut = new nut("sweet", 628, "Hazelnut");
            Console.WriteLine(hazelnut.printType());
            Console.WriteLine(hazelnut.printValue());
            meat pork = new meat("salty", 242, "Pork");
            Console.WriteLine(pork.printType());
            Console.WriteLine(pork.printValue());
            poultry chicken = new poultry("salty", 135, "Chicken");
            Console.WriteLine(chicken.printType());
            Console.WriteLine(chicken.printValue());
            fish salmon = new fish("salty", 208, "Salmon");
            Console.WriteLine(salmon.printType());
            Console.WriteLine(salmon.printValue());
            dairy yogurt = new dairy("sour", 59, "Yogurt");
            Console.WriteLine(yogurt.printType());
            Console.WriteLine(yogurt.printValue());
        }
    }
}
