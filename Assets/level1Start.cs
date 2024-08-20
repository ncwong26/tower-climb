using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Start : MonoBehaviour
{
    // Start is called before the first frame update

    public inventoryItem itemOne;
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        inventorySystem invent = player.GetComponent<inventorySystem>();
        invent.addStack(new inventoryStack(itemOne,25));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
