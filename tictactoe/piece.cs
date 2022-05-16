using System;

namespace gBoard
{
    class Piece
    {
        public enum state
        {
            X,
            O,
            U
        }
        public state PieceState {get; set;}
        public Piece() {
            PieceState = state.U;
        }
    }
}