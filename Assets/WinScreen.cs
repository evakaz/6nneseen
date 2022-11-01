using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    private int loadNewScreen = 10;
    public GameObject PressAnyKey;
    public GameObject credits;
    private bool triggered;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        credits.SetActive(false);
        PressAnyKey.SetActive(false);
        Invoke("LoadPressAnyKey", loadNewScreen);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("triggered", triggered);
        if (Input.anyKey)
        {
            LoadCredits();
        }

    }

    void LoadPressAnyKey()
    {
        PressAnyKey.SetActive(true);
    }

    void LoadCredits()
    {
        credits.SetActive(true);
        triggered = true;
    }
}