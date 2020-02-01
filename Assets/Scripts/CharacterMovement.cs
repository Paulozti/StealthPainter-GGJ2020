﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 8f;
    private bool canPlayerMove = true;

    public GameObject player;

    void Start()
    {
        CheckInteraction.onMonalisaStart += StopPlayerMovement;
        CheckInteraction.onMonalisaExit += StartPlayerMovement;
        CheckInteraction.onMonalisaReEnter += StopPlayerMovement;
    }

    void Update()
    {
        PlayerInput();
    }

    private void PlayerInput()
    {
        float axisX = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Vertical");
        if (axisX != 0 || axisY  != 0)
        {
            MoveCharacter(player, new Vector2(axisX, axisY));
        }
    }

    public void MoveCharacter(GameObject character, Vector2 direction)
    {
        if (character.CompareTag("Player") && canPlayerMove)
        {
            character.transform.Translate(direction * playerSpeed * Time.deltaTime);
        }
        
    }

    private void StopPlayerMovement()
    {
        canPlayerMove = false;
    }

    private void StartPlayerMovement()
    {
        canPlayerMove = true;
    }
}
