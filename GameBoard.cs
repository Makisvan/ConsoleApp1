using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameBoard
    {
        public string[] board; // Field som reppar board
        public GameBoard() // Konstruktor
        {   
            board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };   // ger board siffror 1-9
        }
        public string[] Board // property för att få kunna komma åt board
        {
            get { return board; }
        }
        public void PrintBoard() // metod för att skriva ut board
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i * 3 + j] + "|");
                }
                Console.WriteLine();
                Console.WriteLine("------");
            }
        }
        public bool Contains(string choice) // metod för att kontrollera om en siffra finns på board
        {
            return Array.Exists(board, element => element == choice); // board är arrayen som metoden kommer söka igenom (element i arrayen = värdet choice)
        }
        public bool IsFull() // metod för att kolla om board är fullt (för tie)
        {
            foreach (var cell in board)
            {
                if (cell != "X" && cell != "O") // Kontrollerar om alla element är "X" eller "O" , vilket betyder att board är fullt.
                {
                    return false; // Om det finns en siffra kvar är board inte fullt
                }
            }
            return true; // Board är fullt
        }
    }
}
