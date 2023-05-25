using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class PlayerValueController : MonoBehaviour
{

    /// <summary>�X���C�_�[</summary>
    [SerializeField] Slider _heathSlider;

    /// <summary>���G���� </summary>
    [SerializeField] private float _invincibleTime = 5;
    /// <summary> ���G���[�h�t���O</summary>
    private bool _isInvincible;
    
    private Animator _anim;  
    private float time;

    /// <summary>�X�R�A</summary>
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
    /// ���G���[�h
    /// </summary>
    void Muteki()
    {
        if (_isInvincible)
        {
            Debug.Log("���G���[�h�J�n");
            time += Time.deltaTime;

            _anim.SetBool("aaa",true);

            if (time >= _invincibleTime)
            {
                Debug.Log("���G���[�h�I��");
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
