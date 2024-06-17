namespace Adventure
{
    public static partial class Game
    {
        //Name
        static string whatIsUp;
        public static string gayOrRetarded;

        //Print welcome
        public static void StartGame()
        {
            whatsUp();
            Dialogue("What the fuck is this red text about? \n");
            Console.Write("Enter G if it's because you are gay, or R if it's because you are retarded \n");
            gayOrRetarded = Console.ReadLine();

            if (gayOrRetarded == "G")
            {
                Dialogue("Nothing wrong with a bit of hardcore fun. \n");
            }

            else if (gayOrRetarded == "R")
            {
                Console.WriteLine("You must be a woman. Keep your jeans high and tight. \n");
            }

            else
            {
                Console.WriteLine("You can't follow basic instructions, so I assume you are retarded. \n");
            }
        }
        public static void levelOne()
        {
            int linesOfKet;
            playerObj player = new playerObj();
            Inventory inventoryContents = new Inventory();
            Ketamine bagOfKetamine = new Ketamine();
            
            Console.WriteLine("You've started with " + inventoryContents.availableCash + " GBP. Go on then jeans, what's your name? \n");
            player.playerName = Console.ReadLine();
            Console.WriteLine("Alright " + player.playerName + " what do you need? I have " + bagOfKetamine.amt + " grammes of ketamine, at " + bagOfKetamine.costPerG + " quid per g. how many do you want? Enter a number 1-10. \n");
            inventoryContents.grammesOfKet = Console.Read();
            inventoryContents.availableCash = inventoryContents.availableCash - inventoryContents.grammesOfKet * bagOfKetamine.costPerG;
            Dialogue("You purchased " + inventoryContents.grammesOfKet + " grammes for " + inventoryContents.grammesOfKet * bagOfKetamine.costPerG + " this is now in your inventory. \n");
            Console.WriteLine("You have " + inventoryContents.availableCash + " GBP remaining. \n");
            Console.WriteLine("Go on, have a tester sniff. Would be rude not to. Your current wonkiness is " + player.wonkiness + "%. Every 100mg line increases wonkiness by 20%. How many do you rack up? \n"); 
            linesOfKet = Console.Read();

            if (linesOfKet == 0)
            {
                Console.WriteLine("Are you sure? You don't seem yourself...");

            }
            else if (linesOfKet == 1)
            {
                player.wonkiness = linesOfKet * 20;
                Console.WriteLine("That hit the spot, your current wonkiness is " + player.wonkiness);
            }

            else { Console.Read(); }

        }
        
        static void whatsUp()
        {
            Console.WriteLine("What's up dog? \n");
            whatIsUp = Console.ReadLine();
            Console.WriteLine("Cool. " + whatIsUp + " is how my day is going too. \n");
        }
        static void Dialogue(string whatSheSaid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(whatSheSaid);
            Console.ResetColor();
        }

    }
}
    