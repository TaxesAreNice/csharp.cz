using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;


namespace SomeKindOfQuestionsOrSomething
{

    internal class Questions
    {
        QuestionSystem questionSystem = new QuestionSystem();

        private List<string> questionsFF = new List<string> { "bla bla bla, it's a", "bla bla bla, it's c", "bla,bla,bla, it's b" };
        private List<string> questionsFT = new List<string> { "a", "c", "b" };

        public List<string> GuetionsColector = new List<string>();

        private int i = 0;
        private bool correctAnwcerF = false;

        public string PickBetween = "";
        

        public void QuestionLoop(QuestionSystem questionSystem)
        {
            while (i < questionsFF.Count)
            {
                Console.WriteLine(questionsFF[i]);
                //questionSystem.questionSaver = questionSystem.questionSaver + "\n" + questionsFF[i];
                questionSystem.questionSaver.Add(questionsFF[i]);
                questionSystem.QuestionPicker();


                PickBetween += "\nPick between a,b,c";

                if (questionSystem.correctAnwcer == questionsFT[i])
                    {
                    Console.WriteLine("\nThat's correct!");
                    correctAnwcerF = true;
                }
                else
                {
                    Console.WriteLine("\nWrong answer!");
                    correctAnwcerF = false;
                }
                questionSystem.correctAnwcer = "";
                correctAnwcerFT(questionSystem);
                

                i++;
            }
        }

       
        public void correctAnwcerFT(QuestionSystem questionSystem)
        {
            if (correctAnwcerF == true)
            {
                questionSystem.answerASaver.Add("\nThat's correct!");
            }
            
            else if (correctAnwcerF == false)
            {
                questionSystem.answerASaver.Add("\nWrong answer!");
            }

            
        }

        
    }
}
