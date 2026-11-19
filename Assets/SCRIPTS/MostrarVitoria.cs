using UnityEngine;

public class MostrarVitoria : MonoBehaviour
{

    public GameObject painelVitoria; // Uma variável chamada painelVitoria, que vai guardar o objeto responsável por mostrar a tela de vitória.

    private void OnTriggerEnter2D(Collider2D other) // Uma função que será executada automaticamente quando outro objeto entrar na área de detecção.
    {
        if (other.CompareTag("Player")) // Verifica se o objeto que entrou na área possui a Tag Player.
        {
            painelVitoria.SetActive(true); // Ativa o painel de vitória para que ele apareça na tela.

            Time.timeScale = 0f; // Faz o tempo do jogo parar.
        }
    }
}
