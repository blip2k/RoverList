using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            list.Add("blip");
            list.Add("clip");
            list.Add("lip");
            list.Add("hip");
            list.Add("tip");
            list.Add("rip");
            list.Add("flip");
            list.Add("slip");
            list.Add("pip");
            list.Add("whip");
            list.Add("zip");
            list.Add("grip");
            list.Add("chip");
            list.Add("snip");
            list.Add("drip");
            list.Add("skip");

            list.ListNodes();

            Console.WriteLine("Type in a word then type done when you have done so");
            String word = "";
            while (word != "done")
            {
                if (word == "done")
                {
                    break;
                }
                else
                {
                    list.Add(word);
                    word = Console.ReadLine();
                }
            }

            Console.WriteLine("Type in a word at the front of the list now. Type done when finished.");
            word = "";
            while (word != "done")
            {
                if (word == "done")
                {
                    break;
                }
                else
                {
                    list.Add(0, word);
                    word = Console.ReadLine();
                }
            }
            list.ListNodes();

            for (int i = 0; i < list.toCount() - 2; i++)
            {
                string d = list.ElementAt(i);
                if (list.ElementAt(i) != null)
                {

                    int length = d.Length;

                    if (length % 2 == 1)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
            list.ListNodes();

            list.Clear();
            list.ListNodes();
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
