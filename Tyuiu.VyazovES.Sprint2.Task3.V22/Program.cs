using Tyuiu.VyazovES.Sprint2.Task3.V22.Lib;

DataService ds = new DataService();
int x = Convert.ToInt32(Console.ReadLine());
double y = ds.Calculate(x);
Console.WriteLine(y);
Console.ReadKey();