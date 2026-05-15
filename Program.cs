class Program
{
    static void Main()
    {

while (true)
{
        try
        {
            Console.WriteLine("Witaj w aplikacji KALKULATOR!");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            var number1 = getInput();

            Console.WriteLine("Jaką operacje chcesz wykonać? możliwe operacje to: +, -, *, /,.");
            var operation = Console.ReadLine();

            Console.WriteLine("Podaj prosze 2 liczbę: ");
            var number2 = getInput();

            var result = Calculate(number1, number2, operation);
            Console.WriteLine($"wynik Twojego działania to: {result} \n");
        }
            catch (Exception ex)
            {
                //logowanie pliku
                Console.WriteLine(ex.Message);
            }
        }
    }
    
        private static double Calculate(int number1, int number2, string operation)
    {
        double result = 0;
        switch (operation)
        {
            case "+":
                result = number1 + number2;
                break;
            case "-":
                result = number1 - number2;
                break;
            case "*":
                result = number1 * number2;
                break;
            case "/":
                result = number1 / number2;
                break;
            default:
                throw new Exception("Wybrałęś złą operację!\n");
        }
        return result;
    }

    private static int getInput()
    {
        return int.Parse(Console.ReadLine());
    }
    private static int GetInput()
    {
        if (!int.TryParse(Console.ReadLine(), out int input))
            throw new Exception("Podana wartość nie jest liczbą\n");

        return input;
    }
}

