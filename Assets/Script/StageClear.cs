using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    private ItemScript item;
    [SerializeField]
    private List<ItemScript> itemlist;
    [SerializeField]
    private string SceneName;
    

    private void Start(){
        //DestoryしなかったITEMBOXインスタンスを直接持ってくる事ができる
        itemlist = ItemBox.items;
        SceneName = SceneManager.GetActiveScene().name.Replace("Stage", "");

        item = Resources.Load<ItemScript>("ItemList/Item" + SceneName);
        
        gameObject.transform.GetChild(2).GetComponent<Image>().sprite = item.getweapon();
    }
    
    
    public void Clearitemget(){
            ItemBox.instance.Additem(item);
            
    }
}
