using Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;

namespace ChessGame.MainGame
{
    [CreateAssetMenu(fileName = "QueenMoveLogic", menuName = "ScriptableObject/QueenMoveLogic", order = 1)]
    public class QueenMoveLogic : PieceMoveLogic
    {
        public override IEnumerable<IntVector2> GetAllPossibleMoveTiles(IntVector2 currentCoordinate)
        {
            throw new System.NotImplementedException();
        }
    }
}
