namespace Day01
{
    public class Program
    {
        // 문제1: 정수 num1과 num2가 주어질 때, num1과 num2의 합을 return하도록 solution 함수를 완성해주세요.
        // <제한사항>
        // *-50000 <= num1 <=50000
        // *-50000 <= num2 <=50000
        // [입출력 예시: 2,3=5 / 100,2=102]

        //1. 정수 num1과 num2를 생성자로 포함하는 Solution1 함수 생성
        public int Solution1(int num1, int num2)                   
        {
            //2. num1과 num2를 더하기 연산 실행
            int answer = num1 + num2;
            //3. num1과 num2의 더하기 연산값 도출
            return answer;                                        
        }


        // 문제2: 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 solution 함수를 완성해주세요.
        // <제한사항>
        // *-50000 <= num1 <=50000
        // *-50000 <= num2 <=50000
        // [입출력 예시: 2,3=-1 / 100,2=98]

        //1. 정수 num1과 num2를 생성자로 포함하는 Solution2 함수 생성
        public int Solution2(int num1, int num2)                 
        {
            //2. num1과 num2를 마이너스 연산 실행
            int answer = num1 - num2;
            //3. num1과 num2의 마이너스 연산값 도출
            return answer;                                      
        }


        // 문제3: 정수 num1, num2가 매개변수 주어집니다.num1과 num2를 곱한 값을 return 하도록 solution 함수를 완성해주세요.
        // <제한사항>
        // *0 <= num1 <= 100
        // *0 <= num2 <= 100
        // [입출력 예시: 3,4=12 / 27,19=513]

        //1. 정수 num1과 num2를 생성자로 포함하는 Solution3 함수 생성
        public int Solution3(int num1, int num2)                   
        {
            //2. num1과 num2를 곱연산 실행
            int answer = num1 * num2;
            //3. num1과 num2의 곱 연산값 도출
            return answer;                                     
        }


        // 문제4: 정수 num1, num2가 매개변수 주어질 때, num1을 num2로 나눈 몫을 return 하도록 solution 함수를 완성해주세요.
        // <제한사항>
        // *0 <= num1 <= 100
        // *0 <= num2 <= 100
        // [입출력 예시: 10,5=2 / 7,2=3]

        //1. 정수 num1과 num2를 생성자로 포함하는 Solution4 함수 생성
        public int Solution4(int num1, int num2)                 
        {
            //2. num1과 num2를 나누기 연산 실행
            int answer = num1 / num2;
            //3. num1과 num2의 나누기 연산으로 인한 몫만 연산값으로 출력
            return answer;                                       
        }


        // 문제5: 정수 num1과 num2가 매개변수로 주어집니다. 두 수가 같으면 1, 다르면 -1을 return하도록 solution 함수를 완성해주세요.
        // <제한사항>
        // *0 <= num1 <= 10000
        // *0 <= num2 <= 10000
        // [입출력 예시: 2,3 = -1 / 11,11=1 / 7,99=-1]

        //1. 정수 num1과 num2를 생성자로 포함하는 Solution5 함수 생성
        public int Solution5(int num1, int num2)       
        {
            //2. 결과값을 받을 answer을 int로 변수 선언
            int answer;
            //3. num1과 num2가 같을 때 answer(결과값)을 1로 설정
            if (num1 == num2)                         
            {
                answer = 1;                           
            }
            //4. 나머지 경우(num1과 num2가 같지 않을 때)에는 answer(결과값)을 -1로 설정
            else
            {
                answer = -1;                          
            }
            //5. 조건에 따른 결과값 도출
            return answer;                            
        }


        // 문제6: 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
        // <제한사항>
        // *0 <= num1 <= 100
        // *0 <= num2 <= 100
        // [입출력 예시: 3,2=1500 / 7,3=2333 / 1,16=62]

        //1. 정수 num1과 num2를 생성자로 포함하는 Solution6 함수 생성
        public int Solution6(int num1, int num2)
        {
            //2. num1과 num2를 float로 형변환 후 나누기 연산으로 result 값 구하기
            float result = (float)num1 / (float)num2;
            //3. result에 1000.f를 곱하여 change의 값 구하기
            float change = result * 1000.0f;
            //4. 정수 부분만 return하기 위해 change를 int로 형변환
            int answer = (int)change;
            //5. 결과값 도출
            return answer;                              
        }


        // 문제7: 정수 num1, num2가 매개변수로 주어질 때, num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.
        // <제한사항>
        // *0 <= num1 <= 100
        // *0 <= num2 <= 100
        // [입출력 예시: 3,2=1 / 10,5=0]

        //1. 정수 num1과 num2를 생성자로 포함하는 Solution7 함수 생성
        public int Solution7(int num1, int num2)
        {
            //2. num1과 num2의 나머지 구하기 연산으로 answer 값 구하기
            int answer = num1 % num2;
            //3. 결과값 도출
            return answer;                  
        }


        // 문제8: 머쓱이는 선생님이 몇 년도에 태어났는지 궁금해졌습니다. 2022년 기준 선생님의 나이 age가 주어질 때, 
        //        선생님의 출생 연도를 return 하는 solution 함수를 완성해주세요.
        // <제한사항>
        // *0 < age <= 120
        // *나이는 태어난 연도에 1살이며, 매년 1월 1일마다 1살씩 증가합니다.
        // [입출력 예시: 40=1983 / 23=2000]

        //1. age와 answer을 생성자로 포함한 Solution8 함수 생성
        public int Solution8(int age, int answer)       
        {
            //2. 0 < age <= 120일 때, 2022년에서 나잇값(나이-1)을 빼는 연산 수행
            if (age > 0 && age <= 120)
            {
                answer = 2022 - (age - 1);
            }
            //3. 결과값 도출
            return answer;
        }


        // 문제9: 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
        // <제한사항>
        // *0 ≤ numbers의 원소 ≤ 1,000
        // *1 ≤ numbers의 길이 ≤ 100
        // *정답의 소수 부분이 .0 또는 .5인 경우만 입력으로 주어집니다.
        // [입출력 예시: 1,2,3,4,5,6,7,8,9,10=5.5 / 89,90,91,92,93,94,95,96,97,98,99=94.0

        //1. 배열 내 모든 정수를 합한 값에 대한 변수 선언 및 초기화
        public int sum = 0;

        //2. 배열을 생성자로 포함한 Solution9 함수 생성
        public double Solution9(int[] numbers)      
        {
            //3. 배열 내 값을 모두 더하여 sum에 대입하는 조건문
            foreach (int num in numbers)            
            {
                sum += num;
            }
            //4. double로 값을 내기 위해 sum을 double로 형변환하여 배열의 길이만큼 나누기 연산 진행
            double answer = (double)sum / numbers.Length;

            //5. 결과값 도출
            return answer;      
        }

        static void Main()
        {

        }
    }
}
