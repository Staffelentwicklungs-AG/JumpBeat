using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenueSystem : MonoBehaviour
{
    [SerializeField] private string gameSceneName;

    public void StartGamePressed() 
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void OptionsPressed()
    {
        
    }
    public void QuitPressed()
    {
#if Unity_Editor
            SceneManager.QuitSceneAsync();  
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }

}
