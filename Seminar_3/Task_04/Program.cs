int quarter = new Random().Next(1, 4);

Console.WriteLine(quarter);
if (quarter == 1) Console.WriteLine(" X > 0 : Y > 0");
if (quarter == 2) Console.WriteLine(" X < 0 : Y > 0");
if (quarter == 3) Console.WriteLine(" X < 0 : Y < 0");
if (quarter == 4) Console.WriteLine(" X < 0 : Y < 0");