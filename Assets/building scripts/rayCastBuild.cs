using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class rayCastBuild : MonoBehaviour
{
    public Camera rayCamera;
     RaycastHit hit;
     public GameObject blockk;

    private GameObject[] stack = new GameObject[40];
    private int index=0;
    // Start is called before the first frame update
    private GameObject playerBox;
    void Start()
    {  
       playerBox = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
         Ray ray = rayCamera.ScreenPointToRay(Input.mousePosition);
         Debug.DrawRay(ray.origin,ray.direction,Color.blue);
         if(Physics.Raycast(ray,out hit)){
            if(Input.GetMouseButtonDown(0)){
                //getcurrentblock
                //place block  
                placeBlock(hit.point,hit.collider.gameObject,blockk);
            }
         }
        if (Input.inputString == "\b"){
            deleteLastBlock();
        } 
        if(Input.inputString =="g"){
            playerBox.GetComponent<Rigidbody>().useGravity = true;
        }   
    }
    void placeBlock(Vector3 hit, GameObject anchor,GameObject placeingBlock){
        if(placeingBlock != null){
            if(index <40){
                Vector3 location = hit - anchor.transform.position; //finds where the hit is relative to the block
                Debug.Log(location);
                Vector3 roundedLocation=new Vector3();
                for(int i = 0; i < 3; i++){
                    float coord = location[i];
                    if(coord<0){
                        coord-=0.01f;
                    }else{
                        coord +=0.01f;    
                    }
                    Debug.Log(coord);
                    coord = Mathf.Round(coord);
                    roundedLocation[i]=coord;
                }
                if(roundedLocation == Vector3.zero) {
                    return;
                }
                Debug.Log(roundedLocation);
                GameObject thing = Instantiate(placeingBlock, anchor.transform.position + roundedLocation, anchor.transform.rotation);
                thing.transform.SetParent(anchor.transform);
                thing.AddComponent<FixedJoint>();
                thing.GetComponent<FixedJoint>().connectedBody = anchor.GetComponent<Rigidbody>();

                stack[index]=thing;
                index+=1;
            }
        }
    }
    void deleteLastBlock(){
        if(index >0){
            GameObject lastblock = stack[index-1];
            Destroy(lastblock);
            index-=1;
        }
    }
}
