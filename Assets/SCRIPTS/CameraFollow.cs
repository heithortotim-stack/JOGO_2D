using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo; // Vai guardar quem a câmera deve seguir.
    public Vector3 distancia = new Vector3(0f, 0f, -10f); // Define a distância que a câmera deve manter do personagem.
    public bool movimentoSuave = true; // Uma variável que decide se a câmera vai se movimentar suavemente ou mudar de posição diretamente.
    public float velocidade = 5f; // Define a velocidade com que a câmera vai se aproximar da posição desejada.


    private void LateUpdate() // Uma função que será executada automaticamente pelo Unity depois que os outros objetos terminarem de se atualizar naquele quadro.
    {
        Vector3 posicaoDesejada = alvo.position + distancia; // Calcula onde a câmera deve ficar para acompanhar o personagem.

        if (movimentoSuave) // Verifica se a opção de movimento suave está ativada.
        {
            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, velocidade * Time.deltaTime); // Faz a câmera se movimentar suavemente até a posição desejada.
        }
        else // Significa "caso contrário".
        {
            transform.position = posicaoDesejada; // Coloca a câmera diretamente na posição desejada, sem fazer uma transição suave.
        }
    }

}
