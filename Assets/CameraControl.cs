using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Vector3 localRot;
    private Vector3 zoomScale;
    private Vector3 minZoom;
    private Vector3 maxZoom;

    [SerializeField] Transform focus;
    [SerializeField] float MouseSpeed = 2.5f;
    [SerializeField] float minSize = 1f;
    [SerializeField] float maxSize = 6f;
    [SerializeField] float zoomSpeed = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 defaultVec = new Vector3(1f, 1f, 1f);
        zoomScale = defaultVec;
        minZoom = defaultVec * minSize;
        maxZoom = defaultVec * maxSize;
    }

    // Update is called once per frame


    void Update()
    {
        transform.position = focus.position;

        if(Input.GetMouseButton(0))
        {
            float xRotation = Input.GetAxis("Mouse X") * MouseSpeed;
            float yRotation = Input.GetAxis("Mouse Y") * MouseSpeed;

            transform.rotation *= Quaternion.Euler(-yRotation, xRotation, 0);
            float z = transform.eulerAngles.z;
            transform.Rotate(0, 0, -z);
        }

        if(Input.GetKey(KeyCode.Q) && (transform.localScale.magnitude < maxZoom.magnitude))
        {
            transform.localScale += zoomScale * zoomSpeed;
        }
        if(Input.GetKey(KeyCode.E) && (transform.localScale.magnitude > minZoom.magnitude))
        {
            transform.localScale -= zoomScale * zoomSpeed;
        }


    }
}
