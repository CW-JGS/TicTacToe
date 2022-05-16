using System;


namespace gBoard
{
    class Board
    {
        Piece[] row0 = new Piece[3];
        Piece[] row1 = new Piece[3];
        Piece[] row2 = new Piece[3];
        

        public Board() {
            for(int i = 0; i<3; i++)
            {
                row0[i] = new Piece();
            }
            for(int i = 0; i<3; i++)
            {
                row1[i] = new Piece();
            }for(int i = 0; i<3; i++)
            {
                row2[i] = new Piece();
            }
        }
        public void TakePiece(int pieceNum, string player)
        {
            string tplayer = player.ToUpper();
            string letPlayer = tplayer == "X" ? "X" : tplayer == "O" ? "O" : "E";
            if(player == "E")return;
            if(pieceNum == 0)return;
            switch (pieceNum)
            {
                case 1:
                    row0[0].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 2:
                    row0[1].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 3:
                    row0[2].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 4:
                    row1[0].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 5:
                    row1[1].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 6:
                    row1[2].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 7:
                    row2[0].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 8:
                    row2[1].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                case 9:
                    row2[2].PieceState = letPlayer == "X" ? Piece.state.X : Piece.state.O;
                    break;
                default:
                    break;    
            }
        }
        public char findWinner() 
        {
            if (row0[0].PieceState == Piece.state.X && row1[1].PieceState == Piece.state.X && row2[2].PieceState == Piece.state.X)
                return 'X';
            if (row0[2].PieceState == Piece.state.X && row1[1].PieceState == Piece.state.X && row2[0].PieceState == Piece.state.X)
                return 'X';
            if (row0[0].PieceState == Piece.state.X && row0[1].PieceState == Piece.state.X && row0[2].PieceState == Piece.state.X)
                return 'X';
            if (row1[0].PieceState == Piece.state.X && row1[1].PieceState == Piece.state.X && row1[2].PieceState == Piece.state.X)
                return 'X';
            if (row2[0].PieceState == Piece.state.X && row2[1].PieceState == Piece.state.X && row2[2].PieceState == Piece.state.X)
                return 'X';
            if (row0[0].PieceState == Piece.state.X && row1[0].PieceState == Piece.state.X && row2[0].PieceState == Piece.state.X)
                return 'X';
            if (row0[1].PieceState == Piece.state.X && row1[1].PieceState == Piece.state.X && row2[1].PieceState == Piece.state.X)
                return 'X';
            if (row0[2].PieceState == Piece.state.X && row1[2].PieceState == Piece.state.X && row2[2].PieceState == Piece.state.X)
                return 'X';            
            if (row0[0].PieceState == Piece.state.O && row1[1].PieceState == Piece.state.O && row2[2].PieceState == Piece.state.O)
                return 'O';
            if (row0[2].PieceState == Piece.state.O && row1[1].PieceState == Piece.state.O && row2[0].PieceState == Piece.state.O)
                return 'O';
            if (row0[0].PieceState == Piece.state.O && row0[1].PieceState == Piece.state.O && row0[2].PieceState == Piece.state.O)
                return 'O';
            if (row1[0].PieceState == Piece.state.O && row1[1].PieceState == Piece.state.O && row1[2].PieceState == Piece.state.O)
                return 'O';
            if (row2[0].PieceState == Piece.state.O && row2[1].PieceState == Piece.state.O && row2[2].PieceState == Piece.state.O)
                return 'O';
            if (row0[0].PieceState == Piece.state.O && row1[0].PieceState == Piece.state.O && row2[0].PieceState == Piece.state.O)
                return 'O';
            if (row0[1].PieceState == Piece.state.O && row1[1].PieceState == Piece.state.O && row2[1].PieceState == Piece.state.O)
                return 'O';
            if (row0[2].PieceState == Piece.state.O && row1[2].PieceState == Piece.state.O && row2[2].PieceState == Piece.state.O)
                return 'O';
            else 
                return 'U';
            
        }
        public override string ToString()
        {
            List<Piece.state> makeIntoString = new List<Piece.state>() ;
            foreach(var row in row0)
            {
                makeIntoString.Add(row.PieceState);
            }
            foreach(var row in row1)
            {
                makeIntoString.Add(row.PieceState);
            }
            foreach (var row in row2)
            {
                makeIntoString.Add(row.PieceState);   
            }
            return string.Format("{0} 1| {1} 2| {2} 3\n-------------\n{3} 4| {4} 5| {5} 6\n-------------\n{6} 7| {7} 8| {8} 9",makeIntoString[0],makeIntoString[1],makeIntoString[2],makeIntoString[3],makeIntoString[4],makeIntoString[5],makeIntoString[6],makeIntoString[7],makeIntoString[8]);
        }
    }
}