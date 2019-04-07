using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager
{
    public class Contact
    {
       
        public string Name
        {
            
            //get { return _name ?? ""; }
            get => _name ?? "";
            //set { _name = value ?? ""; }
            set => _name = value ?? "";
        }
        public string Email
        {
            get => _email ?? "";
            set => _email = value;
        }
        private string _name = "";
        private string _email = "";
    }
}
