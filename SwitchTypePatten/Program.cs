//Type patten
int age = 20;
string name = "Thilina madushan";
List<string> citys = new List<string> {"Colombo","Galle","Matara" };
int[] numbers = new int[] {10, 20, 301, 45 };
double marks = 52.2;

object CheckType(object val) => val switch
{
    int => "Integer type",
    string => "String type",
    List<string> => "List type",
    Array => "Array type",
    _ => "Unknown type",
};

Console.WriteLine(CheckType(age));
Console.WriteLine(CheckType(name));
Console.WriteLine(CheckType(citys));
Console.WriteLine(CheckType(numbers));
Console.WriteLine(CheckType(marks));



