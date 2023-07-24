
using System.Text.RegularExpressions;

public class Test {  

     public static  void MultiMatchCs() {    
          string input = "Hello 123 world 456";
          string pattern1 = @"\w+"; // Match one or more word characters
          string pattern2 = @"\d+"; // Match one or more digits
          Match match = Regex.Match(input, pattern1); // Find the first word
          while (match.Success){  
                    // Loop while there is a match 
                
                 Console.WriteLine(match.Value); // Print the word
                 match = Regex.Match(input, pattern2, RegexOptions.None); 
                 // Find the next number after the word
                if (match.Success){
                    // If there is a number 
                    Console.WriteLine(match.Value); // Print the number
                    match = Regex.Match(input, @"\G" + pattern1); // Find the next word after the number using \G
               }
          }

     }
}
