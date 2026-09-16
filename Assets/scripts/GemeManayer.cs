using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject opcionMenuPanel;
    [SerializeField] private GameObject opcionPanelPrincipal;


    public void OptionsMenu()
    {
        mainMenuPanel.gameObject.SetActive(false);
        opcionMenuPanel.gameObject.SetActive(true);
    }

    public void Menuprincipal()
    {
        mainMenuPanel.gameObject.SetActive(false);
        opcionMenuPanel.gameObject.SetActive(true);
    }

}

