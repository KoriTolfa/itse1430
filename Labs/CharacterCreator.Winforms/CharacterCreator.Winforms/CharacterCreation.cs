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
            Dwarf user1 = new Dwarf();
        

            string output = " ";
            output += "Name: " + Txt_CharacterName.Text;

            //Check Gender
            output += "\nGender: " + (string)(this.Rb_Female.Checked ? "Female" : "Male"); //see which they have checked
            output += "\n Race: " + Cb_Race.Text;
            output += "\n Profession: " + Cb_Profession.Text;
            MessageBox.Show(output);

        }
    }
}
