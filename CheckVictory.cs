﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CheckVictory
    {
        public bool IsVictory(string[] board) // metod som kommer användas för att kolla om någon har vunnit
        {
        bool row1 = board[0] == board[1] && board[1] == board[2]; // Kollar rows
        bool row2 = board[3] == board[4] && board[4] == board[5];
        bool row3 = board[6] == board[7] && board[7] == board[8];

        bool col1 = board[0] == board[3] && board[3] == board[6]; // Kollar columns
        bool col2 = board[1] == board[4] && board[4] == board[7];
        bool col3 = board[2] == board[5] && board[5] == board[8];

        bool diagDown = board[0] == board[4] && board[4] == board[8]; // Kollar diagonals
        bool diagUp = board[6] == board[4] && board[4] == board[2];

        return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp; // retunerar true om någon av dessa är true = Wins!
        }
    }
}
