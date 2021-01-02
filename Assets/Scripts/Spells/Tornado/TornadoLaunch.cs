﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoLaunch : MonoBehaviour
{

    [SerializeField] private float distanceX = 0;
    [SerializeField] private float duration = 0;

    private MovementFlip playerMovementFlip;

    void Awake()
    {
        playerMovementFlip = GameObject.Find("Player").GetComponent<MovementFlip>();

        if(!playerMovementFlip.GetIsFacingRight())
        {
            distanceX *= -1;
        }

        LeanTween.moveX(gameObject, gameObject.transform.position.x + distanceX, duration).setEaseOutQuad().setOnComplete(OnComplete);

    }

    private void OnComplete()
    {
        Destroy(gameObject);
    }
}
