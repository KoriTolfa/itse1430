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

            var name = game.Name;
            if (name.Length == 0)
                /* is empty*/
                ;
            if (game.Name.Length == 0)
                /* is empty */
                ;

            var isCool = game.IsCoolGame;
            //game.IsCoolGame = false;

            //Validate(game)
            game.Validate();

            //var x = 10;
            //x.ToString();

            //var str = game.Publisher;            
            //Decimal.TryParse("45.99", out game.Price);

        }

        private void OnFileExit( object sender, EventArgs e )
        {
            //Local variable
            var x = 10;

            Close();
        }
        //HACK: Find first spot in array with no game
        private int GetNextEmptyGame()
        {
            for (var index = 0; index < _games.Length; ++index)
                if (_games[index] == null)
                    return index;

        }
        Button
        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }
        private void OnSave( object sender, EventArgs e )
        {
            Game = SaveData();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private decimal ReadDecimal( TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var value))
                return value;
            return -1;
        }

        private void LoadData( Game game )
        {

            _txtName.Text = game.Name;
            _txtPublisher.Text = game.Publisher;
            _txtPrice.Text = game.Price.ToString();
            _cbowned.Checked = game.Owned;
            _cbCompleted.Checked = game.Completed;

        }
        private Game SaveData()
        {
            var game = new Game();
            game.Name = _txtname.Text;
            game.Publisher = _txtPublisher.Text;
            game.Price = ReadDecimal(_txtPrice);
            game.Owned = _cbOwned.Checked;
            game.Completed = _cbcompleted.checked;

            return game;
            }

             void GameForm_Load( object sender, EventArgs e )
            {
                //Init UI if editing a game
                if (Game != null)
                    LoadData(Game);
            }
        }

        private void OnGameDelete( object sender, EventArgs e )
        {
            var selected = GetSelectedGame();
            if (selected == null)
                return;

            //display conformation
            MessageBox.Show(this, $"Are you sure you want to delete this game? {selected.Name}?","Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //TODo Delete
            _game = null;
        }

        private Game GetSelectedGame()
        {
            //c-style cast dont do it like this
           // var game = (Game)value;
            var value = _listGames.SelectedValue;
            var game = value as Game;
            //type check
            var game2 = (value is Game) ? (Game)value : null;
            //the is operator determines if the value in the left is compatibale with the type you requested

       
            return game;
        }
    }
}


