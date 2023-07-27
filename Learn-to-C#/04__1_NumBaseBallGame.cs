// 야구 게임을 만들어라.
// 규칙 1. 응답자는 3자리 숫자를 정한다
// 규칙 2. 질문자는 3자리 숫자를 선언한다.
// 규칙 3. 응답자는 질문자의 숫자와 비교하여,
// 숫자와 자리가 같으면 스트라이크
// 숫자만 같으면 볼
// 일치하는 숫자가 하나도 없다면 아웃

public static class Client
{
    public static void Main()
    {
        int AnswerNum = 456; // 정답
        int AnswerUnitsNum = AnswerNum % 10; // 정답의 일의 자리 숫자
        int AnswerTensNum = AnswerNum % 100 - AnswerUnitsNum; // 정답의 십의 자리 숫자
        int AnswerHundredsNum = AnswerNum % 1000 - AnswerTensNum - AnswerUnitsNum; // 정답의 백의 자리 숫자
        //Console.WriteLine(AnswerNum);
        //Console.WriteLine(AnswerUnitsNum);
        //Console.WriteLine(AnswerTensNum);
        //Console.WriteLine(AnswerHundredsNum);

        while (true)    // 윈도우 창이 지속되도록 만들기
        {
            Console.WriteLine("3 자리 정수를 입력하세요.");   // 사용자에게 명령하기
            string input = Console.ReadLine();  // 사용자로부터 3자리 정수를 받아서 input에 대입

            if (int.TryParse(input, out int QuetionNum))    // int 형인지 확인하기
            {
                if ((QuetionNum < 1000) && (QuetionNum > 99))   // 3자리 정수인지 확인하기
                {
                    Console.WriteLine($"당신이 입력한 정수는 {QuetionNum} 입니다.");
                    int QueUnitsNum = QuetionNum % 10;  // 사용자가 입력한 숫자 자릿수로 쪼개기
                    int QueTensNum = QuetionNum % 100 - QueUnitsNum;
                    int QueHundredsNum = QuetionNum % 1000 - QueUnitsNum - QueTensNum;

                    if (AnswerNum == QuetionNum)    // 정답인지 확인
                    {
                        Console.WriteLine("정답입니다.");
                        break; // 게임 끝
                    }
                    else
                    {
                        int StrikeNum = 0;  // 사용할 변수 초기화
                        int BallNum = 0;

                        if (AnswerUnitsNum == QueUnitsNum) // 일의 자리가 일치하는지
                        {
                            StrikeNum++;
                        }

                        if (AnswerTensNum == QueTensNum)    // 십의 자리
                        {
                            StrikeNum++;
                        }

                        if (AnswerHundredsNum == QueHundredsNum)
                        {
                            StrikeNum++;
                        }

                        List<int> AnswerNumList = new List<int>();  // 각 자릿수를 리스트에 담기
                        AnswerNumList.Add(AnswerUnitsNum);
                        AnswerNumList.Add(AnswerTensNum);
                        AnswerNumList.Add(AnswerHundredsNum);

                        for (int i = 0; i < 3; i++) // 일의 자리수와 일치하는 숫자가 있는지 확인
                        {
                            if (QueUnitsNum == AnswerNumList[i])
                            {
                                BallNum++;
                            }
                        }

                        for (int i = 0; i < 3; i++)

                        // 스트라이크 수와 볼 수를 확인 후 출력하기
                        Console.WriteLine($"스트라이크 수는 {StrikeNum} 입니다.");
                    }
                }
                else // 3 자리 정수가 아니면
                {
                    Console.WriteLine("입력한 데이터가 3 자릿수가 아닙니다." +
                        "\n3 자리 정수를 입력하세요.");
                }
            }
            else // 정수가 아니면
            {
                Console.WriteLine("입력한 데이터가 정수가 아닙니다." +
                    "\n3 자리 정수를 입력하세요.");
;            }
        }
    }
}