using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao.Entities
{
    internal class Departmet
    {
        public string Name { get; set; }

        public Departmet()
        {
        }

        public Departmet(string name)
        {
            Name = name;
        }
    }   

}
