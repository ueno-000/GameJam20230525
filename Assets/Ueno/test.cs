using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
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
        Debug.Log(1);
        IddDamage aiai = other.gameObject.GetComponent<IddDamage>();
        if (aiai != null)
        {
            aiai.Idddamage(7);

        }
    }
}
