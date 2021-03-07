﻿using UnityEngine;

public class GodMode : MonoBehaviour
{
    private bool isGodeMode = false;

    private void Awake()
    {
        GetComponent<InputTools>().GodModeActivated += ActivateGodMode;
    }

    private void OnDestroy()
    {
        GetComponent<InputTools>().GodModeActivated -= ActivateGodMode;
    }

    private void ActivateGodMode()
    {
        if (!isGodeMode)
        {
            isGodeMode = true;
            GameObject.Find("Player").GetComponent<PlayerHealth>().SetGodModeHealth(true);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().color = Color.black;
        }
        else
        {
            isGodeMode = false;
            GameObject.Find("Player").GetComponent<PlayerHealth>().SetGodModeHealth(false);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    void Update()
    {

    }
}