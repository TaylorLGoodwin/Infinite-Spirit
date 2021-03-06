﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatUIController : MonoBehaviour
{
    public static CombatUIController Instance { get; set; }
    private Animator anim;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TransitionInStart()
    {
        anim.Play("TransitionInStart");
    }
}
