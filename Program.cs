
namespace HtmlEditor
{
    internal class Program
    {

        public static void DrawScreen()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
        }
        private static void Main(string[] args)
        {
            Menu.Show();
        }
    }

}
