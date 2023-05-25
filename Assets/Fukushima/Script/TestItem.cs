using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem : MonoBehaviour
{

    public AudioClip _scream;
    public AudioClip _eat;
    public int _speed = 5;
    public float deleteTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,deleteTime);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * _speed, 0);
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ìñÇΩÇ¡ÇƒÇÈ");
        //"Å@"ì‡ÇplayerÇÃobjectñºÇ…ïœçXÇµÇƒÇ≠ÇæÇ≥Ç¢ 
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("TestPlayerÇ…ìñÇΩÇ¡ÇƒÇÈ");
            Iitem _item = collision.gameObject.GetComponent<Iitem>();
            if (_item != null)
            {
                AudioSource.PlayClipAtPoint(_eat,this.transform.position);
                _item.AddHP(5);
                Debug.Log("HP + 5");
                AudioSource.PlayClipAtPoint(_scream,this.transform.position);
                Destroy(this.gameObject);
            }
        }
    }
}
