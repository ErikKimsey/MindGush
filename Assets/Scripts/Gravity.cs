using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float pullRadius = 2;
    public float pullForce = 1;

    public GameObject cube;

    void Start()
    {
      cube = GetComponent<GameObject>();
    }

    void OnTriggerEnter(Collider other)
    {
      
      Vector3 forceDirection = transform.position - other.transform.position;
      Debug.Log(forceDirection);
      other.attachedRigidbody.AddForce(forceDirection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
