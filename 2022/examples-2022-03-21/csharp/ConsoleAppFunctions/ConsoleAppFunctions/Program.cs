// See https://aka.ms/new-console-template for more information


using ConsoleAppFunctions;


Helper.Hello();


Helper.Hello("Atilla");


Helper.Hello("Atilla", "Germany");

Helper.Hello("Duru", "Turkiye");


string[] names2 = new string[] { "Atilla", "Duru", "Funda" };
string[] names3 = { "Atilla", "Duru", "Funda", "Deneme" };

Helper.Hello2(new string[] { "Atilla", "Duru" });
Helper.Hello2(new string[] { "Atilla", "Duru" });
Helper.Hello2(names2);
Helper.Hello2(names3);


Helper.Hello3(names2);
Helper.Hello3(new string[] { "Atilla", "Duru" });
Helper.Hello3("Atilla", "Duru", "Funda");
// ---> changed to something like below by the compiler
Helper.Hello3(new string[] { "Atilla", "Duru", "Funda" });

Console.WriteLine("Hello, World!");


Helper.HelloPrintCountriesVisited("Atilla", "Turkiye", "Bulgarian", "Germany", "Sweden");

Helper.HelloPrintCountriesVisited("Funda", "Turkiye", "Germany");


var m = Helper.HelloCountriesVisited("Atilla", "Turkiye", "Bulgarian", "Germany", "Sweden");

Console.WriteLine(m);