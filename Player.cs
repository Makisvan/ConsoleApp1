using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        bool CurrentPlayer = true; // skapar variabel CurrentPlayer och ger den värdet True
        CheckVictory checkVictory = new CheckVictory(); // instans av CheckVictory klassen
        
        
        public Player() 
        {
            GameBoard board = new GameBoard(); // skapar instans av Gameboard
            
            while (true)
            {
                Console.Clear(); // tar bort föregående board så det blir snyggt
                board.PrintBoard(); // printar board

                if (CurrentPlayer) // if sats för att se vems tur det är
                {
                    Console.WriteLine("Player X turn!");
                }
                else
                {
                    Console.WriteLine("Player O turn!");
                }

                string choice = Console.ReadLine(); // spelarens val av nummer på board

                if (board.Contains(choice) && choice != "X" && choice != "O") // kontrollerar om valet är giltigt och inte tagen
                {
                    int boardIndex = Convert.ToInt32(choice) - 1; // Valet som index

                    if (CurrentPlayer)
                    {
                        board.Board[boardIndex] = "X"; // sätter "X" på den valda platsen
                    }
                    else
                    {
                        board.Board[boardIndex] = "O"; // sätter "O" på den valda platsen
                    }

                    if (checkVictory.IsVictory(board.Board)) // Kontrollerar om någon har vunnit
                    {
                        board.PrintBoard();
                        Console.WriteLine(CurrentPlayer ? "Player X wins!" : "Player O wins!");
                        break;
                    }

                    CurrentPlayer = !CurrentPlayer; // För att byta spelare
                }
                if (board.IsFull())
                {
                    board.PrintBoard(); // skriver ut slutresultatet på board
                    Console.WriteLine("It´s a tie!");
                    break ;
                }
            }
        }
    }
}
