using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBarTuning : MonoBehaviour
{
    [SerializeField] private Image _healthBarImage;
    [SerializeField] private PlayerHealth _playerHealth;

    private float _speedRendererChanger = 1f;
    private float _correctRendererBar = 0.01f;

    private void Start()
    {
        _healthBarImage.fillAmount = _playerHealth.HealthCount() * _correctRendererBar;
    }

    public void OnButtonClick()
    {
        StartCoroutine(SmoothChanger(_playerHealth.HealthCount() * _correctRendererBar));
    }

    private IEnumerator SmoothChanger(float target)
    {
        while(_healthBarImage.fillAmount != target)
        {
            _healthBarImage.fillAmount = Mathf.MoveTowards(_healthBarImage.fillAmount, target, _speedRendererChanger * Time.deltaTime);
            yield return null;
        }
    }
}
