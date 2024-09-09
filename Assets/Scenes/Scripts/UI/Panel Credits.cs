using UnityEngine;
using UnityEngine.UI;


public class CreditsPanel : MonoBehaviour

{
    [Header("Panels")]
    [SerializeField] public GameObject mainPanel;
    [SerializeField] public  GameObject creditsPanel;
    [SerializeField] private GameObject settingsPanel;


    [Header("Credits")]

    [SerializeField] private Button creditsbackButton;

    //link a PanelMain & SettingsPanel
    PanelMain PanelMain;
    SettingsPanel SettingsPanel;

    private void Awake()
    {
      
        creditsbackButton.onClick.AddListener(OncreditsbackButtonClicked);
 
    }


    private void OnDestroy()
    {
        creditsbackButton.onClick.RemoveListener(OncreditsbackButtonClicked);
    
    }



    private void OnsettingsbackButtonClicked()
    {
        settingsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    private void OncreditsbackButtonClicked()
    {
        creditsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }


}