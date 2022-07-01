using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Buttons : MonoBehaviour
{
    //初手SetActive(false)にするゲームキャンバスの定義
    private GameObject itemBox;
    private GameObject selectLevel;
    private GameObject itemInfo;
    //メインシーンの透明度を変える為のキャンバス変更変数
    private CanvasGroup menuBrightness;
    
    private void Start(){
        //基本オブジェクトの取得
        this.itemBox = GameObject.Find("itemBox");
        this.itemInfo = GameObject.Find("ItemInfo");
        this.selectLevel = GameObject.Find("ChooseLevel");
        this.menuBrightness = GameObject.Find("playerInfo").GetComponent<CanvasGroup>();

        //キャンバスをまとめ初手非表示にする魔法
        this.itemBox.SetActive(false);
        this.itemInfo.SetActive(false);
        this.selectLevel.SetActive(false);
    }

    //itemBox用のOpen/Closeメソッド
    //itemBoxを表示してメインシーンの明度を低く設定する
    public void itemClick(){
        this.itemBox.SetActive(true);
        this.menuBrightness.alpha = 0.2f;
    }
    public void closeClick(){
        this.itemInfo.SetActive(false);
        this.itemBox.SetActive(false);
        this.menuBrightness.alpha = 1.0f;
    }

    //selectLevel用のOpen/Closeメソッド
    //selectLevelを表示して非表示にするメソッド
    public void clickLevel(){
        this.selectLevel.SetActive(true);
    }
    public void closeLevel(){
        this.selectLevel.SetActive(false);
    }

    //プライバシーポリシーのリンクを発動させる
    public void PrivacyPoButton()
    {
        Application.OpenURL("https://saku052.github.io/PrivacyPolicy/");
    }
}
