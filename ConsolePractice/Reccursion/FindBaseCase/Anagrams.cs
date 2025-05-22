using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AnagramTree.src
{
    public class Anagrams
    {
        private nodeT root = new('\uffff');
        private char inf = ('\uffff');

        public void insertWord(string word)
        {
            string sortedWord = new string(word.ToLower().OrderBy(c => c).ToArray());
            nextNode(0, sortedWord, root, word);
        }

        public string[] findSubAnagram(string word)
        {
            string[] result = new string[0];
            string sortedWord = new string(word.ToLower().OrderBy(c => c).ToArray());
            result = searchNodes(sortedWord, root);
            return result;
        }

        public string[] findAnagram(string word)
        {
            string[] result = new string[0];
            string sortedWord = new string(word.ToLower().OrderBy(c => c).ToArray());
            int i = 0;
            nodeT currentNode = root;
            while (i < word.Length)
            {
                if (sortedWord[i] == currentNode.value)
                {
                    if (currentNode.rightChild == null)
                    {
                        return new string[0];
                    }
                    else
                    {
                        currentNode = currentNode.rightChild!;
                        i++;
                    }
                }
                else
                {
                    if (currentNode.leftChild == null)
                    {
                        return new string[0];
                    }
                    else
                    {
                        currentNode = currentNode.leftChild!;
                    }
                }
            }
            return currentNode.words.ToArray();
        }

        public void nextNode(int letterIndex, string sortedWord, nodeT currentNode, string word)
        {
            if (letterIndex == word.Length)
            {
                currentNode.words.Add(word);
            }
            else if (currentNode.value == inf)
            {
                currentNode.rightChild = new nodeT(inf);
                currentNode.value = sortedWord[letterIndex];
                nextNode(letterIndex + 1, sortedWord, currentNode.rightChild, word);
            }
            else if (currentNode.value < sortedWord[letterIndex])
            {
                nodeT nodeCopy = new nodeT(currentNode.value);
                nodeCopy.leftChild = currentNode.leftChild;
                nodeCopy.rightChild = currentNode.rightChild;
                currentNode.value = sortedWord[letterIndex];
                currentNode.leftChild = nodeCopy;
                currentNode.rightChild = new nodeT(inf);
                nextNode(letterIndex + 1, sortedWord, currentNode.rightChild, word);
            }
            else if (currentNode.value == sortedWord[letterIndex])
            {
                nextNode(letterIndex + 1, sortedWord, currentNode.rightChild!, word);
            }
            else
            {
                if (currentNode.leftChild == null)
                {
                    currentNode.leftChild = new nodeT(inf);
                    nextNode(letterIndex, sortedWord, currentNode.leftChild, word);
                }
                else
                {
                    nextNode(letterIndex, sortedWord, currentNode.leftChild, word);
                }
            }
        }

        public string[] searchNodes(string word, nodeT currentNode)
        {
            if (word.Length == 0)
            {
                return new string[0];
            }
            string[] result = new string[0];
            result = result.Concat(searchNodes(word.Substring(1), currentNode)).ToArray();
            if (word[0] < currentNode.value) {
                if (currentNode.leftChild == null)
                {
                    return result;
                }
                result = result.Concat(searchNodes(word, currentNode.leftChild)).ToArray();
            }
            else if (word[0] == currentNode.value)
            {
                result = result.Concat(currentNode.rightChild!.words).ToArray();
                result = result.Concat(searchNodes(word.Substring(1), currentNode.rightChild)).ToArray();
            }
            return result;
        }
    }
}
