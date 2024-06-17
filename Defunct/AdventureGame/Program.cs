using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            string asciiTitle = @"
 ________  ________      ___    ___      ________  ________          ________  _______  _________  ________  ________  ________  _______   ________     
|\   ____\|\   __  \    |\  \  /  /|    |\   __  \|\   __  \        |\   __  \|\  ___ \|\___   ___\\   __  \|\   __  \|\   ___ \|\  ___ \ |\   ___ \    
\ \  \___|\ \  \|\  \   \ \  \/  / /    \ \  \|\  \ \  \|\  \       \ \  \|\  \ \   __/\|___ \  \_\ \  \|\  \ \  \|\  \ \  \_|\ \ \   __/|\ \  \_|\ \   
 \ \  \  __\ \   __  \   \ \    / /      \ \  \\\  \ \   _  _\       \ \   _  _\ \  \_|/__  \ \  \ \ \   __  \ \   _  _\ \  \ \\ \ \  \_|/_\ \  \ \\ \  
  \ \  \|\  \ \  \ \  \   \/  /  /        \ \  \\\  \ \  \\  \|       \ \  \\  \\ \  \_|\ \  \ \  \ \ \  \ \  \ \  \\  \\ \  \_\\ \ \  \_|\ \ \  \_\\ \ 
   \ \_______\ \__\ \__\__/  / /           \ \_______\ \__\\ _\        \ \__\\ _\\ \_______\  \ \__\ \ \__\ \__\ \__\\ _\\ \_______\ \_______\ \_______\
    \|_______|\|__|\|__|\___/ /             \|_______|\|__|\|__|        \|__|\|__|\|_______|   \|__|  \|__|\|__|\|__|\|__|\|_______|\|_______|\|_______|
                       \|___|/                                                                                                                          
                                                                                                                                                        
                                                                                                                                                        ";
            Console.WriteLine(asciiTitle);
            Game.StartGame();
            Game.levelOne();
            Console.ReadKey();
        }
    }
}
    