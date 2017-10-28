using Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;

namespace ChessGame.MainGame
{
    [CreateAssetMenu(fileName = "KingMoveLogic", menuName = "ScriptableObject/KingMoveLogic", order = 5)]
    public class KingMoveLogic : PieceMoveLogic
    {
        public override IEnumerable<IntVector2> GetAllPossibleMoveTiles(IntVector2 currentCoordinate)
        {
            throw new System.NotImplementedException();
        }
    }
}
