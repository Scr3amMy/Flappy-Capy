using UnityEngine;


public class MusicController : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject); // Keeps music alive across scenes
    }
}
