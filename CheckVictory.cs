using System;
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
            if (this.checkIfOneOfTheRowsIsFilledWithTheSameMark(board))
                return true;
            if (this.checkIfOneOfTheColumnsIsFilledWithTheSameMark(board))
                return true;
            if (this.checkIfOneOfTheDiagonalsIsFilledWithTheSameMark(board))
                return true;
            return false; // retunerar true om någon av dessa är true = Wins!
        }
        private bool isRowFilledWithTheSameMark(string cell1, string cell2, string cell3)
        {
            if (cell1 == cell2 && cell2 == cell3) return true;
            return false;
        }
        private bool isColumnFilledWithTheSameMark(string cell1, string cell2, string cell3)
        {
            if (cell1 == cell2 && cell2 == cell3) return true;
            return false;
        }
        private bool isDiagonalFilledWithTheSameMark(string cell1, string cell5, string cell9)
        {
            if (cell1 == cell5 && cell5 == cell9) return true;
            return false;

        }
        private bool checkIfOneOfTheRowsIsFilledWithTheSameMark(string[] board)
        {
            if (this.isRowFilledWithTheSameMark(board[0], board[1], board[2]))
                return true;
            if (this.isRowFilledWithTheSameMark(board[3], board[4], board[5]))
                return true;
            if (this.isRowFilledWithTheSameMark(board[6], board[7], board[8]))
                return true;
            return false;
        }
        private bool checkIfOneOfTheColumnsIsFilledWithTheSameMark(string[] board)
        {
            if (this.isColumnFilledWithTheSameMark(board[0], board[3], board[6]))
                return true;
            if (this.isColumnFilledWithTheSameMark(board[1], board[4], board[7]))
                return true;
            if (this.isColumnFilledWithTheSameMark(board[2], board[5], board[8]))
                return true;
            return false;

        }
        private bool checkIfOneOfTheDiagonalsIsFilledWithTheSameMark(string[] board)
        {
            if (this.isDiagonalFilledWithTheSameMark(board[0], board[4], board[8]))
                return true;
            if (this.isDiagonalFilledWithTheSameMark(board[6], board[4], board[2]))
                return true;
            return false;
        }
    }
}
