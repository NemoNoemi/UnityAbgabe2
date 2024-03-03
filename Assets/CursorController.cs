using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorController : MonoBehaviour
{
    private bool cursorVisible = true;

    // Referenz auf das PauseMenu-Skript
    public PauseMenu pauseMenu;

    private void Start()
    {
        SetCursorVisibility(false);
    }

    private void Update()
    {
        // Überprüfe, ob das Pausenmenü geöffnet ist
        if (PauseMenu.GameIsPaused)  // Änderung hier
        {
            // Setze den Cursor im Pausenmenü sichtbar
            SetCursorVisibility(true);
        }
        else
        {
            // Überprüfe, ob der Spieler das Pausenmenü verlassen hat oder das Spiel fortsetzt
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (cursorVisible)
                {
                    SetCursorVisibility(false);
                }
                else
                {
                    SetCursorVisibility(true);
                }
            }
        }
    }

    private void SetCursorVisibility(bool isVisible)
    {
        Cursor.visible = isVisible;
        cursorVisible = isVisible;
    }
}
