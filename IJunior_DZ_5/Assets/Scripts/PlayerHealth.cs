using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private UnityEvent _clicked;
    [SerializeField] private Button _regenerationButton;
    [SerializeField] private Button _damageButton;

    private float _maxHealth = 100f;
    private float _minHealth = 0f;
    private float _deltaTuning = 10f;

    private void Start()
    {
        _regenerationButton.onClick.AddListener(Regeneration);
        _damageButton.onClick.AddListener(DoDamage);
    }

    public float HealthCount()
    {
        return _health;
    }

    private void Regeneration()
    {
        if (_health < _maxHealth)
        {
            _health = Mathf.MoveTowards(_health, _maxHealth, _deltaTuning);
            _clicked?.Invoke();
        }
    }

    private void DoDamage()
    {
        if (_health > _minHealth)
        {
            _health = Mathf.MoveTowards(_health, _minHealth, _deltaTuning);
            _clicked?.Invoke();
        }
    }
}
