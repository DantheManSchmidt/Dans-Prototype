using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    GameObject pickableObject;
    public GameObject PickableObject { get { return PickableObject; } }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OntriggerEnter(Collider other)
    {
        pickableObject = other.gameObject;
    }
}
