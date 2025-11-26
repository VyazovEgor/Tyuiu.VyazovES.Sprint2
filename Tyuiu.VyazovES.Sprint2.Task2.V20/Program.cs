using Tyuiu.VyazovES.Sprint2.Task2.V20.Lib;


int x = Convert.ToInt32(Console.ReadLine());


int y = Convert.ToInt32(Console.ReadLine());




DataService ds = new DataService();
bool res;
res = ds.CheckDotInShadedArea(x, y);

if (res)
    Console.WriteLine("Точка находится в заштрихованной области.");
else
    Console.WriteLine("Точка не находится в заштрихованной области.");

Console.ReadKey();