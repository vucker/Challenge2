using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 2f;

    private float cooldownTimer;

    private void Start()
    {
        cooldownTimer = Time.time + cooldown;
    }
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= cooldownTimer)
        {
            cooldownTimer = Time.time + cooldown;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
