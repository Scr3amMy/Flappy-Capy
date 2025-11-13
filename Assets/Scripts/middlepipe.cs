using UnityEngine;

public class middlepipe : MonoBehaviour
{
    public LogicScript logicScript;
    public capy capy; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("LOGIC").GetComponent<LogicScript>();
        capy = GameObject.FindGameObjectWithTag("capy").GetComponent<capy>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (capy != null && capy.capyisAlive)
            logicScript.IncreaseScore();
    }
}
