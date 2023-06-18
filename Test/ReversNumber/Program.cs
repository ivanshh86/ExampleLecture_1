void Palindrom()
{
    int number = new Random().Next(1, 1000000);
    Console.WriteLine("Your number " + number);


    int Digit()
    {
        int digit = 0;
        int num = number;
        while (num != 0)
        {
            num /= 10;
            digit++;
        }
        return digit;
    }

    int digit1 = 1;
    int digit2 = Digit;
    while (Digit1 <= Digit / 2)
    {
        int num1 = number % 10;
        int num2 = number / 10000;
        int num3 = number / 10 % 10;
        int num4 = number / 1000 % 10;

        if (num1 == num2 && num3 == num4) Console.WriteLine($"Number {number} is palindrom");
        else Console.WriteLine($"Number {number} is not palindrom");
    }
    else Console.WriteLine("Entering number not five-digit!");
}
Palindrom();
