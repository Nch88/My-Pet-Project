using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetProject.Model.Interfaces
{
    interface iMain
    {
        Dictionary<string, string> Commands;

        string Description();

        string CommandsDescription();
        
    }
}
