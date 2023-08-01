namespace Earthworm
{
    public class GameSystem
    {
        public void Wall(int xWallSize, int yWallSize)
        {
            for (int i = 0; i < xWallSize; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();

            for (int i = 0; i < yWallSize - 2; i++)
            {
                Console.Write("■");
                for (int j = 0; j < xWallSize - 2; j++)
                {
                    Console.Write("□");
                }
                Console.WriteLine("■");
            }

            for (int i = 0; i < xWallSize; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }

        //public bool GameOver(ref int xP)
    }
}