using UnityEngine;
using UnityEngine.UI;

public class AudioButtons : MonoBehaviour
{
    public Button closeButton;
    
    private void Awake()
    {
        closeButton.GetComponent<Button>().onClick.AddListener(ToggleActive);
    }

    private void ToggleActive()
    {
        Debug.Log("b");
        GetComponentInParent<AudioMaster>().ToggleActive();
    }
}