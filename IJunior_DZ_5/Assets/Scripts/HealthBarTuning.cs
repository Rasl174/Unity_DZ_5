using UnityEngine;
using UnityEngine.UI;

public class HealthBarTuning : MonoBehaviour
{
    [SerializeField] private Image _healthBarImage;

    private float _deltaTuning = 0.1f;
    private float _maxHealth = 1f;
    private float _minHealth = 0f;

    public void Regeneration()
    {
        if (_healthBarImage.fillAmount < 1)
            _healthBarImage.fillAmount = Mathf.MoveTowards(_healthBarImage.fillAmount, _maxHealth, _deltaTuning);
    }

    public void DoDamage()
    {
        if (_healthBarImage.fillAmount > 0)
            _healthBarImage.fillAmount = Mathf.MoveTowards(_healthBarImage.fillAmount, _minHealth, _deltaTuning);
    }
}
