using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205.Isomorphic_Strings
{

    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            return IsomorphicChecker(s,t) && IsomorphicChecker(t,s);
        }

        private bool IsomorphicChecker(string s, string t)
        {
            var dic = new Dictionary<char, char>();
            foreach (var c in Enumerable.Zip(Enumerable.Range(0, s.Length), s, (a, b) => new { Index = a, Character = b }))
            {
                if (!dic.ContainsKey(c.Character))
                {
                    dic.Add(c.Character, t[c.Index]);
                }
                else
                {
                    if (t[c.Index] != dic[c.Character])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
