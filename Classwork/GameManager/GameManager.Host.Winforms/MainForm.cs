using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameManager.Host.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadUI();
        }

        void LoadUI()
        {
            Game game = new Game();

            game.Name = "DOOM";
            game.Price = 59.99M;
            var str = game.Publisher;

            Decimal.TryParse("45.99", out game.Price); //fields can be read or written just like a normal variable
        }

            private void OnfileExit ( object sender, EventArgs e )
            {

            Close();
            }

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show("Help");
        }
    
    }
    
}
