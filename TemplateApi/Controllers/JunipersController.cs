using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TemplateApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JunipersController : ControllerBase
    {
        /// <summary>
        /// This Get method will return a hard-coded collection of chars.
        /// </summary>
        /// <returns></returns>
        [HttpGet("JunipersGet")]
        public IEnumerable<char> Getter()
        {
            List<char> ch = new List<char>();
            ch.Add('m');
            ch.Add('a');
            ch.Add('r');
            ch.Add('k');
            ch.Add('4');
            return ch;
        }

        /// <summary>
        /// this Post action method converts the httpquery string arg called 'word' 
        /// into a collection of the chars that made up the string arg.
        /// If no arg is sent, the default value of the variable is "no word" and 
        /// it will be acted up on by the method.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        [HttpPost("JunipersWordToChar/{word?}")]
        public ActionResult<List<char>> Post(string word = "No word")
        {
            List<char> ch = new List<char>();
            //loop to extract the chars
            foreach (char c in word)
            {
                ch.Add(c);
            }
            return ch;
        }

        /// <summary>
        /// this Put method will reverse the order of the words in the string arg sent.
        /// </summary>
        /// <returns></returns>
        [HttpPut("JunipersPut/{sentence?}")]
        public ActionResult<string> Put(string sentence = "sentence default a is This")
        {
            //separate the sentence into words in an array
            string[] wordArr = sentence.Split(' ');

            //reverse the order
            Array.Reverse(wordArr);

            // convert back into a string
            string newSentence = "";
            foreach (string x in wordArr)
            {
                newSentence += (x + ' ');
            }

            //return the string.
            return newSentence;
        }

        /// <summary>
        /// This Put method will delete the first word of a sentence.
        /// EXERCISE: have groups refactor to get all edge cases so no exceptions are thrown
        /// </summary>
        /// <returns></returns>
        [HttpPut("JunipersDelete/{sentence?}")]
        public ActionResult<string> Delete(string sentence = "one two three")
        {
            //loop til the first space and return everything after it.
            if (sentence[0] != ' ')// make sure the first char isn't a space. There are many other ways to break these methods.
            {
                for (int x = 1; x < sentence.Length; x++)
                {
                    if (sentence[x].Equals(' '))
                    {
                        // get a range of an array with the '..' between the starting 
                        // and element after the last char you want. 
                        return sentence[(x + 1)..(sentence.Length)];
                    }
                }
            }
            return "I\'m broken!";
        }
    }
}