using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//メモ
//このオブジェクトは初手SetActiveではない
public class Itemshow : MonoBehaviour
{

    //必要コンポーネントの定義
    private Transform weaponImage;
    private GameObject itemInfo;
    private GameObject pressedButton;
    private GameObject soubiItem;
    private int Bnum;
    [SerializeField]
    private List<ItemScript> itemlist;
    [SerializeField]
    private EventSystem eventSystem;

    void Start()
    {
        //Itemの情報を表示するスクリプトの取得
        this.itemInfo = transform.GetChild(2).gameObject;
        //非表示にするのはButton.csのスクリプトでまとめてやっている
        
        //DestoryしなかったITEMBOXインスタンスを直接持ってくる事ができる
        itemlist = ItemBox.items;

        //変な白い部分を非表示にするコマンド
        for(int i = 0; i<=4; i++){
            this.weaponImage = transform.GetChild(1).GetChild(i).GetChild(0);
            this.weaponImage.gameObject.SetActive(false);
        }

        //獲得した分だけで表示してアイテム画像を表示するスクリプト
        for(int i = 0; i <= itemlist.Count - 1; i++){
            this.weaponImage = transform.GetChild(1).GetChild(i).GetChild(0);
            this.weaponImage.gameObject.SetActive(true);
            this.weaponImage.gameObject.GetComponent<Image>().sprite = itemlist[i].getweapon();
        }
    }

    public void ItemButton(){
        //押したボタンにどのアイテムが入っていたかを取得するやつ
        this.pressedButton = eventSystem.currentSelectedGameObject;
        string buttonNumber = this.pressedButton.name.Replace("ItemImage", "");
        this.Bnum = int.Parse(buttonNumber) - 1;

        ChangeItemInfo(Bnum);
    }

    private void ChangeItemInfo(int ButtonNum){
        //先ずパネルを表示する
        this.itemInfo.SetActive(true);
        //押されたアイテムの情報をある程度ここに表示する
        this.itemInfo.transform.GetChild(0).GetComponent<Image>().sprite = itemlist[ButtonNum].getweapon();
        this.itemInfo.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = itemlist[ButtonNum].getname();
        this.itemInfo.transform.GetChild(1).GetChild(1).GetComponent<Text>().text = itemlist[ButtonNum].getinfo();

        this.itemInfo.transform.GetChild(2).GetChild(1).GetComponent<Text>().text = "" +
        itemlist[ButtonNum].getdmg() + "dmg\n\n" +
        itemlist[ButtonNum].gettimeLimit() + "秒";
    }

    public void soubi(){

        PlayerStatus.instance.getItemStatusInfo(this.itemlist[this.Bnum]);

        
    }

    
}
