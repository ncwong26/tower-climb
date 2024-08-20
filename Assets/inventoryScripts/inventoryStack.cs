using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class inventoryStack
{
    // Start is called before the first frame update
    private inventoryItem item;

    private int stackAmount;
    public int stackAmnt{
        get{return stackAmount;}
        set{stackAmount = value;}
    }

    public inventoryStack(inventoryItem item,int amount){
        this.item = item;
        this.stackAmount = amount;
    }
    public void addAmount(int amount){
        stackAmount += amount;

    }
    public inventoryItem getItem(){
        if (stackAmount >0){
            return item;
        }
        else{
            return null;
        }
    }
    
}
