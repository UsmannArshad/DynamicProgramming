int a=Convert.ToInt32(Console.ReadLine());
int fib = nthfibonacci(a);
Console.WriteLine(fib);
int nthfibonacci(int a)
{
    if(a<=1)
    {
        return a;
    }
    else
    {
        return nthfibonacci(a - 1) + nthfibonacci(a - 2);
    }
}