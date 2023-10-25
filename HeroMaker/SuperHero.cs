using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class SuperHero
    {
        public String Name { get; set; }
        public DateTime DOB { get; set; }
        public List<string> Abilities { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int DarkSide { get; set; }
        public string Transport { get; set; }
        public bool hasSecretID { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public string Cape { get; set; }
        public string Suit { get; set; }
        public string SymbolFilePath { get; set; }



        public SuperHero()
        {

        }


        /// <summary>
        /// Displays Superhero's attributes.
        /// (except Cape color, suit color, symbol image, and portrait image)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string hero,
                 powers = "";

            foreach (string item in this.Abilities)
            {
                powers += item + " ";
            }

            hero = String.Format("Name: {0}\n" +
                "Gender: {1}\n" +
                "DOB: {2}\n" +
                "Years of Experience: {3}\n" +
                "Abilities: {4}\n" +
                "Dark Side Propensity: {5}\n" +
                "Stats: Speed = {6}\tStamina = {7}\tStrength = {8}\n" +
                "Transportation: {9}\n", Name, Gender, DOB, Experience,
                powers, DarkSide, Speed, Stamina, Strength, Transport);

            if (hasSecretID)
            {
                hero += "(Hero has a secret identity)\n";
            }

            return hero;
        }
    }
}
