using static ArrayCreator;
using static ArrayMath;
using System.Diagnostics;

int[] array = 1_000_000.Create() // создает массив из 10 элементов
                .Fill(1,10);
// array.ConvertToStringAndPrintToTerminal();
// Console.WriteLine(array.ConvertToStringAndPrintToTerminal());

int m = 100_000;
Stopwatch sw = new Stopwatch();
sw.Start();
int max  = array.BadGetSum(m);
sw.Stop();
Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max  = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");
