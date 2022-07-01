using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemBox : MonoBehaviour
{
    public static ItemBox instance;
    public static List<ItemScript> items = new List<ItemScript>();

    

            
            
         

    


//Itemリストを異なるスクリプトから操作する為のもの
    public void Additem(ItemScript item){
        ItemBox.items.Add(item);
        List<ItemScript> uniqueItem = ItemBox.items.Distinct().ToList();
        ItemBox.items = uniqueItem;
    }
    public void Removeitem(ItemScript item){
        ItemBox.items.Remove(item);
    }


    //シングルトン化
    void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
}
