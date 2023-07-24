using System.Text.RegularExpressions;

public static class Validations{ 
     
     private static string PATTERN = @"\d{1,5}";    
     public static StackCustom<int> Stack = new StackCustom<int>();
     public static void ValidateUserInput(string input) {  
          //Add to stack ,matching digits.     
          var rgx = Regex.Matches(input:input ,pattern: PATTERN);     

           var summedValue = rgx.SumValues(); 
           Console.WriteLine(summedValue);

     }
}
