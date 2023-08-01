﻿// 야구 게임을 만들어라.
// 규칙 1. 응답자는 3자리 숫자를 정한다
// 규칙 2. 질문자는 3자리 숫자를 선언한다.
// 규칙 3. 응답자는 질문자의 숫자와 비교하여,
// 숫자와 자리가 같으면 스트라이크
// 숫자만 같으면 볼
// 일치하는 숫자가 하나도 없다면 아웃


// 수정 사항
// 정답을 고정값에서 랜덤으로 만들기
// 카운트 다운 추가

/*
namespace NumBaseballGameVer3
{
    public static class Client
    {
        public static void Main()
        {
            Random random = new Random(); // 랜덤 만들기


            int AnswerNum = random.Next(100, 1000); // 100 이상 1000미만인 정수
            List<int> AnswerNumList = new List<int>();  // 각 자릿수를 리스트에 담기
            AnswerNumList.Add(AnswerNum % 10);
            AnswerNumList.Add((AnswerNum % 100 - AnswerNum % 10) / 10);
            AnswerNumList.Add((AnswerNum % 1000 - AnswerNum % 100) / 100);

            while (true)
            {
                AnswerNum = random.Next(100, 1000); // 100 이상 1000미만인 정수

                AnswerNumList = new List<int>();  // 각 자릿수를 리스트에 담기
                AnswerNumList.Add(AnswerNum % 10);
                AnswerNumList.Add((AnswerNum % 100 - AnswerNum % 10) / 10);
                AnswerNumList.Add((AnswerNum % 1000 - AnswerNum % 100) / 100);


                bool isSameValue1 = AnswerNumList[0] == AnswerNumList[1];
                bool isSameValue2 = AnswerNumList[1] == AnswerNumList[2];
                bool isSaneValue3 = AnswerNumList[2] == AnswerNumList[0];
                bool isStop = (isSameValue1 || isSameValue2 || isSaneValue3) == false;


                if (isStop)
                {
                    break;
                }


            }

            Console.WriteLine($"연습용 정답은 [ {AnswerNum} ] 입니다.");

            int Count = 1;  // 카운트 다운 변수 설정
            int Turn = 3;   // 턴 수 설정

            while (true)    // 윈도우 창이 지속되도록 만들기
            {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"[ {Count} ] 번째 턴입니다."); // 턴 알려주기.
                Console.WriteLine($"[ {Turn - Count + 1} ] 번의 기회가 남았습니다.");
                Count++;


                Console.WriteLine("3 자리 정수를 입력하세요.");   // 사용자에게 명령하기
                string input = Console.ReadLine();  // 사용자로부터 3자리 정수를 받아서 input에 대입

                if (int.TryParse(input, out int QuetionNum))    // int 형인지 확인하기
                {
                    if ((QuetionNum < 1000) && (QuetionNum > 99))   // 3자리 정수인지 확인하기
                    {
                        Console.WriteLine($"당신이 입력한 정수는 [ {QuetionNum} ] 입니다.");

                        if (AnswerNum == QuetionNum)    // 정답인지 확인
                        {
                            Console.WriteLine("정답입니다.");
                            break; // 게임 끝
                        }
                        else
                        {
                            int StrikeNum = 0;  // 사용할 변수 초기화
                            int BallNum = 0;

                            List<int> QuestionNumList = new List<int>();
                            QuestionNumList.Add(QuetionNum % 10);
                            QuestionNumList.Add((QuetionNum % 100 - QuetionNum % 10) / 10);
                            QuestionNumList.Add((QuetionNum % 1000 - QuetionNum % 100) / 100);

                            // 스트라이크 개수 세기
                            for (int i = 0; i < 3; i++)
                            {
                                if (AnswerNumList[i] == QuestionNumList[i])
                                {
                                    StrikeNum++;
                                }
                            }

                            // 볼 개수 세기
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (AnswerNumList[i] == QuestionNumList[j])
                                    {
                                        BallNum++;
                                    }
                                }
                            }
                            // 볼 개수가 스크라이크 개수를 포함하고 있으니까 개수 빼기
                            BallNum -= StrikeNum;



                            // 스트라이크 수와 볼 수를 확인 후 출력하기
                            Console.WriteLine($"스트라이크 개수는 [ {StrikeNum} ] 입니다.");
                            Console.WriteLine($"볼 개수는 [ {BallNum} ] 입니다.");
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
                }


                if (Count == Turn + 1)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
    }
}

*/