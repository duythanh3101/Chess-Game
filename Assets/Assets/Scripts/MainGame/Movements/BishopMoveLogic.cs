using Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extension.ExtraTypes;

namespace ChessGame.MainGame
{
    [CreateAssetMenu(fileName = "BishopMovLogic", menuName = "ScriptableObject/BishopMovLogic", order = 4)]
    public class BishopMoveLogic : PieceMoveLogic
    {
        public override IEnumerable<IntVector2> GetAllPossibleMoveTiles(IntVector2 currentCoordinate)
        {
            throw new System.NotImplementedException();
        }
    }
}
