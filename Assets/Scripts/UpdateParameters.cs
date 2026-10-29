using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Oculus.Haptics;

public class UpdateParameters : MonoBehaviour
{

    public Slider amplitudeSlider;
    public TMP_Text amplitudeValueText;

    public Slider frequencySlider;
    public TMP_Text frequencyValueText;

    public Slider prioritySlider;
    public TMP_Text priorityValueText;

    public HapticSource hapticSource;


    private void Start()
    {
        // Initialize the text values based on the sliders' initial values
        UpdateAmplitudeText(amplitudeSlider.value);
        UpdateFrequencyText(frequencySlider.value);
        UpdatePriorityText(prioritySlider.value);

        // Add listeners to update the text when the slider values change
        amplitudeSlider.onValueChanged.AddListener(UpdateAmplitudeText);
        frequencySlider.onValueChanged.AddListener(UpdateFrequencyText);
        prioritySlider.onValueChanged.AddListener(UpdatePriorityText);
    }

    private void UpdateAmplitudeText(float value)
    {
        hapticSource.amplitude = value;
        amplitudeValueText.text = value.ToString("F2");
    }

    private void UpdateFrequencyText(float value)
    {
        hapticSource.frequencyShift = value;
        frequencyValueText.text = value.ToString("F2");
    }

    private void UpdatePriorityText(float value)
    {
        hapticSource.priority = (uint)value;
        priorityValueText.text = hapticSource.priority.ToString("F0");
    }

}
