/*
    Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
 Kittens and tomcats are cats.Kittens can be only female and tomcats can be only male.
 */
namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        { }

        public override void Speak()
        {
            Console.WriteLine("Myau! I am male cat!!!");
        }
    }
}
