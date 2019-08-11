﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocinhoControl : MonoBehaviour
{
    public GameObject player;

    MoveToRef script;
    Animator anim;

    void Start()
    {
        script = player.GetComponent<MoveToRef>();
        anim = player.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Platforms")) {
            script.encostado = true;
            anim.SetInteger("state", 3);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Platforms")) {
            script.encostado = false;
            anim.SetInteger("state", 1);
        }
    }
}