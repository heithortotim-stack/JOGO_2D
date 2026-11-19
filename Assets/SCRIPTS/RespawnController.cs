using UnityEngine;

public class RespawnController : MonoBehaviour
{
    public static RespawnController Instance; // Uma variável que permite acessar o controlador de respawn por meio de outros códigos, sem precisar procurar o objeto manualmente.

    public Transform respawnPoint; // Uma variável que guarda o local onde o personagem deverá reaparecer.

    private void Awake() // Uma função que o Unity executa automaticamente quando o objeto é carregado e inicializado.
    {
        Instance = this; // Guarda o próprio controlador na variável Instance.
    }
    private void OnTriggerEnter2D(Collider2D collision) // Uma função que será executada automaticamente quando algum objeto entrar na área de detecção.
    {
        if (collision.CompareTag("Player")) // Verifica se o objeto que entrou na área possui a Tag Player.
        {
            collision.transform.position = respawnPoint.position; // Muda a posição do personagem para o local definido como ponto de respawn.
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
