using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Cat:Animal
    {
        private string catName;

        public Cat (string catName, Boolean mamal, int legsNum, Boolean tail, string foodType) : base(mamal, legsNum, tail, foodType)
        {
            this.catName = catName;
        }

        public string getName()
        {
            return this.catName;
        }

        public new string makesSound()
        {
            return this.lives ? "Mnau" : "Sorry cat is not alive";

        }

        public override string makesSound2()
        {
            return this.lives ? "Mnau, Mnau" : "Sorry cat is not alive";

        }
    }
}
