using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Moeda : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            print("Você pegou uma moeda");
        }
    }

}
