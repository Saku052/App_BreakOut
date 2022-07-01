using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPrefab : MonoBehaviour
{
    //インスペクターに表示するENEMYHP
    public int EnemyHp;

    //GameManagerから呼び出す敵の数を表す数字
    public GameManager NumberOfEnemyFromManager;
    
    //プレイヤーの攻撃
    private int PlayerDmg = 0;

    private void Start(){
        GetComponentInChildren<Text>().text = this.EnemyHp.ToString();

        this.NumberOfEnemyFromManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        this.NumberOfEnemyFromManager.NumberOfEnemy +=1;
        this.PlayerDmg = this.NumberOfEnemyFromManager.PlayerKougeki;
    }


    //ボールが当たった事を知らせるスクリプト
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball"){
           
            this.EnemyHp -= this.PlayerDmg;
        }

        GetComponentInChildren<Text>().text = this.EnemyHp.ToString();

        //敵のHPがゼロになったら消えるスクリプト
        if(this.EnemyHp <= 0){
            this.NumberOfEnemyFromManager.NumberOfEnemy -=1;

            Destroy(this.gameObject);
        }
    }

    
}
