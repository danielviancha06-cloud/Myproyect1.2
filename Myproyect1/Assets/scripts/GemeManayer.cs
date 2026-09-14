using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject opcionMenuPanel;

    public void OptionsMenu()
    {
        mainMenuPanel.gameObject.SetActive(false);
        opcionMenuPanel.gameObject.SetActive(true);
    }
}
