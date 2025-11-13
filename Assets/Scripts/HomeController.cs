using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;



public class HomeController : MonoBehaviour
{
    public AudioSource clickSound;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Script started.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClicked()
    {
        Debug.Log("Start button clicked!");
        clickSound.Play();
        StartCoroutine(LoadSceneAfterSound());
    }

    IEnumerator LoadSceneAfterSound()
    {
        yield return new WaitForSeconds(clickSound.clip.length);
        Debug.Log("Loading Game scene...");
        SceneManager.LoadScene(Scene.Game);
    }
}
