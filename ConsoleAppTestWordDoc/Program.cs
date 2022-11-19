// See https://aka.ms/new-console-template for more information
using ConsoleAppTestWordDoc;

Console.WriteLine("Hello, World!");

var c = new Class1();
Type _type = c.GetTypeEnum();
var test0 = c.GetEnum();
Console.WriteLine(test0);
//
c.SetEnum(Elems.server);
if(c.GetEnum() is Elems)
{
    Elems test1 = (Elems)c.GetEnum();
    Console.WriteLine(test1);
}
//
c.SetEnum(TestEnum.ADMIN2);
var test2 = c.GetEnum();
Console.WriteLine(test2);
;
