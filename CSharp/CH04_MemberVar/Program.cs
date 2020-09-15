using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 멤버 변수: 세부 속성이면서 명사이면서 값
    // 초기값을 넣어줄 수 있다. (리터럴값)

    // int(자료형) 이름(식별자)
    // 크기 : 4바이트
    // 형태 : 정수
    // 위치 : Gold -> 18923671622 , Att -> 90
    // int Att 램에 90번지에 4바이트만큼의 공간을 할당

    int Gold = 10;
    int Exp = 1000;
    int Att = 300; 
    int Def = 100;
    int Hp = 400;

    bool IsFight;
}