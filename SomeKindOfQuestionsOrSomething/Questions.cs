using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeKindOfQuestionsOrSomething
{
    internal class Questions
    {

        QuestionSystem questionSystem = new();

        public void QuestionPrompt() 
        {
            Console.WriteLine("question hohoho (a/b/c)");
           
            questionSystem.AbcPickerSystem();

            if (questionSystem.a = true)
            {
                Console.WriteLine("You got it right!");
            }
            else 
            {
                Console.WriteLine("Wrong");
            }
            

        }
    }
}
