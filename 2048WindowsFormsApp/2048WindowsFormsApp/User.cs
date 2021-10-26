using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048WindowsFormsApp
{
    public class User
    {
        public string name;
        public int result;

        public User(string text, int score)
        {
            name = text;
            result = score;
        }
    }
}
