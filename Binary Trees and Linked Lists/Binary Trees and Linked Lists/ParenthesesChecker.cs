using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees_and_Linked_Lists
{
    public class ParenthesesChecker
    {
        public void CheckForParentheses(string input)
        {
            //number of characters in a string
            int n = input.Length;
            //Create stack
            Stack<string> myStack = new Stack<string>();
            //Look over input for Parenthesis
            for(int i = 0; i < n; i++)
            {
                if (input[i] == "(" || input[i].ToString() == "{" || input[i].ToString() == "[")
                {
                    myStack.Push(input[i].ToString());
                }
                else if (input[i] == ')' || input[i] == '}' || input[i] == ']')
                {                  
                    string combineParenthesis = myStack.Peek().ToString() + input[i].ToString();                    
                    if(myStack.Peek() == "" || combineParenthesis != "()" && combineParenthesis != "{}" && combineParenthesis != "[]") 
                    {
                        //careful with this.. I want to exit the code block and move to next
                        return;
                    }
                    else
                    {
                        //this is the extra character
                        string ret = myStack.Pop();                                    
                    }                    

                }
                
            }
           


        }
    }
}
