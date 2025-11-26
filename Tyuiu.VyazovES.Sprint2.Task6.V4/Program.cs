using Tyuiu.VyazovES.Sprint2.Task6.V4.Lib;

DataService ds = new DataService();

int x = Convert.ToInt32(Console.ReadLine());
string z = ds.FindCardSuit(x);
Console.WriteLine(z);
Console.ReadKey();