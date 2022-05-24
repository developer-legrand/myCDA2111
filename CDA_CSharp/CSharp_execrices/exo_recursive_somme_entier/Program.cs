using System;

namespace exo_palindrome_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "laval";
            int indexStart = 0;
            int stringLength = test.Length;
            Console.WriteLine(IsPalindrome(test, indexStart, stringLength));
        }

        public static bool IsPalindrome(string _text, int _indexstart, int _stringLength)
        {
            if (_indexstart >= _stringLength)
            {
                return true;
            }
            else
            {
                if (_text.Substring(_indexstart, 1) != _text.Substring(_stringLength - 1, 1))
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(_text, _indexstart + 1, _stringLength - 1);
                }
            }
        }
    }
}