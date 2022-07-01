using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    private GameObject gameClear;

    private void Start(){
        gameClear = GameObject.Find("GameClearPanel");
    }
    public void TestClick(){
        gameClear.SetActive(true);
    }
}
