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
                board.PrintBoard(); // printar board med uppdaterade val

                if (CurrentPlayer) // if sats för att se vems tur det är
                {
                    Console.WriteLine("Player X choose a number between (1-9)");
                }
                else
                {
                    Console.WriteLine("Player O choose a number between (1-9)");
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
                        Console.Clear(); // tar bort föregående board och visar nya resultatet
                        board.PrintBoard();
                        Console.WriteLine(CurrentPlayer ? "Player X wins!" : "Player O wins!");
                        break;
                    }

                    CurrentPlayer = !CurrentPlayer; // För att byta spelare

                }
                else
                {
                    // Om spelaren angav ett ogiltigt val eller en upptagen plats. Detta kommer bara visas om man tar bort Console.Clear på rad 21!
                    Console.WriteLine("Felaktig input! Platsen är antingen tagen eller så har du skrivit in fel värde. Välj ett nummer mellan 1 - 9.");
                    Console.WriteLine("Tryck valfri tangent för att försöka igen..");
                
                }
                if (board.IsFull())
                {
                    Console.Clear(); // tar bort föregående board och visar nya resultatet
                    board.PrintBoard(); // skriver ut slutresultatet på board
                    Console.WriteLine("It´s a tie!");
                    break ;
                }
            }
        }
    }
}
