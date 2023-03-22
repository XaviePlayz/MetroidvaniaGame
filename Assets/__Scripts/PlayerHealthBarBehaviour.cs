using UnityEngine;
using UnityEngine.UI;
public class PlayerHealthBarBehaviour : MonoBehaviour
{
    public Slider Slider;
    public Color Low;
    public Color High;

    public void SetPlayerHealth(float health, float maxHealth)
    {
        Slider.maxValue = maxHealth;
        Slider.value = health;

        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }
}
