using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _maxHealth = 100f;
    private float _minHealth = 0f;
    private float _deltaTuning = 10f;

    public float HealthCount()
    {
        return _health;
    }

    public void Regeneration()
    {
        if (_health < _maxHealth)
            _health = Mathf.MoveTowards(_health, _maxHealth, _deltaTuning);
    }

    public void DoDamage()
    {
        if (_health > _minHealth)
            _health = Mathf.MoveTowards(_health, _minHealth, _deltaTuning);
    }
}
