
int a, b, c, d;
a= Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

int FindMinimum(int a, int b, int c, int d)
{
    
   if(a<b && a<c && a<d) {
        return a;

    }
     else if (a > b && b < c && b < c)
    {
        return b;

    }
     else if (a > c && b > c && d > c)
    {
        return c;

    }
    else if (a > d && d < b && d < c)
    {
        return d;

    }

}


