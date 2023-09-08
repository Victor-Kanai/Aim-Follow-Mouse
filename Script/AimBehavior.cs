using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class AimBehavior : MonoBehaviour
{
    public Camera mainCamera;
    private Vector3 mousePos;
    void Start()
    {
        
    }
    void Update()
    {
        //Pego a posi��o global do mouse pela c�mera :)
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        //normalizo o vetor e crio a rota��o
        Vector3 rotation = (mousePos - transform.position).normalized;

        //fa�o a tangente da "rotation" e passo de radianos para graus
        float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        //Rotaciono a mira pelo mouse sem influenciar o jogador ;)
        transform.eulerAngles = new Vector3(0, 0, rotationZ);
    } 
}
