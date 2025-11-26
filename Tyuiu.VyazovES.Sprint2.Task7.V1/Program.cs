using Tyuiu.VyazovES.Sprint2.Task7.V1.Lib;

DataService ds = new DataService();

double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
bool z = ds.CheckDotInShadedArea(x, y);

if (z)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находится в заштрихованной области");

}

Console.ReadKey();