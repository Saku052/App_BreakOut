using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //変数宣言
    private GameObject Manager;
    private float touchPositionx;
    private bool ActiveState;
    [SerializeField] private float diviser = 240.0f;
    

    private void Start(){
        //ゲームマネージャーのゲームオブジェクトの取得
        this.Manager = GameObject.Find("GameManager");
    }

    private void Update(){

        //ゲームオーバーになったら動きを止める
        this.ActiveState = this.Manager.GetComponent<GameManager>().activeStateEnd;


        //タップされた位置を取得する
        if(Input.GetMouseButton(0) && !this.ActiveState){
        this.touchPositionx = (Input.mousePosition.x - 540.0f)/this.diviser;
        }
        gameObject.transform.position = new Vector3(this.touchPositionx, -3, 0);
    }
}
