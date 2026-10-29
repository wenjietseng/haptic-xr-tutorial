using UnityEngine;
using Oculus.Haptics;

public class VibrationOnCollide : MonoBehaviour
{
    public HapticSource hapticSource;

    private void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;
        Debug.Log($"Collision detected with {other.name}.");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collision detected with Player. Triggering haptic feedback.");
            PlayHaptic();
        }
    }

    private void PlayHaptic()
    {
        hapticSource.Play();
    }
}
