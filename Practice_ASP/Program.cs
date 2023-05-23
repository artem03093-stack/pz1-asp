namespace Practice_ASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(wBuilder =>
                    {
                        wBuilder.UseStartup<Startup>();
                    })
                .Build()
                .Run();
        }
    }
}