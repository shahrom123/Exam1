
class Calculator
{
    public long Factorial(long n)
    {
        fact =1; 
        for(long i = 1; i<=n; i++)
        {
            fact*=i;
        }
        return fact;
    }
    public double Multiple(double a, double b)
    {
        return a*b;

    }
    public double Division(int a, int b)
    {
        return a/b;

    }


}