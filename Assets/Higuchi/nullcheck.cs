using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nullcheck : MonoBehaviour,IddDamage
{
    public int HP;

    public void Idddamage(int damage)
    {
       HP -= damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
}
