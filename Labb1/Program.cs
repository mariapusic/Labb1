string test = "29535123p48723487597645723645";
long sum = 0;



for (int yttreIndex = 0; yttreIndex < test.Length; yttreIndex++)
{
    var apa2 = test.Substring(0, yttreIndex);
    for (int inreIndex = yttreIndex + 1; inreIndex < test.Length; inreIndex++)
    {
        var apa3 = test.Substring(inreIndex + 1);
        if (char.IsDigit(test[inreIndex]))
        {
            if (test[yttreIndex] == test[inreIndex])
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(apa2);
                var apa = test.Substring(yttreIndex, inreIndex - yttreIndex + 1);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(apa);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(apa3);
                Console.WriteLine();
                sum = sum + Convert.ToInt64(apa);
                break;
            }
        }
        else
        {
            break;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Total sum: {sum}");

