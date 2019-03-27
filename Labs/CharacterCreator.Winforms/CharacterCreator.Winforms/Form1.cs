using System;
using System.Collections;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{

    public partial class MainForm : Form
    {
        private ArrayList CharacterList;
        private CharacterManager characterManager;

        public MainForm()
        {
            InitializeComponent();
            characterManager = new CharacterManager();
            CharacterList = characterManager.LoadCharacterSetFromDisk();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void B_CreateCharacter_Click(object sender, EventArgs e)
        {
            CharacterCreation Charcreator = new CharacterCreation();
            Charcreator.Show();
            CharacterList.Add(Charcreator.currentCharacter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            characterManager.SaveCharacterSetToDisk(CharacterList);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCharacter edit = new EditCharacter();
            edit.Show();
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
