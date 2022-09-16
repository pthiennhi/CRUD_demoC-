namespace ProductManager;

public class Input
{
    public static string EnterString(string label)
    {
        do
        {
            Console.Write(label);
            String line = Console.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                return line;
            }
        } while (true);
    }

    public static int EnterInt(string label)
    {
        do
        {
            try
            {
                Console.Write(label);
                int number = int.Parse(Console.ReadLine());
                return number;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        } while (true);
    }

    public static double EnterDouble(string label)
    {
        do
        {
            try
            {
                Console.Write(label);
                double number = double.Parse(Console.ReadLine());
                return number;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        } while (true);
    }

    public static DateTime EnterDate(string label, string format)
    {
        do
        {
            try
            {
                Console.Write(label);
                string line = Console.ReadLine();
                DateTime dateTime = DateTime.ParseExact(line, format, null);
                return dateTime;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        } while (true);
    }
}