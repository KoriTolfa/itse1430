using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
    public class Human : CharacterRaces
    {
        public Human() : base()
        {

        }
        public Human(string name, CharacterGender gender) : base() // call base constructor and change name and gender to user preference
        {
            Name = name;
            Gender = gender;
            Strength = 35;
            Charisma = 50;
            Agility = 50;
            Inebriation = 0;
            Constitution = 30;
            Intelligence = 55;

        }
    }
}
