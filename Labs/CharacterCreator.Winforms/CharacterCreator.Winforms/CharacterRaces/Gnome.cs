using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
   public  class Gnome : CharacterRaces
    {
        public Gnome() : base()
        {

        }

        public Gnome(string name, CharacterGender gender) : base() // call base constructor and change name and gender to user preference
        {
            Name = name;
            Gender = gender;
            Strength = 20;
            Charisma = 50;
            Agility = 80;
            Inebriation = 0;
            Constitution = 40;
            Intelligence = 40;




        }
    }
}
