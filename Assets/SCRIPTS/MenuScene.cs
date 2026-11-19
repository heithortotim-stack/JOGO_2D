using UnityEngine; // Importa as ferramentas principais do Unity para que possamos utilizá-las no código.
using UnityEngine.SceneManagement; // Importa as ferramentas responsáveis por controlar as cenas do jogo.
public class MenuScene : MonoBehaviour
{
    public GameObject painelPause; // Uma variável chamada painelPause, que vai guardar o objeto responsável por mostrar o menu de pausa.
    public GameObject painelGameOver; // Uma variável chamada painelGameOver, que vai guardar o objeto responsável por mostrar a tela de Game Over.

    bool pausado = false; // Uma variável que informa se o jogo está pausado ou não.
    bool jogoAcabou = false; // Uma variável que informa se o jogo terminou.


    void Start()
    {
        painelPause.SetActive(false); // Desativa o painel de Pausa para que ele também não apareça no início do jogo.
        painelGameOver.SetActive(false); // Desativa o painel de Game Over para que ele também não apareça no início do jogo.
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Verifica se o jogador acabou de apertar a tecla ESC do teclado.
        {
            if (pausado) // Verifica se o jogo já está pausado.
            {
                Continuar(); // Chama a função Continuar(), responsável por tirar o jogo da pausa.
            }
            else // Significa "caso contrário".
            {
                Pausar(); // Chama a função Pausar(), responsável por interromper o jogo e mostrar o painel de pausa.
            }
        } 
    }

    public void Pausar() // Uma função chamada Pausar, responsável por interromper o jogo e mostrar o menu de pausa.
    {
        if(jogoAcabou == false) // Verifica se o jogo ainda não terminou.
        {
            pausado = true; // Altera o valor da variável pausado para verdadeiro.
                        painelPause.SetActive(true); // Ativa o painel de pausa para que ele apareça na tela.
            Time.timeScale = 0f; // Faz o tempo do jogo parar.
        }
    }

    public void Continuar() // Uma função chamada Continuar, responsável por fazer o jogo voltar a funcionar depois de uma pausa.
    {
        pausado = false; // Altera o valor da variável pausado para falso.
        painelPause.SetActive(false); // Desativa o painel de pausa.
        Time.timeScale = 1f; // Faz o tempo do jogo voltar à velocidade normal.
    }

    public void MostrarGameOver() // Uma função chamada MostrarGameOver, responsável por mostrar a tela de fim de jogo.
    {
        jogoAcabou = true; // Altera o valor da variável jogoAcabou para verdadeiro.
        painelGameOver.SetActive(true); // Ativa o painel de Game Over para que ele apareça na tela.
        Time.timeScale = 0f; // Faz o tempo do jogo parar.
    }

    public void Reiniciar() // Uma função chamada Reiniciar, responsável por começar novamente a fase atual.
    {
        Time.timeScale = 1f; // Faz o tempo do jogo voltar à velocidade normal.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Faz a Unity carregar novamente a cena que está aberta no momento.
    }

    public void VoltarMenu() // Uma função chamada VoltarMenu, responsável por levar o jogador de volta ao menu principal.
    {
        Time.timeScale = 1f; // Faz o tempo do jogo voltar à velocidade normal.
        SceneManager.LoadScene(0); // Faz o Unity carregar a cena que está na posição zero da lista de cenas do jogo.
    }
}
