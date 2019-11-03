﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{   

    private Rigidbody2D playerRb;
    private SpriteRenderer playerSprite;
    public float velocidade;
    public bool flipX;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {   
        //botão esquerdo do mouse
        if(Input.GetMouseButtonDown(0)){
            velocidade *= -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;
        }

        playerRb.velocity = new Vector2(velocidade, 0);
    }

    void OnCollisionEnter2D(Collision2D colisao){
        
        if(colisao.gameObject.tag == "meteoro"){
            SceneManager.LoadScene("GameOver");
        }
    }
}
