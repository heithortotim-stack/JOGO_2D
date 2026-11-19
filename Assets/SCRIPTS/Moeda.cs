using UnityEngine; // Importa as ferramentas principais do Unity para utilizar recursos como objetos, colisões e funções.
using System.Collections.Generic; // Importa ferramentas que permitem trabalhar com listas de informações e coleções de objetos.
using System.Collections; // Importa ferramentas que permitem trabalhar com corrotinas, que são funções capazes de executar tarefas em etapas, podendo esperar um determinado tempo antes de continuar.
public class Moeda : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider2D collision) // Uma função que será executada automaticamente quando outro objeto entrar na área de detecção da moeda.
    {
        if (collision.gameObject.CompareTag("Player")) // Verifica se o objeto que entrou na área de detecção possui a Tag Player.
        {
            Destroy(this.gameObject); // Destrói o objeto da moeda, fazendo com que ela desapareça do jogo.
            print("Você pegou uma moeda"); // Mostra uma mensagem no Console do Unity informando que o jogador pegou uma moeda.
        }
    }

}
