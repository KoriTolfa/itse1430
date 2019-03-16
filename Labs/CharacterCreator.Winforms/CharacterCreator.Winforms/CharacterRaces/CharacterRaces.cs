using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
    public enum CharacterGender { Male, Female}
    public abstract class CharacterRaces //made this abstract to use a base for all other races
    {
        //fields
        protected string name;
        protected CharacterGender gender;
        protected int strength, intelligence, agility, constitution, charisma, inebriation;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public CharacterGender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Strength
        {
            get { return strength; }
            protected set { strength = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            protected set { intelligence = value; }
        }

        public int Constitution
        {
            get { return constitution; }
            protected set { constitution = value; }
        }

        public int Agility
        {
            get { return agility; }
            protected set { agility = value; }
        }

        public int Charisma
        {
            get { return charisma; }
            protected set { charisma = value; }
        }


        public int Inebriation
        {
            get { return inebriation; }
            protected set { inebriation = value; }
        }

        // constructor
        public CharacterRaces()
        {
            Name = " ";
            Strength = 0;
            Charisma = 0;
            Agility = 0;
            Inebriation = 0;
            Constitution = 0;
            Intelligence = 0;


        }



    }
}
