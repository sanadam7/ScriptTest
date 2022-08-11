using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発展課題（クラス）
public class Boss
{
    private int hp = 100;        //体力
    private int power = 25;  //攻撃力
    private int mp = 53;        //魔力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数
    public void Magic()
    {
        if(this.mp >= 5)
        {
            //mp5以上の時
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            //mpが足りない時
            Debug.Log("MPが足りない為、魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        //通常課題
        //要素数5の配列を初期化
        int[] array = { 10, 20, 30, 40, 50 };
        //順番に表示
        for(int i = 0;i<array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //逆順に表示
        for (int i = 4 ; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //魔法用の関数を呼び出す
        lastboss.Magic();

        //魔法を10回使う
        for(int i = 0; i< 10; i++)
        {
            lastboss.Magic();
        }

    }

		// Update is called once per frame
		void Update()
    {
        
    }
}
