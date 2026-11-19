using UnityEngine; // Importa as ferramentas principais da Unity, permitindo utilizar objetos, colisões e outras funções.
using UnityEngine.SceneManagement; // Importa as ferramentas responsáveis por controlar as cenas do jogo.

public class TrocarFase : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) // Uma função que será executada automaticamente quando algum objeto entrar na área de detecção.
    {
        if (other.CompareTag("Player")) // Verifica se o objeto que entrou na área possui a Tag Player.
        {
            SceneManager.LoadScene("Fase2"); // Faz a Unity carregar a cena chamada Fase2.
        }
    }
}
