using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;

namespace ChessGame.MainGame
{
    public class BoardCreator : MonoBehaviour
    {
        [SerializeField]
        private Transform tileHolder, pieceHolder;

        [SerializeField]
        private float tileHeight;

        [SerializeField]
        private Tile blackTilePrefab, whiteTilePrefab;

        [SerializeField]
        private ChessPiece blackBishopPrefab,
                           blackKingPrefab,
                           blackKnightPrefab,
                           blackQueenPrefab,
                           blackRookPrefab,
                           blackPawnPrefab,
                           whiteBishopPrefab,
                           whiteKingPrefab,
                           whiteKnightPrefab,
                           whiteQueenPrefab,
                           whiteRookPrefab,
                           whitePawnPrefab;

        public Tile[,] AllTiles { get; private set; }

        protected virtual void Awake ()
        {
            InitBoard();            
        }

        private void InitBoard ()
        {
            AllTiles = new Tile[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // Tạo các ô của bàn cờ.
                    if ((i + j) % 2 == 0)
                    {
                        AllTiles[j, i] = Instantiate(whiteTilePrefab, new Vector3(i, tileHeight, j), Quaternion.identity, tileHolder);
                    }
                    else
                    {
                        AllTiles[j, i] = Instantiate(blackTilePrefab, new Vector3(i, tileHeight, j), Quaternion.identity, tileHolder);
                    }

                    AllTiles[j, i].Coordinate = new IntVector2(j, i);

                    PlaceDefaultPiece(AllTiles[j, i]);
                }
            }
        }

        /// <summary>
        /// Tạo quân cờ mặc định vào ô theo tọa độ trong bàn cờ.
        /// </summary>
        /// <param name="tile">Ô cờ</param>
        private void PlaceDefaultPiece(Tile tile)
        {
            ChessPiece defaultPiece = FindDefaultPieceWithCoordinate(tile.Coordinate);

            if (defaultPiece != null)
            {
                tile.OnTilePiece = Instantiate(defaultPiece, new Vector3(tile.transform.position.x, 0, tile.transform.position.z), Quaternion.identity, pieceHolder);
                tile.OnTilePiece.CurrentCoordinate = tile.Coordinate;
            }
        }

        /// <summary>
        /// Tìm quân cờ mặc định theo tọa độ.
        /// </summary>
        /// <param name="coordinate">Tọa độ bàn cờ.</param>
        /// <returns>Trả về quân cờ nếu tọa độ có chứa cờ mặc định, còn lại null.</returns>
        private ChessPiece FindDefaultPieceWithCoordinate (IntVector2 coordinate)
        {
            // Tốt
            if (coordinate.y == 1)
            {
                return blackPawnPrefab;
            }
            else if (coordinate.y == 6)
            {
                return whitePawnPrefab;
            }

            // Xe
            else if (coordinate.x == 0 || coordinate.x == 7)
            {
                if (coordinate.y == 0)
                {
                    return blackRookPrefab;
                }
                else if (coordinate.y == 7)
                {
                    return whiteRookPrefab;
                }
                else
                {
                    return null;
                }
            }
            // Mã
            else if (coordinate.x == 1 || coordinate.x == 6)
            {
                if (coordinate.y == 0)
                {
                    return blackKnightPrefab;
                }
                else if (coordinate.y == 7)
                {
                    return whiteKnightPrefab;
                }
                else
                {
                    return null;
                }
            }
            // Tượng
            else if (coordinate.x == 2 || coordinate.x == 5)
            {
                if (coordinate.y == 0)
                {
                    return blackBishopPrefab;
                }
                else if (coordinate.y == 7)
                {
                    return whiteBishopPrefab;
                }
                else
                {
                    return null;
                }
            }
            // Hậu & Vua
            else if (coordinate.x == 3)
            {
                if (coordinate.y == 0)
                {
                    return blackKingPrefab;
                }
                else if (coordinate.y == 7)
                {
                    return whiteQueenPrefab;
                }
                else
                {
                    return null;
                }
            }
            else if (coordinate.x == 4)
            {
                if (coordinate.y == 0)
                {
                    return blackQueenPrefab;
                }
                else if (coordinate.y == 7)
                {
                    return whiteKingPrefab;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
