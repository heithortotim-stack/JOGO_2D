using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public BoxCollider2D trigger; // Uma variável chamada trigger, que vai guardar o componente responsável por detectar quando algum objeto entra em uma área específica.

    private void OnTriggerEnter2D(Collider2D collision) // Uma função que é executada automaticamente quando outro objeto entra na área de detecção (Trigger).
    {
        if (collision.CompareTag("Player")) // Verifica se o objeto que entrou na área possui a Tag chamada Player.
        {
            RespawnController.Instance.respawnPoint = transform; // Define a posição atual desse objeto como o novo ponto onde o personagem deverá reaparecer.
            trigger.enabled = false; // Desativa a área de detecção para que ela pare de detectar novas entradas.
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
