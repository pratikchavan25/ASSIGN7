// See https://aka.ms/new-console-template for more information
// 7. Write a  program to enter P, T, R and calculate Compound Interes ?

double ci, p, r, amount;
int n, t;

Console.WriteLine("enter the principal balance");
p = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter the interest rate ");
r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter the compound frequency");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the year ");
t = Convert.ToInt32(Console.ReadLine());

amount = p * Math.Pow((1 + r / (100 * n)), n * t);

ci = amount - p;

Console.WriteLine("ci = " + Math.Round(ci, 2));

Console.ReadLine();