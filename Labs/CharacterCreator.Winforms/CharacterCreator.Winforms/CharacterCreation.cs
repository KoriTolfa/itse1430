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

namespace CharacterCreator.Winforms
{
    public partial class CharacterCreation : Form
    {
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
            //Dwarf Object 
            Dwarf Char1 = new Dwarf();
            Elf Char2 = new Elf();
            Gnome Char3 = new Gnome();
            HalfElf Char4 = new HalfElf();
            Human Char5 = new Human();
            Metalhead Char6= new Metalhead ();

        
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

           

        }

        private void B_ExitCharCreate_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Txt_CharacterName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
