using Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;

namespace ChessGame.MainGame
{
    [CreateAssetMenu(fileName = "KnightMoveLogic", menuName = "ScriptableObject/KnightMoveLogic", order = 3)]
    public class KnightMoveLogic : PieceMoveLogic
    {
        public override IEnumerable<IntVector2> GetAllPossibleMoveTiles(IntVector2 currentCoordinate)
        {
            throw new System.NotImplementedException();
        }
    }
}