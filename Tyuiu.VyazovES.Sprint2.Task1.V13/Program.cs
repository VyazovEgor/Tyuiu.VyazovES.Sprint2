using Tyuiu.VyazovES.Sprint2.Task1.V13.Lib;

DataService ds = new DataService();
bool[] res = new bool[6];
res = ds.GetLogicOperations(145, 916, 164, 137);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();