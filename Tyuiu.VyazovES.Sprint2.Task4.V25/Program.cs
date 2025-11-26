using Tyuiu.VyazovES.Sprint2.Task4.V25.Lib;

DataService ds = new DataService();

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
double z= ds.Calculate(x, y);
Console.WriteLine(y);
Console.ReadKey();