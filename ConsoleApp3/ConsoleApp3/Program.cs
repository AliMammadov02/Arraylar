int n, m,evvelki_m;
string a, b;
a = Console.ReadLine();
b = Console.ReadLine();
m=Convert.ToInt32(a);
n=Convert.ToInt32(b);
evvelki_m = m;
while (n-1 > 0)
{
    m *= evvelki_m; 
    n--;

}

if (n == 0)
{
    m = 1;
    Console.WriteLine(m);
}

else
{
    Console.WriteLine(m);
}

