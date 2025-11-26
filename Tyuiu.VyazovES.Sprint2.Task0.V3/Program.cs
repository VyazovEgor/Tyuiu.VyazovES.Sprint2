using Tyuiu.VyazovES.Sprint2.Task0.V3.Lib;

DataService ds = new DataService();
bool[] res = new bool[6];
res = ds.GetCompareOperations(45, 127);

for (int i = 0; i < 6; i++) { 
Console.WriteLine(res[i]);
}

Console.ReadKey();