using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitMenu = false;

            while (exitMenu == false)
            {
                Console.WriteLine("Choose one of the following options:\n 1. MANUAL - you will choose your creature parts!\n 2. RANDOM - a random creature will be created for you!\n 3. EXIT");
                string option = Console.ReadLine().ToUpper();

                switch (option)
                {
                    case "MANUAL":
                        Console.WriteLine("Each part can be \"GHOST\", \"BUG\" or \"MONSTER\" if you choose different, a ghost part will be returned!");
                        Console.Write("Choose the type of head: ");
                        string head = Console.ReadLine().ToUpper();
                        Console.Write("Choose the type of body: ");
                        string body = Console.ReadLine().ToUpper();
                        Console.Write("Choose the type of feet: ");
                        string feet = Console.ReadLine().ToUpper();
                        BuildACreature(head, body, feet);
                        break;
                    case "RANDOM":
                        RandomMode();
                        break;
                    case "EXIT":
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please choose one of the valid options \"MANUAL\", \"RANDOM\" or \"EXIT\"!\n\n");
                        break;
                }
            }
        }

        public static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);

            SwitchCase(headNum, bodyNum, feetNum);
        }

        public static void RandomMode()
        {
            Random rand = new Random();
            int head = rand.Next(1, 4);
            int body = rand.Next(1, 4);
            int feet = rand.Next(1, 4);

            SwitchCase(head, body, feet);
        }

        public static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
            }
        }

        public static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "GHOST":
                    return 1;
                case "BUG":
                    return 2;
                case "MONSTER":
                    return 3;
                default:
                    Random rand = new Random();
                    return rand.Next(1, 4);
            }
        }

        public static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        public static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        public static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        public static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        public static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        public static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        public static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        public static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        public static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
