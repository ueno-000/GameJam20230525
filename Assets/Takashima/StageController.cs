using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    [SerializeField] private Transform _startTransfom;
    [SerializeField] private Transform _endTransfom;

    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StaegMove();
    }

    /// <summary>
    /// ステージの移動
    /// </summary>
    private void StaegMove()
    {
        transform.position -= new Vector3(Time.deltaTime * _speed, 0);


        if (transform.position.x <= _endTransfom.position.x)
        {
            transform.position = new Vector3(_startTransfom.position.x, 0);
        }
    }
}
