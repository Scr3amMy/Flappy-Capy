using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class capy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapstrenght;
    public LogicScript LogicScript;
    public bool capyisAlive = true;
    public AudioSource flap;
    public bool hasPlayedHitSound = false;
    public AudioSource hitsound;
    public bool gamestarted = false;
    public GameObject tapToStartUI;
    bool gameStarted = false;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f; // Pause the game

        LogicScript = GameObject.FindGameObjectWithTag("LOGIC").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        bool clicked = Mouse.current != null &&
                   Mouse.current.leftButton.wasPressedThisFrame;

        if (clicked)

        {
            if (!gamestarted)
            {
                Time.timeScale = 1f; // Resume game
                gamestarted = true;
                tapToStartUI.SetActive(false);
            }

            // Flap on first tap or any tap after game starts
            if (capyisAlive)
            {
                rb.linearVelocity = Vector2.up * flapstrenght;
                flap.Play();
            }
        }



        if (transform.position.y > 6.7 || transform.position.y < -6.64)
        {
            LogicScript.gameOver();
            capyisAlive = false;
            if (!hasPlayedHitSound)
            {
                hitsound.Play();
                hasPlayedHitSound = true;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasPlayedHitSound)
        {
            LogicScript.gameOver();
            capyisAlive = false;
            hitsound.Play();
            hasPlayedHitSound = true;

        }
    }

}
