using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TextMeshProUGUI volumeText;

    void Start()
    {
        volumeSlider.onValueChanged.AddListener((v) =>
        {
            volumeText.text = v.ToString("0.00");
            if (!PlayerPrefs.HasKey("musicVolume"))
            {
                PlayerPrefs.SetFloat("musicVolume", 1);
                Load();
            }
            else
            {
                Load();
            }
        });
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
