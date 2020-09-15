using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    /* 접근제한 지정자를 입력하지 않으면 디폴트로 private
     * 속성들은 외부에서 접근하지 못하는게 일반적으로 좋다.
     */
    private int LV = 1;
    private int ATT = 10;
    private int HP = 100;

    /*
     * 플레이어 레벨을 알고 싶다. 인자 값이 아닌 리턴값 사용
     * 리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용한다.
     * 외부에 알려줘야 하기 때문에 알려주는 순간 함수가 끝나게 된다.
     * 이 return이라는 문장을 사용하면 얼마나 많은 코드가 return 아래에 있든 함수가 종료하게 됨
     */

    public int GetLv()
    {
        LV = 1000;
        return LV;

        // 리턴을 하는 순간 함수가 끝나고 아래에 친 코드들은 모두 의미가 없다.
        LV = 999;
    }
    
    //상태라는건 멤버 변수. 어떤 상태가 변화하는 순간
    public void LVUP()
    {
        ATT = 100;
        HP = 1000;
    }

    public void SetHP(int _HP)
    {
        /* 내가 HP가 0이 되는 순간만 체크할 수도 있고,
         * 내가 100이되는 순간만 체크할 수도 있다. 
         * 가장 큰 핵심은 디버깅이 된다.
         */
        HP = _HP;
    }

    // void[리턴값] Func[이름 혹은 식별자] () [인자값]
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    // 리턴값은 자신이 리턴해주려는 자료형과 동일한 자료형이여야 한다.
    public int DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }

    // 함수? 보통 클래스 외부와의 소통을 위해서 만든다.
    // (int _Dmg)를 넣는다는 것은 외부에게 한 개의 int 값을 넣어서 전달해주겠다.
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
} 

// 플레이어가 어떤 사양과 모양을 가졌다.

namespace CH08_FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // NewPlayer.HP = 0;
            // NewPlayer.HP = NewPlayer.HP + 1;

            // NewPlayer.LVUP();

            // NewPlayer.SetHP(1000);

            // 외부의 값을 받아서 객체가 내부의 상태를 변화시키기 위해서 함수를 선언하는 경우가 많음
            // NewPlayer.Damage1(10);
            // NewPlayer.Damage2(10, 20);

            Console.WriteLine(NewPlayer.GetLv());
            Console.WriteLine(NewPlayer.DamageToHPReturn(50));
        }
    }
}
