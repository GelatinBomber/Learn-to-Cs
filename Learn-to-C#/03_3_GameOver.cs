

namespace Earthworm
{
    public class GameOver
    {
        public bool WallCrash(ref int xPlayer, ref int yPlayer, int xWallSize, int yWallSize)
        {
            bool isWallCrash = false;
            bool isSameX = xPlayer == xWallSize;
            bool isSameY = yPlayer == yWallSize;
            if (isSameX || isSameY)
            {
                isWallCrash = true;
                Console.WriteLine("벽과 충돌!! Game Over");
            }
            return isWallCrash;
        }
    }
}

