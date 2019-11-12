using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessCell cell = new ChessCell('e', 2);
                Console.WriteLine(cell.IsWhite());
            }
            catch(NotExistentChessCellException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
