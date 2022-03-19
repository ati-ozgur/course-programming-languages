
using ConsoleAppDataTypes;

float n1 = 1 / 3;
n1 = n1 * 3;
Console.WriteLine(n1);




string a = "1";
int a1 = 1;
int b = 1;

Int32 a3 = 2;


Console.WriteLine(a1.GetType());
Console.WriteLine(a3.GetType());


if (a1 == a3)
{
    Console.WriteLine("a equals to b");
}
else
{
    Console.WriteLine("a NOT equals to b");
}


PersonClass pClass1 = new PersonClass();
Console.WriteLine(pClass1.GetType());
pClass1.FirstName = "Atilla";
Console.WriteLine(pClass1);

PersonStruct pStruct1 = new PersonStruct();
Console.WriteLine(pStruct1.GetType());
pStruct1.FirstName = "Atilla";
Console.WriteLine(pStruct1);


// Not possible to assign dynamic property like javascript
//p1.LastName = "Özgür";

Object obj1 = a1; // boxing

Console.WriteLine(obj1);

int b3 = (int) obj1; // unboxing

Console.WriteLine(b3);