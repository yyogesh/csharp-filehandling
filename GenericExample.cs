class Test<T>
{
    T value;

    public Test(T v)
    {
        this.value = v;
    }

    public void WriteTest()
    {
        Console.WriteLine(this.value);
    }
}


class Program
{
    public static void Main()
    {
        Test<string> obj = new Test<string>("ABC");

        Test<int> obj1 = new Test<int>(123);
    }
}


// C# 

// Database

// ADO.NET or Entity Framework

// ASP.NET CORE (Website, mobile) ==> JavaScript, html, css, MVC