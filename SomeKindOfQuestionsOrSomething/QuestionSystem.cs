using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeKindOfQuestionsOrSomething
{
    internal class QuestionSystem
    {
        private bool a = false;
        private bool b = false;
        private bool c = false;
        private bool jh = false;




        public string AbcPickerSystem()
        {
            string? odpoved = Console.ReadLine();

            if (odpoved == "a")
            {
                a = true;
                Console.WriteLine("You picked a");
            }
            else if (odpoved == "b") 
            { 
                b = true;
                Console.WriteLine("You picked b");
            }
            else if (odpoved == "c") 
            {
                c = true;
                Console.WriteLine("You picked c");
            }
            else 
            {
                jh = true;
                Console.WriteLine("wrong");

            }

            return odpoved;
        }












    }
}
