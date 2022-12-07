// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

string s = Console.ReadLine();
bool isValid = IsValid(s);
Console.WriteLine(isValid);
bool IsValid(string s)
{
    bool isValid = false;
    //If 's' is null or it's length is odd number, we should return false
    if ( s == null || (s.Length%2!=0))
    {
        return isValid;
    }
    Stack<char> parentheses = new Stack<char>();
    for (int i = 0; i < s.Length; i++)
    {
        
        if (s[i] == '('|| s[i] == '{'|| s[i] == '[')
        {
            parentheses.Push(s[i]);
        }
    
        else if (s[i] ==')'|| s[i] == '}'|| (s[i] == ']'))
        {
            char followingParentheses= parentheses.Pop();
            char currParentheses = s[i];
            if (parentheses.Count==0)
            {
                return false;
            }
            if (currParentheses==')'&&followingParentheses=='(')
            {
                isValid = true;
            }
            else if(currParentheses == '}' && followingParentheses == '{')
            {
                isValid = true;

            }
            else if (currParentheses == ']' && followingParentheses == '[')
            {
                isValid = true;

            }
            else
            {
                return isValid = false;
            }
        }
       

    }
    if (parentheses.Count==0)
    {
        return isValid;
    }
    else
    {
        return false;
    }


}