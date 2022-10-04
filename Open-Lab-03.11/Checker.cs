using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string firsthalf = str.Substring(0, str.Length / 2);
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string lolik = new string(arr);

          
            string secondhalf = lolik.Substring(0, lolik.Length / 2);
            return firsthalf.Equals(secondhalf);
            
            
        } 
    }
}
