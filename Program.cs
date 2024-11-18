

namespace Delegates401;

class Program
{
    private class ExampleClass { }
    static void Main(string[] args)
    {
        // Declare a list of type int
        GenericList<int> list = new();
        list.Add(1);

        // Declare a list of type string
        GenericList<string> list2 = new();
        list2.Add("a");

        // Decalre a list of type ExampleClass
        GenericList<ExampleClass> list3 = new();
        list3.Add(new ExampleClass());

        // Func Example
        Func<int, int, int> calc = MathClass.Sum;
    }
}
