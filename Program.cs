

using System.Threading;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.IO.Compression;
using System.Threading.Tasks.Dataflow;
using System.Globalization;
using System.Text.RegularExpressions;   


/* 
* Stage 1: Match digit + space plus digit , StAGE 1 fROM JETBRAINS ACADEMY, BUT IN C#.     
*Evaluate that string
* PRINT  sum of those two digits .  

**/

public class Program  {      
  private  const string PATTERN = @"\d{1,5}\s\d{1,5}";
  private const string EXIT = "exit";   
  private static  bool RUNNING = true;  
  private static Regex regex = new Regex(PATTERN);     
  

     public static void Main(string[] args) { 

           
        //Test.MultiMatchCs();
       // string testString = "(Hello)";   
       // var rg = testString.ToRegex();   
       // Console.WriteLine(rg.IsMatch(testString));

      //      var br = new StringEvaluator(testString);     
      //      br.Print();

          while(RUNNING) EvaluateInput(Console.ReadLine());


     }
     private static void EvaluateInput(string? input) {        
          if(regex.IsMatch(input)) Validations.ValidateUserInput(input);
          else if (EXIT.ToRegex().IsMatch(input)){ 
               RUNNING = false;
          }   

     }
 }


public static class Extensions {
     public static void Foreach(this IEnumerable<char> source) {

          foreach (var item in source) { Console.WriteLine(item); }
     }        

     public static void ForEach(this IEnumerable<char> source,Action<char> action) {
          foreach (var item in source) { action(item); }
     }    

     public static Regex ToRegex(this string input) {
          string escaped = Regex.Escape(input);
          // Create and return a new Regex object with the escaped string as the pattern
          return new Regex(escaped);
          
     }   

     public static Int32 ToInteger(this string value) { 
          return Int32.Parse(value);
     }   

     public static int SumValues(this MatchCollection matches) { 
          var sum = 0;      

          foreach(var num in matches) { 
               sum = sum + Int32.Parse(num.ToString());     
               //Console.WriteLine("--"+ num.ToString());
          }   
          return sum;
          
     }

}

class BracketMatchingStack {
  // A helper method that returns true if c1 and c2 are a matching pair of brackets
  static bool IsMatch(char c1, char c2) {
    return (c1 == '(' && c2 == ')') || (c1 == '[' && c2 == ']') || (c1 == '{' && c2 == '}');
  }

  // A method that returns true if the input string of brackets is balanced
  static bool IsBalanced(string input) {
    // Create an empty stack of char
    Stack<char> stack = new Stack<char>();

    // Loop through each character in the input string
    foreach (char c in input) {

      // If the character is an opening bracket, push it onto the stack
      if (c == '(' || c == '[' || c == '{'){ stack.Push(c);}
      // If the character is a closing bracket
      else if (c == ')' || c == ']' || c == '}') {
        // If the stack is empty, return false
        if (stack.Count == 0) {
          return false;
        }
        // Pop the top element from the stack and compare it with the character
        char top = stack.Pop();
        // If they are not a matching pair of brackets, return false
        if (!IsMatch(top, c)){
          return false;
        }
      }
    }

    // After the loop, check if the stack is empty. If it is, return true. Otherwise, return false.
    return stack.Count == 0;
  }

  // A test method that prints some examples
 //public static void Main(string[] args) {
   // Console.WriteLine(IsBalanced("([{}])")); // true
    //Console.WriteLine(IsBalanced("([)]")); // false
   // Console.WriteLine(IsBalanced("([]{})")); // true
    //Console.WriteLine(IsBalanced("([)")); // false
//  }
}
