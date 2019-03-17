using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
    public class Metalhead : CharacterRaces
    {
        public Metalhead() : base()
        {
            
            
        }
        
        public Metalhead(string name, CharacterGender gender) : base() // call base constructor and change name and gender to user preference
        {
           Name = name;
           Gender = gender;
            Strength = 40;
            Charisma = 50;
            Agility = 10;
            Inebriation = 90;
            Constitution = 10;
            Intelligence = 10;




        }
    }
}
