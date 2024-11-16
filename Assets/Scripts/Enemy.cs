using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float health = 100f;

    [SerializeField] private Slider sliderHealth;
    [SerializeField] private Image sliderFill;
    [SerializeField] private Gradient sliderFillColour;
        
    // Start is called before the first frame update
    void Start()
    {
        sliderHealth.maxValue = health;
        sliderHealth.value = health;
    }

    public void TakeDamage(float damage)
    {
        if (health > damage)
        {
            health -= damage;
        }
        else
        {
            health = 0f;
            Die();
        }
        UpdateSlider();
    }

    private void Die()
    {
        Destroy(gameObject,.3f);
    }

    private void UpdateSlider()
    {
        sliderHealth.value = health;
        //change fill color
        sliderFill.color = sliderFillColour.Evaluate(sliderHealth.normalizedValue);
    }
}
