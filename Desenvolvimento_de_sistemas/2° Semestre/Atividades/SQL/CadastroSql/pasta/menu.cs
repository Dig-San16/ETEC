class Program
{
    static void Main()
    {
        try
        {
            Site app = new Site();
            app.lobby();
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro fatal: " + e.Message);
        }
    }
}