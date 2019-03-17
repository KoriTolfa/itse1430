using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
    public class Elf : CharacterRaces
    {
        public Elf() : base()
        {

        }
        public Elf(string name, CharacterGender gender) : base() // call base constructor and change name and gender to user preference
        {
            Name = name;
            Gender = gender;
            Strength = 30;
            Charisma = 60;
            Agility = 70;
            Inebriation = 0;
            Constitution = 30;
            Intelligence = 70;




        }
    }
}
