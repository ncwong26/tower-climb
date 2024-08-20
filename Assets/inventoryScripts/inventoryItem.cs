using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New inventoryItem", menuName = "ScriptableObjects/data", order = 1)]
public class inventoryItem : ScriptableObject{
    // Start is called before the first frame update
    public GameObject prefab;
    public int id;
    
}
