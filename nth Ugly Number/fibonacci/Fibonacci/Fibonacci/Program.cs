int a=Convert.ToInt32(Console.ReadLine());
int fib = nthfibonacci(a);
Console.WriteLine(fib);
/*int nthfibonacci(int a)
{
    if(a<=1)
    {
        return a;
    }
    else
    {
        return nthfibonacci(a - 1) + nthfibonacci(a - 2);
    }
}*/
int nthfibonacci(int a)
{
    int first = 0;
    int second = 1;
    int c = 0;
    for(int i=2;i<=a;i++)
    {
        c= first + second;
        first = second;
        second = c;
    }
    return c;

}