using MyPetProject.Model;
using MyPetProject.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPetProject.View
{
    class Presenter
    {
        private iMain main;

        private IDictionary<Type, int> typeSwitch;

        public Presenter()
        {
            typeSwitch.Add(typeof(iMain), 1);
            typeSwitch.Add(typeof(iArea), 2);
            typeSwitch.Add(typeof(object), -1);
        }

        public void PresentMain()
        {
            Console.WriteLine(main.Description());
        }

        public void PresentArea(iArea area)
        {
            int count = 1;
            List<string> interactions = area.Interactions();
            List<string> exits = area.Exits();

            Console.WriteLine(area.Description());
            Console.WriteLine();

            if (interactions != null && interactions.Count != 0)
            {
                count = 1;
                
                Console.WriteLine("Of particular interest you see:");
                foreach (string interaction in interactions)
                {
                    Console.WriteLine(count++ + ": " + interaction);
                }
            }

            count = 1;
            Console.WriteLine("You can exit this area towards:");
            foreach (string exit in exits)
            {
                Console.WriteLine(count++ + ": " + exit);
            }
        }

        private void UserInput(object context)
        {
            int type = typeSwitch[context.GetType()];


            switch (type)
            {
                case 1://iMain
                    string userInput = InputLower();
                    if (userInput.Equals("h"))
                    {
                        Console.WriteLine("You need help buddy?");
                    }
                    break;
                case 2://iArea
                    break;
                default:
                    throw new Exception("This is bad! Presenter, UserInput");
                    break;
            }
        }

        private string InputLower()
        {
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            return userInput;
        }
    }
}
