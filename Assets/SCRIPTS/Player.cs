using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");//Vai reconhecera que ele moverá para a Horizontal
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); // Vai adicionar a velocidade na Horizontal

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); // Vai pular(pulo infinito) e vai cair no chão graças a aceleração
        }
        

    }
}
