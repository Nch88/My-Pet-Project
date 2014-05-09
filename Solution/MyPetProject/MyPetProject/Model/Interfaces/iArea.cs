using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetProject.Model
{
    interface iArea
    {
        public string Name { get; }

        string Description();
        
        List<string> Interactions();

        List<string> Exits();
    }
}
