using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class keySound : MonoBehaviour
{
    BoxCollider2D boxCollider;
    AudioSource keyBleep;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        
        boxCollider.isTrigger = true;
        keyBleep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(KeyCoroutine());
        keyBleep.Play(0);        
    }

    IEnumerator KeyCoroutine()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
  
}
