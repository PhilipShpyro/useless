using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class ChessCell
    {
        private int row;
        private char line;

        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                if((row > 8 || row < 1))
                {
                    throw new NotExistentChessCellException();
                }
                row = value;
            }
        }
        public char Line
        {
            get
            {
                return line;
            }
            set
            {
                if((int)value > 104 || (int)value < 97)
                {
                    throw new NotExistentChessCellException();
                }
                line = value;
            }
        }

        public ChessCell(char line, int row)
        {
            if(((int)line > 104 || (int)line < 97) || (row > 8 || row < 1))
            {
                Console.WriteLine("done");
                throw new NotExistentChessCellException();
            }
            this.line = line;
            this.row = row;
        }
        public bool IsWhite()
        {
            return ((((int)line - 96) % 2 == 0) && (row % 2 != 0)) || ((((int)line - 96) % 2 != 0) && (row % 2 == 0));
        }
        public bool OnDiagonalWith(ChessCell cell)
        {
            return (row - cell.row) == (line - cell.line);
        }
        public bool OnLineWith(ChessCell cell)
        {
            return line == cell.line;
        }
        public bool OnRowWith(ChessCell cell)
        {
            return row == cell.row;
        }
    }
}
