int a=Convert.ToInt32(Console.ReadLine());
int nth_ugly = nthUglyno(a);
Console.WriteLine(nth_ugly);
int MaxDivide(int a,int b)
{
    while(a%b==0)
    {
        a = a / b;
    }
    return a;
}
bool IsUgly(int a)
{
    a = MaxDivide(a, 2);
    a = MaxDivide(a, 3);
    a = MaxDivide(a, 5);
    return a== 1;
}
int nthUglyno(int a)
{
    int number = 0;
    int uglyCount = 0;
    while(uglyCount<a)
    {
        number++;
        bool check=IsUgly(number);
        if(check==true)
        {
            uglyCount++;
        }
    }
    return number;
}