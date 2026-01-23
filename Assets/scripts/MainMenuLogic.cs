using UnityEngine;

public class MainMenuLogic : MonoBehaviour
{
    public GameObject mojMeniPanel;

    void Start()
    { 
        Time.timeScale = 0f;
        mojMeniPanel.SetActive(true);
    }

    public void KlikNaPlay()
    {
        mojMeniPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void KlikNaQuit()
    {
        Debug.Log("Igra se gasi...");
        Application.Quit();
        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
