namespace UseWordConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("starting word prog");
            UseWord wordObj = new UseWord();
            wordObj.InvokeWord();
            wordObj.Dispose();
            System.Console.ReadLine();
        }
    }
}
