using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private string activeSceneName;
   
   public void RestartScene(){
       activeSceneName = SceneManager.GetActiveScene().name;
       SceneManager.LoadScene(activeSceneName);
   }

   public void ReturnToMenu(){
       SceneManager.LoadScene("MainScene");
   }

}
