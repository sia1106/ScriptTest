using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    //発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
    //int型の変数mpを宣言し、53で初期化してください
    private int mp = 53;
    private int mplost = 5;//消費MP

    //mpを消費して魔法攻撃をするMagic関数を作ってください
    //Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
    //mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください

    public void Magic()
    {
        if (mp >= mplost) //現在MPが消費MP以上ならば成功
        {
            this.mp -= mplost;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class UseMagic : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();

        //Magic関数を呼び出して、魔法を使ってください
        //Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください

        for (int i = 1; i <= 11; i++) {
            Debug.Log("-----" + i + "回目-----"); //見づらいので
            lastboss.Magic(); //消費MP5の魔法を11回使う
        }
    }

}