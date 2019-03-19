using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Winforms.CharacterRaces
{
    public enum CharacterGender { Male, Female, unknown}
    public enum CharacterRace { Elf, HalfElf, Gnome, Human, Metalhead, Dwarf, unknown}
    public enum CharacterProfession {Fighter, Hunter, Priest, Rogue, Wizard, Bard, unkown }

    public abstract class CharacterRaces //made this abstract to use a base for all other races
    {
        //fields
        protected string name;
        protected CharacterGender gender;
        protected CharacterRace race;
        protected CharacterProfession profession;


        protected int strength, intelligence, agility, constitution, charisma, inebriation;
        public int Id { get; set; }
        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public CharacterRace Race
        {
            get { return race; }
             set { race = value; }

        }
        public CharacterGender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Strength
        {
            get { return strength; }
             set { strength = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
             set { intelligence = value; }
        }

        public int Constitution
        {
            get { return constitution; }
             set { constitution = value; }
        }

        public int Agility
        {
            get { return agility; }
             set { agility = value; }
        }

        public int Charisma
        {
            get { return charisma; }
             set { charisma = value; }
        }


        public int Inebriation
        {
            get { return inebriation; }
             set { inebriation = value; }
        }

        // constructor
        public CharacterRaces()
        {
            Name = " ";
            Gender = CharacterGender.unknown; //just giving it an unkown value for now
            Race = CharacterRace.unknown;
            profession = CharacterProfession.unkown;
            Strength = 0;
            Charisma = 0;
            Agility = 0;
            Inebriation = 0;
            Constitution = 0;
            Intelligence = 0;


        }



    }
}
