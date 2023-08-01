

namespace Earthworm
{
    public class GameSystem
    {
        public void Wall(int xWallSize, int yWallSize)
        {
            for (int i = 0; i < yWallSize; i++)
            {
                for (int j = 0; j < xWallSize; j++)
                {
                    if ((i == 0)||(i == yWallSize -1)||(j == 0)||(j == yWallSize - 1))
                    {
                        Console.SetCursorPosition(i,j);
                        Console.Write("■");
                    }
                    //Console.WriteLine();
                }
                //Console.WriteLine();
            }
        }
    }
}

