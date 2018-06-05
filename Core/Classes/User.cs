using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoomID { get; set; }
        public List<Reminder> MyProperty { get; set; }
    }
}
