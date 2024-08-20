using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class inventoryStack : MonoBehaviour
{
    // Start is called before the first frame update
    private inventoryItem item;
    private int stackAmount{
        get{return stackAmount;}
        set{stackAmount = value;}
    }
    public void addAmount(int amount){
        stackAmount += amount;

    }
    
    
}
