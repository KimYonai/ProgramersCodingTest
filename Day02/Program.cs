namespace Day02
{
    public class Program
    {
        // 문제1. 각에서 0도 초과 90도 미만은 예각, 90도는 직각, 90도 초과 180도 미만은 둔각 180도는 평각으로 분류합니다. 각 angle이 매개변수로 주어질 때 
        //        예각일 때 1, 직각일 때 2, 둔각일 때 3, 평각일 때 4를 return하도록 solution 함수를 완성해주세요.
        // 예각:  0 < angle < 90 / 직각: angle = 90 / 둔각: 90 < angle < 180 / 평각: angle = 180
        // <제한사항>
        // *0 < angle ≤ 180
        // *angle은 정수입니다.
        // [입출력 예시: angle=70, answer=1 / angle=91, answer=3 / angle=180, answer=4

        // 1. angle을 생성자로 포함한 Solution1 함수 정의
        public int Solution1(int angle)
        {
            // 2. answer 변수를 선언 및 초기화
            int answer = 0;

            // 3. angle이 예각일 때 answer에 1 대입하는 조건문
            if (angle > 0 && angle < 90)
            {
                answer = 1;
            }
            // 4. angle이 직각일 때 answer에 2 대입하는 조건문
            else if (angle == 90)
            {
                answer = 2;
            }
            // 5. angle이 둔각일 때 answer에 3 대입하는 조건문
            else if (angle > 90 && angle < 180)
            {
                answer = 3;
            }
            // 6. angle이 평각일 때 answer에 4 대입하는 조건문
            else if (angle == 180)
            {
                answer = 4;
            }
            // 7. 결과값 도출
            return answer;
        }


        // 문제2. 머쓱이네 양꼬치 가게는 10인분을 먹으면 음료수 하나를 서비스로 줍니다. 양꼬치는 1인분에 12,000원, 음료수는 2,000원입니다. 
        //        정수 n과 k가 매개변수로 주어졌을 때, 양꼬치 n인분과 음료수 k개를 먹었다면 총얼마를 지불해야 하는지 return 하도록 solution 함수를 완성해보세요.
        // <제한사항>
        // *0 < n < 1,000
        // *n / 10 ≤ k < 1,000
        // *서비스로 받은 음료수는 모두 마십니다.
        // [입출력 예시: n=10, k=3 -> result=124,000 / n=64, k=6 -> result=768,000

        // 1. n과 k를 생성자로 포함하는 Solution2 함수 정의
        public int Solution2(int n, int k)
        {
            // 2. 양꼬치와 음료수의 가격을 변수로 선언 및 초기화
            int lamb = n * 12000;
            int drink = 0;

            // 3. n을 10으로 나눈 몫이 10보다 클 때 k에서 n/10의 몫을 뺀 가격만큼 drink에 대입
            if (n / 10 > 0)
            {
                drink = (k - (n / 10)) * 2000;
            }
            // 4. n을 10으로 나눈 몫이 10보다 작을 때 음료수의 총 가격은 개수 X 가격
            else
            {
                drink = k * 2000;
            }

            // 5. 양꼬치의 총 가격과 음료수의 총 가격을 더한 최종 값인 answer 변수를 선언 및 초기화
            int answer = lamb + drink;

            // 6. 결과값 도출
            return answer;
        }


        static void Main()
        {

        }
    }
}
