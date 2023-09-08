using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehavior : MonoBehaviour
{
    public int speed;
    public int timerDestroyBullets;
    void Start()
    {
        StartCoroutine(DestroyBullet());
        transform.SetParent(null);
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(timerDestroyBullets);
        Destroy(gameObject);
    }
}
