using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai
{
    int[] array = { 20, 55, 11, 7, 16 };
    public void Zyun()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    public void Gyaku()
    {
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

}

public class Boss
{
    int mp = 53;
    //magic関数
    //(int mp)はマジックの消費voidスタートを入れる

    public void Magic(int needmp)
    {
        
        if (mp >= needmp)
        {
            mp -= needmp;
            Debug.Log("魔法攻撃をした。残りMPは"+mp+"。");
            
            
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
        
    }
 }



public class Test : MonoBehaviour
{



    void Start()
    {
        kadai suuzi = new kadai();
        suuzi.Zyun();
        suuzi.Gyaku();
        //Magicクラスを呼び出して魔法を使う
        Boss magic = new Boss();
        //Magic関数を呼び出して使う
        //（５）はマジックの消費が書かれている。
        magic.Magic(5);
      
        for (int i = 0; i <10; i++)
        {

            magic.Magic(5);

        }
        

    }


















    //valに代入する値を条件によって変える










    // Update is called once per frame
    void Update()
    {

    }

}