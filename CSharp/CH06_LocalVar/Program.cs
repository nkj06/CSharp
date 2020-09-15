using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 멤버변수 -> 클래스 내부에 있다고 해서 멤버변수
    int Att;
    int Hp;

    void Fight()
    {
        int Damage = 0; // 함수안에 있으니까 지역변수

        Console.WriteLine("플레이어가 싸운다.");
    } 
}

namespace CH06_LocalVar
{
    // C#은 고지식한 객체지향 언어. 클래스밖에 모르는 바보
    // 프로그램의 시작 조차도 클래스안에 묶어놔야 한다.
    class Program
    {
        // 시작용 함수가 있는 것이고
        static void Main(string[] args)
        {
            /*
             * 클래스 안에 있으면 멤버변수
             * 함수안에 있는 녀석들을 지역변수
             * 
             * 지역변수 규칙1
             * {
             *      내부에서만 사용가능
             * }
             */

            int ATT = 0;
            ATT = 50;

            /*
             * 객체화?
             * Player의 설계대로 플레이어를 만드는데 그 이름을 NewPlayer라고 해라
             */
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
        }
    }
}
