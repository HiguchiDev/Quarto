using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Piece
{
    public static class PiecePositionGetter
    {
        public static float getXPosition(Piece piece)
        {
            return 0.54f + ((piece.xGamePosition - 1) * -0.36f);

        }

        public static float getYPosition()
        {
            return 0.03f;
        }

        public static float getZPosition(Piece piece)
        {
            return 0.54f + ((piece.yGamePosition - 1) * -0.36f);
        }
    }

}
