using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construcao : MonoBehaviour
{
    Vector3 mouse;
    Transform posicaoObjeto;
    public GameObject cubo;
    bool posicionamento = true;

    private void Start() {
        
        posicaoObjeto = GameObject.Find("Square").transform;
        mouse = new Vector3(0,0,0);
        posicaoObjeto.position += new Vector3(0,0,0);
        
    }

    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.T)){
            Instantiate(cubo);
            posicaoObjeto = GameObject.Find("Square(clone)").transform;
        }
        if(posicionamento == true){
            mouse += Input.mousePosition - new Vector3(245,145,0);
            mouse.x = (int)(mouse.x * 0.05f);
            mouse.y = (int)(mouse.y * 0.05f); 
            posicaoObjeto.position = mouse ; 
        }
        if(Input.GetMouseButtonUp(0)){
           posicionamento = false;   
        }
           
        
        
    }
}
