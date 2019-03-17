using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
    public class HalfElf : CharacterRaces
    {
        public HalfElf() : base()
        {

        }
        public HalfElf(string name, CharacterGender gender) : base() // call base constructor and change name and gender to user preference
        {
            Name = name;
            Gender = gender;
            Strength = 35;
            Charisma = 55;
            Agility = 60;
            Inebriation = 0;
            Constitution = 30;
            Intelligence = 65;

        }
    }
}
