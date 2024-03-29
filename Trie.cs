﻿using System;
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
            //var child = root.Children;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    var ltr = word[i];
            //    Node triend;
            //}
            Node tracker = root;
            var alltheChildren = root.Children;

            for (int i = 0; i < word.Length; i++)
            {
                var ltr = word[i];
                
                if(!tracker.Children.ContainsKey(ltr)) // checks if it is contained in the trie
                {
                    tracker.Children.Add(ltr, new Node(ltr)); // adds teh tracker at the child
                }

                tracker = tracker.Children[ltr]; // move tracker

                if(i == word.Length - 1)
                {
                    tracker.IsWord = true;
                }
            }

            
        }
        
        public bool Contains(string word)
        {
            var searchnode = SearchNode(word);
        }
        
        private Node SearchNode(string word)
        {
            var temporaryChildren = root.Children;
        }
        /*
        public List<string> GetAllMatchingPrefix(string prefix)
        {

        }
        */
        public bool Remove(string prefix)
        {
            var foundnode = SearchNode(prefix);
            if(foundnode == null)
        }
        
    }
}
