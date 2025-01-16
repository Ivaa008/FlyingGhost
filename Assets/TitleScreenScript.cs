using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    // This function is triggered when the "Play" button is clicked
    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // This function is triggered when the "Quit" button is clicked
    public void QuitButton()
    {
        Debug.Log("Quit Game"); // For testing purposes in the editor
        Application.Quit();     // Quits the application (only works in builds, not in the editor)
    }
}
