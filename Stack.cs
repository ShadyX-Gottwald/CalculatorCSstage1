
using System.Globalization;
interface StackFunctions<T>  {
     void Pop();
     void Push(T c);
     bool IsEmpty();
     T Peek();  
     Int32 Sum();

}
//ArrayList backed stack    
public class StackCustom<T>  : StackFunctions<T> {

     private int default_size = -1;

     public  List<T> bracketArray { get; set; }

     public int GetCount => bracketArray.Count();

     public StackCustom() {
          this.bracketArray = new List<T>();
     }


     public void Pop() {
          if (bracketArray.Count() == 0) {Console.WriteLine("Empty Stack");}
          
          var listSize = bracketArray.Count();  
          var last = bracketArray[listSize-1];
          bracketArray.RemoveAt(listSize-1);
         // Console.WriteLine("'Last Removed' : Removed");    
          // last;

     }

     public void Push(T c) {
          bracketArray.Add(c);
     }

     public bool IsEmpty() {
          if (bracketArray.Count() == 0) { Console.WriteLine("Empty Stack"); return true; }
          else return false;
     }

     public T Peek() {   
          //if(bracketArray.Count() == 0) return ;
          var listSize = bracketArray.Count();
          return bracketArray[listSize-1];
     }

    public  Int32 Sum() {   
          if(bracketArray.Count() == 0) {return 0;}    

          var sum = 0;     
           

          foreach(var number in bracketArray) { 
               sum = sum + (number.ToString().ToInteger() );
          }   
          return ((Int32) sum);
     }
}
