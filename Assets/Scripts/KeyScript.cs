using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject player; 
    public GameObject deleteLight; 

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == player)
        {
            
            Debug.Log("���� ������!");

            Destroy(gameObject);
            Destroy(deleteLight);
        }
    }
}
