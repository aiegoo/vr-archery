using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weponSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    // we can use Destroy same object 
}
