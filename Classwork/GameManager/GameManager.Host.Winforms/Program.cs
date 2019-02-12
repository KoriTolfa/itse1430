using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    /// <summary>Represents a game.</summary> //internal is the default for accesbility
    public class Game
    {
        /// <summary>Name of the game.</summary>
       // public string Name= ""; //how you declare a field, fields have an optional acces modifier, a field is just a variable
        public string Name
        {
            get { return _name; }
            set {_name = value } //vale is a keyword in the context of set 

        }
        private string _name = " ";
        public string publisher
        {
            get { return _Publisher; }
            set { _Publisher = value; }
           
        }
        /// <summary>Publisher of the game.</summary>
        /////prperties look like data but dont store data
        ///
        private string _Publisher ="";
        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        private decimal _Price;
        public bool Owned;
        public bool Completed;

        public bool Validate()
        {
            //Name is required
            if (String.IsNullorEmpty(Name))
                return false;
                
                //price>=0
                
            if (Price< 0)
             return false;

            return true;
        }
    }
}