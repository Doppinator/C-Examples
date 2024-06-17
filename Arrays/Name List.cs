// See https://aka.ms/new-console-template for more information
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>()
            {

            };

            Console.WriteLine("Enter a name (Leave blank to complete)");
            string displayName = Console.ReadLine();
            while (displayName != string.Empty)
            {
                
                displayName = Console.ReadLine();
                names.Add(displayName);
                Console.WriteLine(names.Count);

            };






        }
    }
}
