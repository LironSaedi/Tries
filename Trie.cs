using System;
using System.Collections.Generic;
using System.Text;

namespace Tries
{
    public class Trie 
    {
        private Node root;
        Dictionary<char, Node> starts;

        public void Clear()
        {
            
        }

        public void Insert(string word) 
        {
            // loop to see if what the word length of any of the words are
            //check to see wheter or not the caracter exists. If it does
            var child = root.Children;
            for (int i = 0; i < word.Length; i++)
            {
                var ltr = word[i];
                Node triend;
            }

            if (child.)
        }

        public bool Contains(string word)
        {

        }

        private Node SearchNode(string word)
        {

        }

        public List<string> GetAllMatchingPrefix(string prefix)
        {

        }

        public bool Remove(string prefix)
        {

        }
    }
}
