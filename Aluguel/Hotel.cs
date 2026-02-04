using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste7
{
    internal class Hotel
    {
        public Hotel()
        {
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public Hotel(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome = {Name}, Email = {Email}";
        }
    }
}
