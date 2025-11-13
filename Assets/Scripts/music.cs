using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;


public class music : MonoBehaviour
{
    public AudioSource musicSource;
    public float fadeDuration = 1.5f;

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene arg0, LoadSceneMode arg1)
    {
        throw new NotImplementedException();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Game") // Replace with your actual game scene name
        {
            StartCoroutine(FadeOutMusic());
        }
    }

    private string FadeOutMusic()
    {
        throw new NotImplementedException();
    }

    IEnumerator FadeInMusic()
    {
        musicSource.volume = 0;
        musicSource.Play();

        while (musicSource.volume < 1f)
        {
            musicSource.volume += Time.deltaTime / fadeDuration;
            yield return null;
        }


        IEnumerator FadeOutMusic()
        {
            float startVolume = musicSource.volume;

            while (musicSource.volume > 0)
            {
                musicSource.volume -= startVolume * Time.deltaTime / fadeDuration;
                yield return null;
            }

            musicSource.Stop();
            Destroy(gameObject); // Clean up after fade
        }




    }
}
