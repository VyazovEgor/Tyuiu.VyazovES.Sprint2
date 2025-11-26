using Tyuiu.VyazovES.Sprint2.Task5.V8.Lib;

DataService ds = new DataService();

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
string z = ds.FindDateOfPreviousDay(x, y);
Console.WriteLine(z);
Console.ReadKey();