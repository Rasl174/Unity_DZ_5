using UnityEngine;
using UnityEngine.UI;

public class HealthBarTuning : MonoBehaviour
{
    [SerializeField] private Image _healthBarImage;
    [SerializeField] private PlayerHealth _playerHealth;

    private void Update()
    {
        _healthBarImage.fillAmount = _playerHealth.HealthCount() / 100;
    }
}
