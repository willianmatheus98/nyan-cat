using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoro : MonoBehaviour
{   

    private Rigidbody2D meteoroRb;
    private int atrito;
    public int  atritoMaximo, atritoMinimo, ponto;
    public Vector3 posicao;
    public GameObject meteoroPrefab;

    // Start is called before the first frame update
    void Start()
    {
        meteoroRb = GetComponent<Rigidbody2D>();
        
        atrito = Random.Range(atritoMinimo, atritoMaximo);

        meteoroRb.drag = atrito;

        posicao = transform.position;
    }

    void OnBecameInvisible(){    
        Instantiate(this.gameObject, posicao, transform.localRotation);
        pontuacao.pontos += ponto;
        Destroy(this.gameObject);
    }
}
