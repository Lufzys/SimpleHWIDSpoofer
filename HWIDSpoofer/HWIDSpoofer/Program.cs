using System;

namespace HWIDSpoofer
{
    class Program
    {
        public static string textLogo = @"   ____  ____  ____      ____  _____  ______      ______   _______     ___      ___   ________  ________  _______    " + Environment.NewLine +
            @"  |_   ||   _||_  _|    |_  _||_   _||_   _ `.  .' ____ \ |_   __ \  .'   `.  .'   `.|_   __  ||_   __  ||_   __ \   " + Environment.NewLine +
            @"    | |__| |    \ \  /\  / /    | |    | | `. \ | (___ \_|  | |__) |/  .-.  \/  .-.  \ | |_ \_|  | |_ \_|  | |__) |  " + Environment.NewLine +
            @"    |  __  |     \ \/  \/ /     | |    | |  | |  _.____`.   |  ___/ | |   | || |   | | |  _|     |  _| _   |  __ /   " + Environment.NewLine +
            @"   _| |  | |_     \  /\  /     _| |_  _| |_.' / | \____) | _| |_    \  `-'  /\  `-'  /_| |_     _| |__/ | _| |  \ \_ " + Environment.NewLine +
            @"  |____||____|     \/  \/     |_____||______.'   \______.'|_____|    `.___.'  `.___.'|_____|   |________||____| |___|" + Environment.NewLine; // for create ascii text signature https://www.kammerl.de/ascii/AsciiSignature.php

        static void Main(string[] args) // https://github.com/Lufzys/SimpleHWIDSpoofer
        {
        begin:
            Console.Title = "[LF1337] Simple Hwid Spoofer - github.com/Lufzys/SimpleHWIDSpoofer";
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine(textLogo);
            Console.WriteLine("  ┌ FUNCS ──────────────────────────────────┐");
            Console.WriteLine("  │ [!hwid] Spoof HWID                      │");
            Console.WriteLine("  │ [!guid] Spoof Guid                      │");
            Console.WriteLine("  │ [!pcName] Spoof your Computer Name      │");
            Console.WriteLine("  │ [!productId] Spoof ProductId            │");
            Console.WriteLine("  └─────────────────────────────────────────┘");

            string input = Console.ReadLine();
            if(input == "!hwid")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.HWID.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "!guid")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.PCGuid.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "!pcName")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.PCName.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "!productId")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.ProductId.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else
            {
                goto begin;
            }
        }
    }
}
