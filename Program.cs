using System;
using System.Text.RegularExpressions;

namespace practice_C_sharp
{
    class Program
    {
        static void Main(string[] args) // main functin to call isAnagram()
        {

            if(isAnagram()){ // function takes two params and returns true or false
                Console.WriteLine("These words are anagrams!");  // if true TRUE
            }
            else{
                Console.WriteLine("These words are NOT anagrams"); // if false FALSE
            }
            
            // C# coding challenege
            // Hermione has come up with a precise formula for determining whether or not a phrase was ssspoken by a parssseltongue (a reference from the Harry Potter universe; the language of ssserpents and those who can converse with them).
            // Each word in a sssentence must contain either:
                // At least 2 instances of the letter "s" (i.e. must be together ss), or...
                // Zero instances of the letter "s".
            if(isParselTounge()){
                Console.WriteLine("The speaker consssults with sssserpants");
            }   
            else{
                Console.WriteLine("No parseltounge here");
            } 
        }

        public static bool isAnagram(){ // function takes two strings and returns true or false

            Console.WriteLine("Welcome to the anagram test!"); // announce the program

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

        public static bool isParselTounge(){ // are there multiple successive s's

            Console.WriteLine("Enter a string to determine if it is spoken in parseltounge"); //promt

            string userInput = Console.ReadLine().ToLower(); // save user input

            Regex rgx = new Regex(@"s{2,100}"); // define regex

            bool isPT = false; // default bool value flag

            for(var i=0; i<userInput.Split(" ").Length; i++){ // iterate through userInput string
                if(rgx.IsMatch(userInput.Split(" ")[i])){ //check for at least two s's in a row
                    isPT = true; //update flag
                }
            }

            return isPT; // return flag
        }
    }
}
