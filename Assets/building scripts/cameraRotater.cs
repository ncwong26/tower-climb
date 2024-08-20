using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotater : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed=2;


private float Horizontal;
private float Vertical;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() {

    Horizontal += -Input.GetAxis("Horizontal")*speed;
    Vertical += Input.GetAxis("Vertical")*speed;

    //Vector3 rotate = new Vector3 (Vertical,-Horizontal,zaxis);
    Quaternion qt = Quaternion.Euler(Vertical,Horizontal,0f);
    transform.rotation = Quaternion.Lerp(transform.rotation, qt, Time.deltaTime*5f);

    // rigid.AddTorque (rotate * speed);
    
    }

}
