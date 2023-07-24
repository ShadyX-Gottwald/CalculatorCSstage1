
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Collections;

public class StringEvaluator{    
     public string InputString {get;set;}   
     private StackCustom<char> Stack {get;set;}      
     private char[] BrokenDownString {get;set;}   

     private delegate bool IsBracket(char character);    

     public int CharArrayCount => BrokenDownString.Count();

     public StringEvaluator(string input) { 
          this.InputString = input;   
          this.Stack = new StackCustom<char>();    
          BrokenDownString = this.InputString.ToCharArray() ;
     }   

     public void Print() { 
          //Print Each Character
         // BrokenDownString.Foreach();   
         BrokenDownString.ForEach(character => CharIsBracketOpening(character));
         // BrokenDownString.ForEach(character => CharHasClosingBracket(character));   
         LookForMatch();

     }     

     

     private bool CharIsBracketOpening(char character) {    
          if(character == '(') {  
               Stack.Push(character);
               return true;
          }
          else return false;

     }
     private bool CharHasClosingBracket(char character) {
          if (character == ')') {
               Stack.Pop();
               return true;
          }
          else return false;
          
     }
     public void LookForBracketClosing() {    
          IsBracket br = CharIsBracketOpening; 
          Stack.bracketArray.ForEach(tr => CharHasClosingBracket(tr)); 
          //Check if stack is empty   
          if(Stack.IsEmpty()) Console.WriteLine("Balanced Brackets");
          else if (Stack.GetCount > 1) {Console.WriteLine("Bracket Not Balanced");}
         // br.Invoke('(');
     }
     public  void LookForMatch( ) {
          for (var i = 0; i < BrokenDownString.Count(); i++) { 
               if(BrokenDownString[i] == ')') {  
                  //var last = Stack.Pop();   
                  if(Stack.IsEmpty()) { 
                    Console.WriteLine("Balanced Stack"); 
                    break;
                  } 
               }    
               else if(i == BrokenDownString.Count()-1 && BrokenDownString[i] != ')') {
                    Console.WriteLine("Stack is Not Empty! Unbalanced");

               }

          }    
          Console.WriteLine("Done Checking! :) "); 

     }

}


class MyList<T> : IList<T> {
     public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

     public int Count => throw new NotImplementedException();

     public bool IsReadOnly => throw new NotImplementedException();

     public void Add(T item) {
          throw new NotImplementedException();
     }

     public void Clear() {
          throw new NotImplementedException();
     }

     public bool Contains(T item) {
          throw new NotImplementedException();
     }

     public void CopyTo(T[] array, int arrayIndex) {
          throw new NotImplementedException();
     }

     public IEnumerator<T> GetEnumerator() {
          throw new NotImplementedException();
     }

     public int IndexOf(T item) {
          throw new NotImplementedException();
     }

     public void Insert(int index, T item) {
          throw new NotImplementedException();
     }

     public bool Remove(T item) {
          throw new NotImplementedException();
     }

     public void RemoveAt(int index) {
          throw new NotImplementedException();
     }

     IEnumerator IEnumerable.GetEnumerator() {
          throw new NotImplementedException();
     }
}
     