using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum,i,a,b;
        string n, m;
        n = Console.ReadLine();
        m = Console.ReadLine();
        sum = 0;
        a = Convert.ToInt32(n);
        b = Convert.ToInt32(m);
       
        for (i = a; i <= b; i++)
        {
            sum += i;
            
        }
        Console.WriteLine(sum);
    }
    
}