using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
   public class Dwarf : CharacterRaces //should inherit everything from the CharacterRaces Class
    {
        public Dwarf() :base ()
        {
           

        }
        public Dwarf(string name, CharacterGender gender) : base() // call base constructor and change name and gender to user preference
        {
            Name = name;
            Gender = gender;
            Strength = 60;
            Charisma = 20;
            Agility = 30;
            Inebriation = 0;
            Constitution = 60;
            Intelligence = 20;


        }
    }
}
