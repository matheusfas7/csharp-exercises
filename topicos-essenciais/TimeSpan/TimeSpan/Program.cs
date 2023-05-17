using System;

/*
TimeSpan t1 = new TimeSpan(0, 1, 30);
Console.WriteLine(t1);

TimeSpan t2 = new TimeSpan(900000000L);
Console.WriteLine(t2);

TimeSpan t3 = new TimeSpan(2, 11, 21);
Console.WriteLine(t3);

TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
Console.WriteLine(t4);

TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
Console.WriteLine(t5);

TimeSpan t6 = TimeSpan.FromDays(1.5);
Console.WriteLine(t6);

TimeSpan t7 = TimeSpan.FromHours(1.5);
Console.WriteLine(t7);

TimeSpan t8 = TimeSpan.FromTicks(900000000L);
Console.WriteLine(t8);
*/

/*
TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
TimeSpan t1 = TimeSpan.MaxValue;
TimeSpan t2 = TimeSpan.MinValue;
TimeSpan t3 = TimeSpan.Zero;

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine();

Console.WriteLine(t);
Console.WriteLine("Days: " + t.Days);
Console.WriteLine("TotalDays: " + t.TotalDays);
*/

TimeSpan t1 = new TimeSpan(1, 30, 10);
TimeSpan t2 = new TimeSpan(0, 10, 5);
TimeSpan sum = t1.Add(t2);
TimeSpan dif = t1.Subtract(t2);
TimeSpan mult = t2.Multiply(2.0);
TimeSpan div = t2.Divide(2.0);

Console.WriteLine(sum);
Console.WriteLine(dif);
Console.WriteLine(mult);
Console.WriteLine(div);