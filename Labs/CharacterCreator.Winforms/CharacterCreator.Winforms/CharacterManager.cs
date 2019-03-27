using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using System.Diagnostics;
using CharacterCreator.Winforms.CharacterRaces;
using System.Reflection;

namespace CharacterCreator.Winforms
{

    public class Character
    {
        public string name;
        public CharacterGender gender;
        public CharacterRace race;
        public CharacterProfession profession;

        public Character(string nameSelected, CharacterGender GenderSelected, CharacterRace raceSelected, CharacterProfession professionSelected)
        {
            name = nameSelected;
            gender = GenderSelected;
            race = raceSelected;
            profession = professionSelected;
        }
        //protected int strength, intelligence, agility, constitution, charisma, inebriation;
    }



    public class CharacterManager
    {
        private static string CHARACTER_SET_FILE = "Set_Of_Characters.xml";


        public CharacterManager()
        {
            Directory.SetCurrentDirectory(System.Windows.Forms.Application.StartupPath);
           
        }

        #region Public methods



        public ArrayList LoadCharacterSetFromDisk()
        {
            ArrayList characterSet = new ArrayList();
            try
            {
                if (File.Exists(CHARACTER_SET_FILE))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Character) });
                    TextReader characterSetReader = new StreamReader(CHARACTER_SET_FILE);
                    characterSet = (ArrayList)serializer.Deserialize(characterSetReader);
                    characterSetReader.Close();
                }
            }
            catch (Exception)
            {
                // Intentionally do nothing
            }
            return characterSet;
        }


        public bool SaveCharacterSetToDisk(ArrayList characterSet)
        {
            bool saved = true;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Character) });
                StreamWriter characterSetWriter = new StreamWriter(CHARACTER_SET_FILE);
                serializer.Serialize(characterSetWriter, characterSet);
                characterSetWriter.Close();
            }
            catch (Exception)
            {
                saved = false;
            }
            return saved;
        }


        #endregion
    }
}