using System;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string gender = "Female";
        public Kitten(string name, int age) 
            : base(name, age, " ")
        {
        }
        public override string Gender { get => base.Gender; set => base.Gender = gender; }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
