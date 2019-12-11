using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class DictionaryTerm : IComparable
    {
        public string Czech { get; set; }
        public string English { get; set; }

        public DictionaryTerm(string czech, string english)
        {
            Czech = czech;
            English = english;
        }

        public int CompareTo(object obj)
        {
            if (obj is DictionaryTerm)
            {
                return this.Czech.CompareTo((obj as DictionaryTerm).Czech);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Czech + "=" + English;
        }
    }
}
