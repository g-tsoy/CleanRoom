using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    class Reminder
    {
        public string Text { get; set; }
        public User From { get; set; }
        public DateTime DateOfSending { get; set; }
    }
}
