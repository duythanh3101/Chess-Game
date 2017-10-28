using Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;

namespace ChessGame.MainGame
{
    [CreateAssetMenu(fileName = "PawnMoveLogic", menuName = "ScriptableObject/PawnMoveLogic", order = 2)]
    public class PawnMoveLogic : PieceMoveLogic
    {
        public override IEnumerable<IntVector2> GetAllPossibleMoveTiles(IntVector2 currentCoordinate)
        {
            throw new System.NotImplementedException();
        }
    }
}
