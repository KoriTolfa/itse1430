using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager
{
    interface IContactDatabase
    {
        Contact Add(Contact contact);
        void Get();
        void GetAll();
        void Remove();
        void Update();
    }
}
