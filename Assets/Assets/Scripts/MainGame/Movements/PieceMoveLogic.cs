using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;
using Extension.Attributes;

namespace ChessGame.MainGame
{   
    public abstract class PieceMoveLogic : ScriptableObject
    {
        /// <summary>
        /// Tìm tất cả các tọa độ có thể đi tới trong bàn cờ.
        /// </summary>
        /// <param name="currentCoordinate">Tọa đô trong bàn cờ hiện tại.</param>
        /// <returns>Tất cả các ô hợp lệ trên bàn cờ.</returns>
        public abstract IEnumerable<IntVector2> GetAllPossibleMoveTiles(IntVector2 currentCoordinate);
    }
}
