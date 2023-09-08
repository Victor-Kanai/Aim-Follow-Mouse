using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [Header("Movimenta��o do Player")]
    public int speed;
    public SpriteRenderer playerRenderer;

    [Header("Invoca��o das Balas")]
    public float timerInstantiateBullet;
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    void Start()
    {
        StartCoroutine(InstantiateBullet());
    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 movementPlayer = new Vector2(horizontal, vertical);
        transform.Translate(movementPlayer * speed * Time.deltaTime);

        //Flipa o sprite do player para a dire��o na qual ele est� andando :)
        if(horizontal == -1)
        {
            playerRenderer.flipX = true;
        }
        else if(horizontal == 1)
        {
            playerRenderer.flipX = false;
        }
    }

    IEnumerator InstantiateBullet()
    {
        yield return new WaitForSeconds(timerInstantiateBullet);        
        Instantiate(bulletPrefab, spawnPoint);
        StartCoroutine(InstantiateBullet());
    }
}
