using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Winforms.CharacterRaces;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void B_CreateCharacter_Click(object sender, EventArgs e)
        {
            CharacterCreation Charcreator = new CharacterCreation();
            Charcreator.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edit
           
        }

        private void B_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void B_DeleteCharacter_Click(object sender, EventArgs e)
        {
            DeleteCharacter delete = new DeleteCharacter();
            delete.Show();
        }
    }
    
}
