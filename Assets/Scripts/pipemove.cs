using UnityEngine;

public class pipemove : MonoBehaviour
{
    public float pipespeed = 5;
    public float deadzone = -15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pipespeed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}