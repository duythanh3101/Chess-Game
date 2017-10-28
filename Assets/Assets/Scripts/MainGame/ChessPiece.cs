using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;
using Extension.Attributes;

namespace ChessGame.MainGame
{
    public enum PieceNames
    {
        None = 0,
        King,
        Queen,
        Bishop,
        Knight,
        Rook,
        Pawn
    }

    /// <summary>
    /// Thể hiện phe của quân cờ.
    /// </summary>
    public enum PieceColor
    {
        None = 0,
        Black,
        White
    }

    public class ChessPiece : MonoBehaviour
    {
        [SerializeField, ReadOnly]
        private IntVector2 currentCoordinate;

        [SerializeField]
        private PieceNames pieceNames;

        [SerializeField]
        private PieceColor pieceColor;

        [SerializeField]
        private PieceMoveLogic pieceMovement;

        public PieceNames PieceNames { get { return pieceNames; } }

        public PieceColor PieceColor { get { return pieceColor; } }

        public PieceMoveLogic PieceMovement
        {
            get { return pieceMovement; }
            set { pieceMovement = value; }
        }

        public IntVector2 CurrentCoordinate
        {
            get { return currentCoordinate; }
            set { currentCoordinate = value; }
        }
    }
}
