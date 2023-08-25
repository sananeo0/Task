namespace Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date (dd | MM | yyyy): ");
            string input = Console.ReadLine();
            try
            {
                DateTime time = DateTime.ParseExact(input, "dd | MM | yyyy", null);
                Console.WriteLine("Date: "+time.ToString("dd | MM | yyyy"));

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
         
        }
    }
}