using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Extension.ExtraTypes;

namespace ChessGame.MainGame
{
    public enum TileColor
    {
        None = 0,
        Black,
        White
    }

    /// <summary>
    /// 1 ô trên bàn cờ.
    /// </summary>
    public class Tile : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField]
        private IntVector2 coordinate;

        /// <summary>
        /// Tọa độ trong bàn cờ.
        /// </summary>
        public IntVector2 Coordinate
        {
            get { return coordinate; }
            set {coordinate = value; }
        }

        /// <summary>
        /// Quân cờ đang nằm ở ô này.
        /// </summary>
        public ChessPiece OnTilePiece { get; set; }

        public TileColor TileColor
        {
            get
            {
                return ((Coordinate.x + Coordinate.y) % 2 == 0) ? TileColor.White : TileColor.Black;
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (OnTilePiece != null)
            {
                Debug.Log(OnTilePiece.PieceColor + " " + OnTilePiece.PieceNames + " clicked.");
                // OnTilePiece.PieceMovement.GetAllPossibleMoveTiles(Coordinate);
            }
            else
            {
                Debug.Log("There is no chess piece in this tile.");
            }
        }
    }
}
