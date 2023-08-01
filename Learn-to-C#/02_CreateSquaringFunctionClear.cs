
/*

namespace CreateSquaringFunctioin
{
    public static class Client
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("정수를 제곱해봅시다.");
                Console.WriteLine("원하는 정수를 입력하세요.");

                string input = Console.ReadLine();  // 사용자가 입력한 데이터를 input에 저장한다.
                                                    // Python과 다르게 String 값을 반환한다.

                if (int.TryParse(input, out int result)) // TryParse는 변환에 성공하면 True를 반환하고
                                                         // input에 있는 데이터를 정수로 바꿔서 result에 저장한다.
                {
                    Console.WriteLine("정수를 입력 했습니다.");
                    Console.WriteLine($"입력한 정수는 {result} 입니다.");
                    Console.WriteLine();
                    Console.WriteLine($"입력한 정수의 제곱은 {result * result} 입니다.");
                }
                else
                {
                    Console.WriteLine("정수를 입력하지 않았습니다.");
                    Console.WriteLine("정수를 입력하세요.");
                }
            }
        }
    }
}

*/