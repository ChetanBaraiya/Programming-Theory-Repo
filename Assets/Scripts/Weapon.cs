using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public string name;
    public float damage;
    public int bullets;

    private int defaultBullets;

    [SerializeField] private TMP_Text weapanNameText;
    [SerializeField] private Slider sliderWeapanBullets;

    void Start()
    {
        defaultBullets = bullets;
        sliderWeapanBullets.maxValue = bullets;
        sliderWeapanBullets.value = bullets;
        weapanNameText.text = name;
    }

    public void PerformShot()
    {
        if (bullets > 0)
        {
            bullets--;
            UpdateSlider();
        }
    }

    public void RechargeWeapon()
    {
        if (bullets == 0)
        {
            GameManager.Instance.msgObject.SetActive(false);
            bullets = defaultBullets;
            UpdateSlider();
        }
    }

    public bool HasEnoughBullets()
    {
        return bullets > 0;
    }

    void UpdateSlider()
    {
        sliderWeapanBullets.value = bullets;
    }
}