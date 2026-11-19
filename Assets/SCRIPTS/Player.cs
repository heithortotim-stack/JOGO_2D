using UnityEngine; // Importa as ferramentas principais do Unity para utilizar recursos como movimentação, colisões, objetos e controles.
using UnityEngine.SceneManagement; // Importa as ferramentas responsáveis por controlar as cenas do jogo.
public class Player : MonoBehaviour
{
    public float speed = 5f; // Uma variável que determina a velocidade de movimentação do personagem.
    private Rigidbody2D rb; // Uma variável chamada rb, que vai guardar o componente responsável pela física e movimentação do personagem em 2D.
    private bool isGrounded = false; // Uma variável que informa se o personagem está encostando no chão.
    public MenuScene menu; // Uma variável chamada menu, que vai guardar uma referência ao componente MenuScene.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Procura o componente Rigidbody2D que está no mesmo objeto do personagem e guarda ele na variável rb.

    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Verifica se o jogador está apertando alguma tecla para movimentar o personagem na horizontal.
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);  // Controla a velocidade horizontal do personagem, fazendo ele andar para a esquerda ou para a direita.

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // Verifica se o jogador apertou a tecla ESPAÇO e se o personagem está no chão.
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); // Aplica uma força para cima no personagem, fazendo ele pular. 
        }
        

    }

    void OnCollisionEnter2D(Collision2D collision) // Uma função que é executada automaticamente quando o personagem começa a encostar fisicamente em outro objeto.
    {
        if (collision.gameObject.CompareTag("Ground")) // Verifica se o objeto com o qual o personagem encostou possui a Tag Ground.
        {
            isGrounded = true; // Altera o valor da variável isGrounded para verdadeiro.
        }
        if (collision.gameObject.CompareTag("Dano")) // Verifica se o objeto com o qual o personagem encostou possui a Tag Dano.
        {
            menu.MostrarGameOver(); // Chama a função MostrarGameOver() que está dentro do script MenuScene.
        }
    }

    private void OnCollisionExit2D(Collision2D collision) // Uma função que é executada automaticamente quando o personagem deixa de encostar fisicamente em outro objeto.
    {
        if (collision.gameObject.CompareTag("Ground")) // Verifica se o objeto que o personagem deixou de tocar possui a Tag Ground.
        {
            isGrounded = false;  //Altera o valor da variável isGrounded para falso.
        }
    }

}
