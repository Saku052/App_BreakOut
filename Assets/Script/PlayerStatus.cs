using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class PlayerStatus : MonoBehaviour
{
    //シングルトンなインスタンスを定義
   public static PlayerStatus instance;

   //Staticな変数をここで宣言
   private static int plDMG = 1;
   private static int plTime = 60;
   private static Sprite plWeapon = null;

   //呼び出すゲームオブジェクトの定義
   private GameObject showItem;
   private GameObject DisplayStatus;

   //装備したItemをメインメニューで標準するゲームオブジェクトの取得
    private void Start()
    {
        this.showItem = GameObject.Find("ItemShow");
        this.DisplayStatus = transform.GetChild(2).gameObject;

        DisplayItemInfo();
    }

    //必要なItem情報を取得する
    public void getItemStatusInfo(ItemScript item)
    {
        PlayerStatus.plDMG = item.getdmg();
        PlayerStatus.plTime = item.gettimeLimit();
        PlayerStatus.plWeapon = item.getweapon();

        DisplayItemInfo();
    }


    //取得してあるプレイヤーの情報をメインメニューにまとめて標準するスクリプト
    private void DisplayItemInfo()
    {
        this.DisplayStatus.GetComponentInChildren<Text>().text = "" +
        PlayerStatus.plDMG + "\n" +
        PlayerStatus.plTime;

        this.showItem.GetComponent<Image>().sprite = PlayerStatus.plWeapon;

    }

    //ゲッターの定義
    public int getplDMG(){
        return PlayerStatus.plDMG;
    }
    public int getplTime(){
        return PlayerStatus.plTime;
    }



   //シングルトン化
   private void Awake()
   {
       if(instance == null){
           instance = this;
           DontDestroyOnLoad(gameObject);
       }
       else{
           Destroy(gameObject);
       }
   }
}
