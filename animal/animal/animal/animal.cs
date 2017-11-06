using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    public class Animal
    {
        protected Boolean lives;

        public Boolean isMamal;
        public int legsNum;
        public Boolean tail;
        public string foodType;

        /// <summary>
        /// Make the animal alive
        /// </summary>
        public Animal()
        {
            this.lives = true;
        }

        /// <summary>
        /// makes the Animal alive, and setups some basic properties 
        /// </summary>
        /// <param name="mamal">Type of species, mamal, vertebrae etc...</param>
        /// <param name="legsNum">Number of legs</param>
        /// <param name="tail">Has a tail or not</param>
        /// <param name="foodType">What is the main food for the animal</param>
        public Animal (Boolean mamal, int legsNum, Boolean tail, string foodType)
        {
            this.lives = true;
            this.isMamal = mamal;
            this.legsNum = legsNum;

            this.foodType = foodType;
        }
        /// <summary>
        /// Function to set Base Animal live status
        /// </summary>
        /// <param name="st">Boolean</param>
        public void setLiveStatus(Boolean st)
        {
            this.lives = st;
        }

        /// <summary>
        /// Method to get the base sound of the animal....
        /// </summary>
        /// <returns>String</returns>
        public string makesSound()
        {
            return this.lives ? "No animal type defined animal is mute" : "Sorry animal is not alive !";
        }

        public virtual string makesSound2()
        {
            return this.lives ? "No animal type defined animal is mute" : "Sorry animal is not alive !";
        }
    }
}
