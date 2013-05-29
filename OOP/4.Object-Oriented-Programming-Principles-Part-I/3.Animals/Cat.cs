/*
    Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
Dogs, frogs and cats are Animals. 
 */
namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Cat : Animal
    {
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        { }

        public override void Speak()
        {
            Console.WriteLine("Myau!!!");
        }
    }
}