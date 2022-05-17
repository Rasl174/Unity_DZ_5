using UnityEngine;
using UnityEngine.UI;

public class HealthBarTuning : MonoBehaviour
{
    [SerializeField] private Image _healthBarImage;
    [SerializeField] private PlayerHealth _playerHealth;

    private float _correctRendererBar = 0.01f;

    private void Start()
    {
        _healthBarImage.fillAmount = _playerHealth.HealthCount() * _correctRendererBar;
    }

    public void OnButtonClick()
    {
        _healthBarImage.fillAmount = _playerHealth.HealthCount() * _correctRendererBar;
    }
}
