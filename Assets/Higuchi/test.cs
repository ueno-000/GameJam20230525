using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {

        
        Debug.Log(1);
        IddDamage aiai = other.gameObject.GetComponent<IddDamage>();
        if (aiai != null)
        {
            aiai.Idddamage(7);
        }
        }
    }
   
}

