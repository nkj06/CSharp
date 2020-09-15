using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * RPG를 만든다 -> 프로젝트 만든다
 * 주인공이 있다 -> 클래스
 * 주인공이 공격력이 있다 -> 멤버변수
 * 주인공이 공격력으로 때린다 -> 멤버함수
 */

class Player
{
    // 명사만으로는 부족
    int ATT;
    int Hp;

    /*
     * 행동으로 나타나게 되는 것 표현하는 것이 멤버 함수
     */

    /*리턴값*/ void /*리턴값*/ Move /*인자값*/()
    { // <- 함수 시작

    } // <- 함수의 끝

    void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.");
    }

    void Talk()
    {

    }
}