using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "New Item", menuName = "CreateItem")]
public class ItemScript : ScriptableObject
{
    
    //装備が持っているステータス要素
    //玉一つ一つが与えるダメージ量
    //制限時間
    //玉の数
    [SerializeField]
    private string name = "";
    [SerializeField]
    private string info = "";
    [SerializeField]
    private int dmg = 0;
    [SerializeField]
    private int timeLimit = 0;
    [SerializeField]
    private int numTama = 0;
    [SerializeField]
    private Sprite weapon = null;


    //ステータスデータを抜き出す為のゲット関数の定義
    public string getname(){
        return this.name;
    }
    public string getinfo(){
        return this.info;
    }
    public int getdmg(){
        return this.dmg;
    }
    public int gettimeLimit(){
        return this.timeLimit;
    }
    public int getnumTama(){
        return this.numTama;
    }
    public Sprite getweapon(){
        return this.weapon;
    }

    //リアルタイムで攻撃力が変化する処理を行う
    //ブロックが壊されればdmgが上がる等々
    //その為のセッターを定義
    public void setdmg(int dmg){
        this.dmg = dmg;
    }
}
