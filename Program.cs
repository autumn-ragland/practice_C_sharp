using System;

namespace practice_C_sharp
{
    class Program
    {
        static void Main(string[] args) // main functin to call isAnagram()
        {
            Console.WriteLine("Welcome to the anagram test!"); // announce the program

            if(isAnagram()){ // function takes two params and returns true or false
                Console.WriteLine("These words are anagrams!");  // if true TRUE
            }
            else{
                Console.WriteLine("These words are NOT anagrams"); // if false FALSE
            }
        }

        public static bool isAnagram(){ // function takes two strings and returns true or false
            Console.WriteLine("Enter your first string");
            string str1 = Console.ReadLine().ToLower();   
            Console.WriteLine("Enter your second string");
            string str2 = Console.ReadLine().ToLower();
            int count1 = 0; // counter for iterations
            int count2 = 0; // lenght of the second param
            bool anagram = false; // default bool value

            for(int i = 0; i<str1.Length - 1; i++){ //iterate through the string
                count1++; // keep track of iterations aka length of string 1
                count2 = str2.Length - 1; // length of string 2

                if(str2.Contains(str1[i]) && count1 == count2){  // if each letter is in string 2 by the end AND both strings are the same length
                    anagram = true; // change default value
                }
            }
            
            return anagram;  // return bool
        }
    }
}
