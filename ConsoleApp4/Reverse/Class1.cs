using System;

namespace Reverse
{
    public class Class1
    {
        public string S;
        public Class1(string s) { S = s; }

        public string reverse()
        {
            string s = "";
            for (int i = S.Length - 1; i >= 0; i--)
            {
                s += S[i];
            }
            return s;
        }
    }
}
