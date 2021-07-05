using System;

namespace Animals
{
    public class TomCat : Animal
    {
        private const string gender = "Male";
        public TomCat(string name, int age) 
            : base(name, age, " ")
        {
        }

        public override string Gender { get => base.Gender; set => base.Gender = gender; }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
