using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour {
    
    void Start() {        
        //課題：配列を宣言して出力しましょう
        //条件１：要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[]array = { 1, 2, 3, 4, 5};
        int num = array.Length; //要素数を取得しておく
        int temp;  //インデックスを指定する変数

        //条件２：for文を使い、配列の各要素の値を順番に表示してください
        Debug.Log("全ての要素を順番に表示します");
        for (int i = 0; i < num; i++) {
            Debug.Log(array[i]);
        }

        //条件３：for文を使い、配列の各要素の値を逆順に表示してください
        //要素を追加しても対応できるようにした
        Debug.Log("逆順に表示します");
        for (int i=0; i < num; i++) {       
            temp = num -1 -i; //要素数ｰ1(最後尾)から始めて1ずつ減っていく
            Debug.Log(array[temp]);
        }
        Debug.Log("おわり");
    }
    	
}