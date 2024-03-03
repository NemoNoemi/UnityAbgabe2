using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartTextManager : MonoBehaviour
{
    public TextMeshProUGUI startText;
    public Button acceptButton;
    public Button declineButton;
    public GameObject backgroundPanel;

    void Start()
    {
        // Zeige den Text beim Spielstart an
        SetCursorVisibility(true);

        // Pausiere das Spiel
        Time.timeScale = 0f;

        // Setze Funktionen für die Button-Click-Events
        acceptButton.onClick.AddListener(AcceptQuest);
        declineButton.onClick.AddListener(DeclineQuest);
    }

    void AcceptQuest()
    {
        // Verstecke den Text, die Buttons und das Panel
        startText.gameObject.SetActive(false);
        acceptButton.gameObject.SetActive(false);
        declineButton.gameObject.SetActive(false);
        backgroundPanel.SetActive(false);

        // Verstecke den Cursor, wenn der Text verschwindet
        SetCursorVisibility(false);

        // Fortsetzen des Spiels
        Time.timeScale = 1f;
    }

    void DeclineQuest()
    {
        // Verstecke den Text und die Buttons
        startText.gameObject.SetActive(false);
        acceptButton.gameObject.SetActive(false);
        declineButton.gameObject.SetActive(false);

        // Verstecke den Cursor, wenn der Text verschwindet
        SetCursorVisibility(false);

        // Fortsetzen des Spiels
        Time.timeScale = 1f;
    }

    // Methode, um den Cursor zu steuern
    private void SetCursorVisibility(bool isVisible)
    {
        Cursor.visible = isVisible;
    }
}
