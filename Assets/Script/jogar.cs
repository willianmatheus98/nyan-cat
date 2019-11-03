using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jogar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //botão esquerdo do mouse
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("principal");
        }

    }
}
