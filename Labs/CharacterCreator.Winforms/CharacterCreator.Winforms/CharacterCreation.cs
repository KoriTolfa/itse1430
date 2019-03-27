using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator.Winforms.CharacterRaces;
using System.IO;
using System.Xml;
using System.Xml.Serialization; //trying to use serialization to save player data so we will see how this goes


namespace CharacterCreator.Winforms
{
    public partial class CharacterCreation : Form
    {
        public Character currentCharacter;

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void B_SaveCharacter_Click(object sender, EventArgs e)
        {
           

        
            //check for empty fields
            if (string.IsNullOrEmpty(Txt_CharacterName.Text))
            {
                MessageBox.Show("Must have a valid Character Name");
                return;
            }
          
            if (this.Rb_Female.Checked == false && this.Rb_Male.Checked ==false)
            {
                MessageBox.Show("Please choose a gender for you character");
                return;
            }
            string gender = (string)(this.Rb_Female.Checked ? "Female" : "Male");

            string name = Txt_CharacterName.Text;
            CharacterGender GenderSelect;

            if (this.Rb_Female.Checked)
                GenderSelect = CharacterGender.Female;
            else 
                GenderSelect = CharacterGender.Male;

            CharacterRace race;
            if (this.Cb_Race.Text == "Dwarf")
                race = CharacterRace.Dwarf;
            else if (this.Cb_Race.Text == "Elf")
                race = CharacterRace.Elf;
            else if (this.Cb_Race.Text == "Gnome")
                race = CharacterRace.Gnome;
            else if (this.Cb_Race.Text == "Half-elf")
                race = CharacterRace.HalfElf;
            else if (this.Cb_Race.Text == "Gnome")
                race = CharacterRace.Gnome;
            else if (this.Cb_Race.Text == "Human")
                race = CharacterRace.Human;
            else if (this.Cb_Race.Text == "Metalhead")
                race = CharacterRace.Metalhead;
            else
            {
                MessageBox.Show("Please choose a valid race for your character");
                return;
            }
            CharacterProfession profession;
            if (this.Cb_Profession.Text == "Fighter")
                profession  = CharacterProfession.Fighter;
            else if (this.Cb_Profession.Text == "Hunter")
                profession = CharacterProfession.Hunter;
            else if (this.Cb_Profession.Text == "Priest")
                profession = CharacterProfession.Priest;
            else if (this.Cb_Profession.Text == "Rogue")
                profession = CharacterProfession.Rogue;
            else if (this.Cb_Profession.Text == "Wizard")
                profession = CharacterProfession.Wizard;
            else if (this.Cb_Profession.Text == "Bard")
                profession = CharacterProfession.Bard;
            
            else
            {
                MessageBox.Show("Please choose a valid profession for your character");
                return;
            }
            //create  player object
            currentCharacter = new Character(name, GenderSelect, race, profession);
            //store data
            this.Close();
        }

     
  


 

        private void B_ExitCharCreate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_CharacterName_TextChanged(object sender, EventArgs e)
        {

        }
        public static String SettingsFolder
        {
            get
            {
                //string folder
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                
                //need to add folder path
                folder = Path.Combine(folder, "Character Creator");
                folder = Path.Combine(folder, "Player Settings");
                //need to check for folder, and create one if not there
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;



            }
        }


      /*  public Character GetPlayerData(Player player)
        {
            using (Stream stream = File.Create(SettingsFile))
            {
                XmlSerializer Serial = new XmlSerializer(player.GetType());
                Serial.Serialize(stream, player); //take character attributes and send to file
            }

        } */

        public static String SettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "PlayerSettings.xml");

            }

        }




    }

   
}
