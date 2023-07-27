public static class Client
{
    public static void Main()
    {
        int xSize = 20;
        int ySize = 20;

        while (true)
        {

            //상단
            for (int i = 0; i < xSize; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();

            // 세로 벽
            for (int i = 0;i < ySize-2; i++)
            {
                Console.Write("■");
                for (int k  = 0; k < xSize-2; k++)
                {
                    Console.Write("□");
                }
                Console.Write("■");
                Console.WriteLine();
            }

            // 하단
            for (int i = 0; i < xSize; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();






            Thread.Sleep(500);
            Console.Clear();
        }
    }
}