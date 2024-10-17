using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScriptFinal : MonoBehaviour
{
    public GameObject player;
    public GameObject walltodestroy;
    public GameObject deleteLight;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == player)
        {
            
            Debug.Log("Ключ найден!");

            Destroy(gameObject);
            Destroy(walltodestroy);
            Destroy(deleteLight);
        }
    }
}
