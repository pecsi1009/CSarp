/*
   Dogs, frogs and cats are Animals.All animals can produce sound (specified by the ISound interface).
All animals are described by age, name and sex.Each animal produces a specific sound. Create arrays of
different kinds of animals and calculate the average age of each kind of animal using a static method 
(you may use LINQ).
*/
namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Animal
    {
        public enum Sex { Male, Female };
        protected string name;
        protected int age;
        protected Sex sex;
 
        public Animal(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
 
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
 
        public Sex GetSex
        {
            get { return this.sex; }
        }
 
        public virtual void Speak()
        {
            throw new NotImplementedException("This method is virtual!");
        }
 
        public static double CalcAverageAge(ICollection<Animal> arrayOfAnimals)
        {
            double sum = 0;
            foreach (Animal animal in arrayOfAnimals)
            {
                sum = sum + animal.age;
            }
            double average = sum * 1.0 / arrayOfAnimals.Count;
            return average;
        }
 
        public static string IdentifyAnimal(string soundToIdentify)
        {
            string result;
            switch (soundToIdentify)
            {
                case "Riibiitt!!!":
                    result = "Frog";
                    break;
                case "Myau!!!":
                    result = "Cat";
                    break;
                case "Woof, Woof, Woof!!!":
                    result = "Dog";
                    break;
                default:
                    result = "Unknown Animal";
                    break;
            }
            return result;
        }
    }
}
