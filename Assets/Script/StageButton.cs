using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageButton : MonoBehaviour
{
    [SerializeField]private GameObject level2;
    [SerializeField]private GameObject level3;
    [SerializeField]private GameObject level4;
    [SerializeField]private GameObject level5;
    private int numOfItem;
   
   public void GoTostage1(){
       SceneManager.LoadScene("Stage1");
   }
   public void GoTostage2(){
       SceneManager.LoadScene("Stage2");
   }
   public void GoTostage3(){
       SceneManager.LoadScene("Stage3");
   }
   public void GoTostage4(){
       SceneManager.LoadScene("Stage4");
   }
   public void GoTostage5(){
       SceneManager.LoadScene("Stage5");
   }

   private void Start()
   {
       //レベル2~Maxまでのボタンの状態をdisableにする
       this.level2.GetComponent<Button>().interactable = false;
       this.level3.GetComponent<Button>().interactable = false;
       this.level4.GetComponent<Button>().interactable = false;
       this.level5.GetComponent<Button>().interactable = false;

        //取得済みのアイテムの数をここで取得
       this.numOfItem = ItemBox.items.Count;

        //獲得したアイテムの数に応じてステージが開放されていく
       if(this.numOfItem >= 1){
           this.level2.GetComponent<Button>().interactable = true;
       }
       if(this.numOfItem >= 2){
           this.level3.GetComponent<Button>().interactable = true;
       }
       if(this.numOfItem >= 3){
           this.level4.GetComponent<Button>().interactable = true;
       }
       if(this.numOfItem >= 4){
           this.level5.GetComponent<Button>().interactable = true;
       }
   }
}
