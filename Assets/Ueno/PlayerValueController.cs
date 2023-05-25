using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class PlayerValueController : MonoBehaviour
{

    /// <summary>スライダー</summary>
    [SerializeField] Slider _heathSlider;

    /// <summary>無敵時間 </summary>
    [SerializeField] private float _invincibleTime = 5;
    /// <summary> 無敵モードフラグ</summary>
    private bool _isInvincible;
    
    private Animator _anim;  
    private float time;

    /// <summary>スコア</summary>
    private float _timeScore = 0;
    public float Score
    {
        get
        {
            return _timeScore;
        }
        set
        {
            _timeScore = value;
        }
    }

    private int _health = 100;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _heathSlider = _heathSlider.gameObject.GetComponent<Slider>();
        _heathSlider.maxValue = 100;
        _heathSlider.value = 100;

        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Muteki();
    }

    /// <summary>
    /// 無敵モード
    /// </summary>
    void Muteki()
    {
        if (_isInvincible)
        {
            Debug.Log("無敵モード開始");
            time += Time.deltaTime;

            _anim.SetBool("aaa",true);

            if (time >= _invincibleTime)
            {
                Debug.Log("無敵モード終了");
                time = 0;
                _isInvincible = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Invincible")
        {
            _isInvincible = true;
        }
    }
}
