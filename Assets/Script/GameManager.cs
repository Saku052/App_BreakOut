using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    //必要ゲームオブジェクトの定義
    private GameObject TouchToStart;
    private GameObject GameOver;
    private GameObject GameClear;
    private GameObject Ball;
    private GameObject Hpb;
    private Rigidbody2D ballRigid;
    private Vector3 Ballpos;


    //Hpbarに必要なHP管理定数
    private int MaxTime;
    private float NowTime;
    [SerializeField]
    private int ballspeedX = 100;
    [SerializeField]
    private int ballspeedY = 100;

    //キャンバス表示用のboolの定義
    private bool activeStateStart = true;
    public bool activeStateEnd = false;

    //その他のギミックの為の定数
    private int i = 0;
    public int NumberOfEnemy = 0;
    public int PlayerKougeki = 1;
    [SerializeField] private int CorrectForceX;
    [SerializeField] private int CorrectForceY;

    private void Awake()
    {
        //プレイヤーの攻撃力の取得
        this.PlayerKougeki = PlayerStatus.instance.getplDMG();
    }

    private void Start(){
        //ゲームオブジェクトの取得
        this.TouchToStart = GameObject.Find("TouchScreenPanel");
        this.GameOver = GameObject.Find("GameOverPanel");
        this.GameClear = GameObject.Find("GameClearPanel");
        this.Ball = GameObject.Find("Ball");
        this.ballRigid = this.Ball.GetComponent<Rigidbody2D>();
        this.Hpb = GameObject.Find("Hpbar");

        //制限時間変数の取得と定義
        this.MaxTime = PlayerStatus.instance.getplTime();
        this.NowTime = (float)this.MaxTime;
        
        
        //初手非表示にするキャンバスの処理
        this.GameOver.SetActive(this.activeStateEnd);
        this.GameClear.SetActive(false);
    }

    private void Update(){
        //リアルタイムで変化するゲームオブジェクトの取得
        this.Ballpos = this.Ball.transform.position;

        //画面がタップされたら最初のキャンバスを非表示にする
        if(Input.GetMouseButtonDown(0)){
            this.activeStateStart = false;
        }
        this.TouchToStart.SetActive(this.activeStateStart);

        //HPbarを一定時間で減少させるスクリプト
        if(!this.activeStateStart){
            //現在の秒数を計算するスクリプト
            this.NowTime -= Time.deltaTime;
            
            BallConstant();
            PlayBall();
            
        }

        //HPの割合を計算して実際にHPBARの減少の処理を行う
        float hp = this.NowTime/this.MaxTime;
        this.Hpb.GetComponent<Slider>().value = hp;

        openGameClear();

        openGameOver();
        
    }

    //スタックしそうなボールが出た時に多少の力を加える
    private void BallConstant()
    {
        Vector2 ballConst = new Vector2(0, 0);

        if(this.ballRigid.velocity.x < 2.5f && this.ballRigid.velocity.x >= 0){
            ballConst = new Vector2(this.CorrectForceX, 0);
        }
        if(this.ballRigid.velocity.x < 0 && this.ballRigid.velocity.x > -2.5f){
            ballConst = new Vector2(-1*this.ballspeedX, 0);
        }
        if(this.ballRigid.velocity.y < 2.5f && this.ballRigid.velocity.y >= 0){
            ballConst = new Vector2(0, this.CorrectForceY);
        }
        if(this.ballRigid.velocity.y < 0 && this.ballRigid.velocity.y > -2.5f){
            ballConst = new Vector2(0, -1*this.CorrectForceY);
        }



        this.ballRigid.AddForce(ballConst);
    }

    //Ballを動かすスピードのベクトルクラスの定義
    //それを一回だけボタンが押された後に処理する為のスクリプト
    private void PlayBall(){
        if(this.i == 0){
        Vector2 BallForce = new Vector2(Random.Range(-300, 300), ballspeedY);
        this.ballRigid.AddForce(BallForce);
        }

        this.i += 1;
    }


    private void openGameOver(){
        //HPが0以下になった場合GameOverPanelを表示する
        if(this.NowTime <= 0){
            this.activeStateEnd = true;
        }

        //ボールが画面外に出たらGameOverPanelを表示する
        if(this.Ballpos.y <= -5.0f){
            this.activeStateEnd = true;
            this.NowTime = 60.0f;
        }

        //ゲームオーバーならボールを停止させる
        if(this.activeStateEnd){
            this.i = 0;
            this.ballspeedX = -100;
            this.ballspeedY = -100;
        }
        this.GameOver.SetActive(this.activeStateEnd);
    }

    private void openGameClear(){
        if(this.NumberOfEnemy <= 0){
            this.GameClear.SetActive(true);
        }
    }
}
