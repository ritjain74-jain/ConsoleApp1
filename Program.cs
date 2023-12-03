
internal class Program
{
    private static void Main(string[] args)
    {
        string rawString = """here is what want to do, 'i am not sure thoug' but I can tell your one thing "that if you do something" it won't waste""";
        Console.WriteLine($$"""rawsting is: {{{rawString}}}""");
        Console.WriteLine("Hello, World!123");
        try
        {
            FullName(null, "last");
            dummy();
            // TODO: this method needs to be implemented
        }
        catch (Exception ex)
        {
<<<<<<< HEAD
            //Exception tewstsd
            Console.WriteLine($"in catch exception:{ex.Message}");
        }
        finally
        {
            //here u go
            Console.WriteLine("finally exception");
        }



    }

    private static void dummy()
    {
        string? abc = "asda";
        if (abc == null)
        {
            throw new Exception("wastage of time");
        }
        Console.WriteLine("after exception");
    }

    //c# 11.0 feature of null
    //public static void FullName(string firstName, string lastName)
    //{
    //    if (firstName is null)
    //    {
    //        throw new ArgumentNullException(nameof(firstName));
    //    }
    //    if (lastName is null)
    //    {
    //        throw new ArgumentNullException(nameof(lastName));
    //    }
    //    // Body of the method
    //}
    //public static void FullName(string firstName!!, string lastName!!)
    //{
    //    // Body of the method
    //}
}
