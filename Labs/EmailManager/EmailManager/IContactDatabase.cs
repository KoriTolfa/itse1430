using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager
{
    interface IContactDatabase
    {
        void Add();
        void Get();
        void GetAll();
        void Remove();
        void Update();
    }
}
