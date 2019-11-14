using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class NotExistentChessCellException : Exception
    {
        public override string Message => "NotExistentChessCellException"; //Message
    }
}
