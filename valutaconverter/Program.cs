using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valutaconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double argAmount;
            string inputArg;
            string outputArg;
            if (args != null && args.Length == 3)
            {
                //Läser 3 argument från cmd och converterar första argumentet till double
                //Där efter kan man använda antingen USD, EUR SEK eller 1, 2, 3 för inCurrency/utCurrency
                //la även in an try/catch för att fixa en crash
                try
                {
                    argAmount = Convert.ToDouble(args[0]);
                    inputArg = args[1];
                    outputArg = args[2];
                }
                catch (Exception)
                {
                    Console.WriteLine("Wops! Something went wrong!");
                    throw;
                }

                //ange hur mycket pengar man vill växla

                double amount = argAmount;

                //input1 är den valuta man har
                string inputCurrency = inputArg;
                switch (inputCurrency)
                {
                    case "1":
                    case "USD":
                        inputCurrency = "USD";
                        break;
                    case "2":
                    case "EUR":
                        inputCurrency = "EUR";
                        break;
                    case "3":
                    case "SEK":
                        inputCurrency = "SEK";
                        break;
                    default:
                        break;
                }

                //input2 är den valuta man vill växla till
                string outputCurrency = outputArg;
                switch (outputCurrency)
                {
                    case "1":
                    case "USD":
                        outputCurrency = "USD";
                        break;
                    case "2":
                    case "EUR":
                        outputCurrency = "EUR";
                        break;
                    case "3":
                    case "SEK":
                        outputCurrency = "SEK";
                        break;
                    default:
                        break;
                }
                var SEK = new[] { 500, 100, 50, 20, 10, 1 };
                var EUR = new[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                var USD = new[] { 100, 50, 20, 10, 5, 2, 1 };
                var eurCent = new[] { 50, 20, 10, 5, 2, 1 };
                var usdCent = new[] { 50, 25, 10, 5, 1 };
                //här sker valuta uträkningen
                Console.Clear();
                if (inputCurrency == "USD" && outputCurrency == "SEK")
                {
                    var n = amount * 8.50;
                    Console.WriteLine("SEK: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    int outputAmount = (int)n;

                    foreach (var output in SEK)
                    {
                        var count = outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} Kr", count, output);
                    }
                }
                else if (inputCurrency == "USD" && outputCurrency == "EUR")
                {
                    var n = amount * 0.90;
                    Console.WriteLine("EUR: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;

                    foreach (var output in EUR)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} EUR", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in eurCent)
                            {
                                var count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else if (inputCurrency == "SEK" && outputCurrency == "EUR")
                {
                    var n = amount * 0.105372;
                    Console.WriteLine("EUR: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;

                    foreach (var output in EUR)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} EUR", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in eurCent)
                            {
                                int count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else if (inputCurrency == "SEK" && outputCurrency == "USD")
                {
                    var n = amount * 0.117643;
                    Console.WriteLine("USD: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;
                    foreach (var output in USD)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} $", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in usdCent)
                            {
                                int count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else if (inputCurrency == "EUR" && outputCurrency == "SEK")
                {
                    var n = amount * 9.49;
                    Console.WriteLine("SEK: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    int outputAmount = (int)n;
                    foreach (var output in SEK)
                    {
                        var count = outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} Kr", count, output);
                    }
                }
                else if (inputCurrency == "EUR" && outputCurrency == "USD")
                {
                    var n = amount * 1.11111;
                    Console.WriteLine("USD: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;
                    foreach (var output in USD)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} $", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in usdCent)
                            {
                                int count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else
                    Console.WriteLine("Invalid currency");
                Console.ReadKey();
            }
            else
            {
                //ange hur mycket pengar man vill växla
                Console.Write("Enter amount: ");
                double amount;
                amount = double.Parse(Console.ReadLine());

                //input1 är den valuta man har
                Console.Clear();
                Console.WriteLine("Chose currency");
                Console.WriteLine("1 = USD");
                Console.WriteLine("2 = EUR");
                Console.WriteLine("3 = SEK");
                string inputCurrency = Console.ReadLine();
                switch (inputCurrency)
                {
                    case "1":
                    case "USD":
                        inputCurrency = "USD";
                        break;
                    case "2":
                    case "EUR":
                        inputCurrency = "EUR";
                        break;
                    case "3":
                    case "SEK":
                        inputCurrency = "SEK";
                        break;
                    default:
                        break;
                }

                //input2 är den valuta man vill växla till
                Console.Clear();
                Console.WriteLine("What currency do you want to exchange to?");
                Console.WriteLine("1 = USD");
                Console.WriteLine("2 = EUR");
                Console.WriteLine("3 = SEK");
                string outputCurrency = Console.ReadLine();
                switch (outputCurrency)
                {
                    case "1":
                    case "USD":
                        outputCurrency = "USD";
                        break;
                    case "2":
                    case "EUR":
                        outputCurrency = "EUR";
                        break;
                    case "3":
                    case "SEK":
                        outputCurrency = "SEK";
                        break;
                    default:
                        break;
                }
                var SEK = new[] { 500, 100, 50, 20, 10, 1 };
                var EUR = new[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                var USD = new[] { 100, 50, 20, 10, 5, 2, 1 };
                var eurCent = new[] { 50, 20, 10, 5, 2, 1 };
                var usdCent = new[] { 50, 25, 10, 5, 1 };
                //här sker valuta uträkningen
                Console.Clear();
                if (inputCurrency == "USD" && outputCurrency == "SEK")
                {
                    var n = amount * 8.50;
                    Console.WriteLine("SEK: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    int outputAmount = (int)n;

                    foreach (var output in SEK)
                    {
                        var count = outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} Kr", count, output);
                    }
                }
                else if (inputCurrency == "USD" && outputCurrency == "EUR")
                {
                    var n = amount * 0.90;
                    Console.WriteLine("EUR: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;

                    foreach (var output in EUR)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} EUR", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in eurCent)
                            {
                                var count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else if (inputCurrency == "SEK" && outputCurrency == "EUR")
                {
                    var n = amount * 0.105372;
                    Console.WriteLine("EUR: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;

                    foreach (var output in EUR)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} EUR", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in eurCent)
                            {
                                int count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else if (inputCurrency == "SEK" && outputCurrency == "USD")
                {
                    var n = amount * 0.117643;
                    Console.WriteLine("USD: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;
                    foreach (var output in USD)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} $", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in usdCent)
                            {
                                int count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else if (inputCurrency == "EUR" && outputCurrency == "SEK")
                {
                    var n = amount * 9.49;
                    Console.WriteLine("SEK: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    int outputAmount = (int)n;
                    foreach (var output in SEK)
                    {
                        var count = outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} Kr", count, output);
                    }
                }
                else if (inputCurrency == "EUR" && outputCurrency == "USD")
                {
                    var n = amount * 1.11111;
                    Console.WriteLine("USD: {0}", Math.Round(n, 2));
                    //här sker växel uträkningen
                    var outputAmount = n;
                    foreach (var output in USD)
                    {
                        var count = (int)outputAmount / output;
                        outputAmount = outputAmount % output;
                        Console.WriteLine("{0} {1} $", count, output);
                        if (outputAmount < 1.00)
                        {
                            //flyttar decimal 2 steg för att kolla efter cent
                            double cent = outputAmount * 100;
                            foreach (var output2 in usdCent)
                            {
                                int count2 = (int)Math.Ceiling(cent) / output2;
                                cent = cent % output2;
                                Console.WriteLine("{0} {1} Cent", count2, output2);
                            }
                            break;
                        }
                    }
                }
                else
                    Console.WriteLine("Invalid currency");
                Console.ReadKey();
            }
        }                
    }
}
