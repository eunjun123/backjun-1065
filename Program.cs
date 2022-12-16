using System;
int dv = 99;
int Input = int.Parse(Console.ReadLine());
if (Input < 100)
{
    Console.WriteLine(Input);
}
else
{
    for (int i = 100; i <= Input; i++)
    {
        if (i % 10 + i / 100 == 2 * ((i / 10) % 10))
        {
            dv++;
        }
    }
    Console.WriteLine(dv);
}
