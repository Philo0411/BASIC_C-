using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "대미지를 입혔다");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "대미지를 입었다");
    }
}

public class Basic : MonoBehaviour
{

    void Start()//"Start"함수는 스크립트가 활성화되는 순간, 모든 Update 메서드의 최초 호출에 앞서 첫 번째 프레임에 호출된다.
    {//무조건 첫번째로 실행 한다
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);


        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);





        
        int age; // int라는 변수 선언 age라는 변식자 생성
        age = 30; // 변식자 age 안에 30이라는 값 대입
        Debug.Log(age); // Debug.Log 로그로 확인할 수 있는 것들


        float height1 = 160.5f; // float라는 변수 선언 height1라는 변식자 생성 과 동시 160.5f 라는 값 대입
        float height2; // float라는 변수 선언 height2라는 변식자 생성
        height2 = height1; // height2안에 height1 대입
        Debug.Log(height2); // height2 로그 출력


        string name; // string라는 변수 선언 name라는 변식자 생성
        name = "Sera"; // 변식자 name 안에 Sera이라는 값 대입
        Debug.Log(name); // name 로그 출력

        // 기본적인 대입 연산
        int answer; // int라는 변수 선언 answer라는 변식자 생성
        answer = 1 + 2; //(1 + 2) 계산후 answer안에 대입 최종 "3"대입
        Debug.Log(answer);// answer 로그 출력

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 8 / 4;
        Debug.Log(answer);
        // 기본적인 대입 연산

        //변수선언후 n1, n2 변식자끼리 사칙연산이 가능하다
        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        //answer = answer + 5
        answer += 5;
        Debug.Log(answer);

        //전치, 후치
        answer++; //++ <- 1더하다
        Debug.Log(answer);

        //문자열또한 변식자끼리 연동 가능하다
        string str1 = "happy ";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);


        //int숫자 문자 1
        string str = "happy ";
        int num = 123;
        message = str + num;
        Debug.Log(message);
        //최종 "happy123" 코딩 문자열로 인식

        //1과 같으니 회복한다
        int herbNum = 1;
        if (herbNum == 1)
        {
            Debug.Log("체력을 50 회복");
        }
        //200보다 크니 공격 한다
        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("공격！");
        }
        else
        {
            Debug.Log("방어！");
        }

        //최종 결과값은 공격
        if (hp <= 50)
        {
            Debug.Log("도망！");
        }
        else if (hp >= 200)
        {
            Debug.Log("공격！");
        }
        else
        {
            Debug.Log("방어！");
        }
        
        //최종 결과값은 1,2
        int x = 1;
        if (x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }


        //반복문 // 1,2,3,4......
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        //최종 값은 2, 4
        for (int i = 0; i < 10; i += 2)
        {
            Debug.Log(i);
        }

        //최종 값은 4, 5....
        for (int i = 3; i <= 5; i++)
        {
            Debug.Log(i);
        }
        //최종 값은 2,1,0
        for (int i = 3; i >= 0; i--)
        {
            Debug.Log(i);
        }

        //결과값은 로그창에서
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);

        //배열 예제 1
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //배열 예제 2
        int[] points = { 83, 99, 52, 93, 15 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
        }

        int sum1 = 0;
        for (int i = 0; i < points.Length; i++)
        {
            sum1 += points[i];
        }

        int average = sum1 / points.Length;
        Debug.Log(average);


        SayHello();
        CallName("Tom");
        answer = Add(2, 3);
        Debug.Log(answer);

    }

    void SayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    void Update()
    {

    }
}
