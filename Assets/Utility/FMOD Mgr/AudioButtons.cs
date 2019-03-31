using UnityEngine;
using UnityEngine.UI;

public class AudioButtons : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(ToggleActive);
    }

    private void ToggleActive()
    {
        GetComponentInParent<AudioMaster>().ToggleActive();
    }
}