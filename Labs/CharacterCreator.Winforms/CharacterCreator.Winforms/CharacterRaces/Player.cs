﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
    public class Player : CharacterRaces
    {
        public Player () :base ()
        {

        }
        public Player(string name, CharacterGender GenderSelect, CharacterRace race, CharacterProfession profession) :base()
        {
            Name = name;
            Gender = GenderSelect;
            Race = race;


        }
        
    }
}
