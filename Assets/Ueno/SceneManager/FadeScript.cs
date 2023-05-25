using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �t�F�[�h�A�E�g����
/// </summary>
public class FadeScript : MonoBehaviour
{
    private static FadeScript instance = default;

    /// <summary>�t�F�[�h������摜</summary>
    [Header("�A�^�b�`�������"),
        Tooltip("�t�F�[�h������摜"), SerializeField]
    private Image _fadePanel = default;

    /// <summary>�t�F�[�h�̎���</summary>
    [Header("�e��ύX�l"),
        Tooltip("�t�F�[�h�̎���"), SerializeField]
    private float _fadeSpeed = 1f;
    /// <summary>�t�F�[�h�J�n���̐F</summary>
    [Tooltip("�t�F�[�h�J�n���̐F"), SerializeField] private Color _fadeColor = Color.black;

    private void Awake()
    {
        instance = this;
        _fadePanel.gameObject.SetActive(false);
    }

    /// <summary>
    /// �t�F�[�h�C����ɃA�N�V��������
    /// </summary>
    /// <param name="action"></param>
    public static void StartFadeIn(Action action = null)
    {
        if (instance == null)
        {
            action?.Invoke();
            return;
        }
        instance.StartCoroutine(instance.FadeIn(action));
    }

    /// <summary>
    /// �t�F�[�h�A�E�g��ɃA�N�V��������
    /// </summary>
    /// <param name="action"></param>
    public static void StartFadeOut(Action action = null)
    {
        if (instance == null)
        {
            action?.Invoke();
            return;
        }
        instance.StartCoroutine(instance.FadeOut(action));
    }
    public static void StartFadeOutIn(Action outAction = null, Action inAction = null)
    {
        if (instance == null)
        {
            outAction?.Invoke();
            inAction?.Invoke();
            return;
        }
        instance.StartCoroutine(instance.FadeOutIn(outAction, inAction));
    }



    private IEnumerator FadeOutIn(Action outAction, Action inAction)
    {
        yield return FadeOut(outAction);
        yield return FadeIn(inAction);
    }
    private IEnumerator FadeIn(Action action)
    {
        _fadePanel.gameObject.SetActive(true);
        yield return FadeIn();
        action?.Invoke();
        _fadePanel.gameObject.SetActive(false);
    }
    private IEnumerator FadeOut(Action action)
    {
        _fadePanel.gameObject.SetActive(true);
        yield return FadeOut();
        action?.Invoke();
    }
    private IEnumerator FadeIn()
    {
        float clearScale = 1f;
        Color currentColor = _fadeColor;
        while (clearScale > 0f)
        {
            clearScale -= _fadeSpeed * Time.deltaTime;
            if (clearScale <= 0f)
            {
                clearScale = 0f;
            }
            currentColor.a = clearScale;
            _fadePanel.color = currentColor;
            yield return null;
        }
    }
    private IEnumerator FadeOut()
    {
        float clearScale = 0f;
        Color currentColor = _fadeColor;
        while (clearScale < 1f)
        {
            clearScale += _fadeSpeed * Time.deltaTime;
            if (clearScale >= 1f)
            {
                clearScale = 1f;
            }
            currentColor.a = clearScale;
            _fadePanel.color = currentColor;
            yield return null;
        }
    }
}
