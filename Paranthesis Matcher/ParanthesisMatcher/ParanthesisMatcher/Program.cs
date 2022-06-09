string a = Console.ReadLine();
Stack<char> stack = new Stack<char>();
bool check = true;
foreach(char b in a)
{
    if(b=='{')
    {
        stack.Push(b);  
    }
    else if(b=='}')
    {
        if (stack.Count > 0)
        {
            stack.Pop();
        }
        else
        {
            check = false;
            break;
        }
    }
}
if(stack.Count>0||check==false)
{
    Console.WriteLine("Invalid");
}
else
{
    Console.WriteLine("Valid");
}
