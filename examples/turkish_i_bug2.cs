using System;
using System.Globalization;
using System.Threading;

Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");

const string input = "atilla";
bool comparison = input.ToUpper() == "ATİLLA";
Console.WriteLine("These things are equal: " + comparison);
Console.ReadLine();
