using UnityEngine;

public class MostrarVitoria : MonoBehaviour
{

    public GameObject painelVitoria;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            painelVitoria.SetActive(true);

            Time.timeScale = 0f;
        }
    }
}
