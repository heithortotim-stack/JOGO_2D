using UnityEngine; // Importa as ferramentas principais do Unity para que possamos utilizá-las no código.
using UnityEngine.SceneManagement; // Importa as ferramentas responsáveis por controlar as cenas do jogo.
public class MenuManager : MonoBehaviour
{
    public void StartGame() // Uma função chamada StartGame, responsável por iniciar o jogo.
    {
        SceneManager.LoadScene("Fase1"); // Faz a Unity carregar a cena chamada Fase1.
    }  
    
    public void QuitGame() // Uma função chamada QuitGame, responsável por fechar o jogo.
    {
        Application.Quit(); // Envia um comando para fechar o jogo.
    }

}
