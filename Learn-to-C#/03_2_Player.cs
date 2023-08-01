

namespace Earthworm
{
    public class Player
    {
        public void PlayerPosition(ref int xPlayer, ref int yPlayer)
        {
            Console.SetCursorPosition(xPlayer, yPlayer);
            Console.Write("◈");
            Console.CursorVisible = false;

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow: { xPlayer --; break; }
                    case ConsoleKey.RightArrow: { xPlayer ++; break; }
                    case ConsoleKey.UpArrow: { yPlayer--; break; }
                    case ConsoleKey.DownArrow: { yPlayer++; break; }
                }
            }
        }
    }
}

