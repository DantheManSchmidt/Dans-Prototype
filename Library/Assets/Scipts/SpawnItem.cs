using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{

    public GameObject objectToSpawn;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}

//Credit - John French - https://gamedevbeginner.com/how-to-spawn-an-object-in-unity-using-instantiate/