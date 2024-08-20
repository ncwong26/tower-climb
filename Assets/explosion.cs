using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bomb;
    public float power = 10.0f;
    public float radius = 8.0f;
    public float upforce = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (bomb == enabled)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Invoke("Detonate", 1);
            }

        }
    }
    void Detonate ()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.AddExplosionForce(power, explosionPosition, radius, upforce, ForceMode.Impulse);
            }
        }
    }
}
