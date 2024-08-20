using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorySystem : MonoBehaviour
{
    // Start is called before the first frame update

    public inventoryStack[] inventory = new inventoryStack[10];
    private int slot = 0;
    public int currentSlot = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addStack(inventoryStack stack){
        inventory[slot]= stack;
        slot++;
    }
    public inventoryStack getCurrentItemStack(){
        return inventory[currentSlot];
    }
}
