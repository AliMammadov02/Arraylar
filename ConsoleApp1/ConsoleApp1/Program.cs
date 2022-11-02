int n, i=0;
string a;
a = Console.ReadLine();
n=Convert.ToInt32(a);
while(n>=1)
{
    n /=10;
    i++;
}
    Console.WriteLine(i);