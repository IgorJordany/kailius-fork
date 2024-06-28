using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D plyr) {
        if (plyr.gameObject.tag == "Player") {
            RequestQuestion();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
    [DllImport("__Internal")]
    private static extern void TriggerQuestion();

    private void RequestQuestion()
    {
   
#if UNITY_WEBGL == true && UNITY_EDITOR == false
	PauseGame();
    TriggerQuestion();
#endif
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.volume = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

    public void MuteAllSound()
    {
        AudioListener.volume = 0;
    }

    public void UnMuteAllSound()
    {
        AudioListener.volume = 1;
    }
        

}
