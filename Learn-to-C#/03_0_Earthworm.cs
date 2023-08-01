namespace Earthworm
{
    public static class Client
    {
        public static void Main()
        {
            GameSystem gameSystem = new GameSystem();
            Player player = new Player();
            GameOver gameOver = new GameOver();

            // 맵의 크기
            int xWallSize = 20; int yWallSize = 20;
            // 플레이어 초기 위치
            int xPlayer = 8; int yPlayer = 8;

            bool isGameover = false;


            while (!isGameover)
            {
                // 벽 만들기
                gameSystem.Wall(xWallSize, yWallSize);


                // 플레이어 위치 출력
                player.PlayerPosition(ref xPlayer, ref yPlayer);




                // 게임 오버
                bool isWallCrash = false;
                bool isSameX = xPlayer == xWallSize;
                bool isSameY = yPlayer == yWallSize;
                isGameover = gameOver.WallCrash(ref xPlayer, ref yPlayer, xWallSize, yWallSize);
                // 게임 오버가 되지 않는다. 수정하자.


                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}

