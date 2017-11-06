using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Dog : Animal
    {

        private string dogName;
        

        public Dog(string name,Boolean mamal, int legsNum, Boolean tail, string foodType):base(mamal,legsNum, tail, foodType)
        {
            this.dogName = name;
        }

        public string getName()
        {
            return this.dogName;
        }

        public new string makesSound()
        {
            return this.lives ? "makes Haf" : "Dog is not alive !"; 
        }

        public override string makesSound2()
        {
            return this.lives ? "makes Haf, Haff" : "Dog is not alive !";
        }



    }
}
