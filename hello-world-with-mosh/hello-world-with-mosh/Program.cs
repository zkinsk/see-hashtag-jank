namespace hello_world_with_mosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            var str = "1234";
            byte i = Convert.ToByte(str);

            Console.WriteLine(i);

            }
            catch (Exception error)
            {
                Console.WriteLine ($"error :: {error}");
            }
        }
    }
}