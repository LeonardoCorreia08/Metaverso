using UnityEngine;
using UnityEngine.SceneManagement;

public class TerraClick : MonoBehaviour
{
    // Coloque aqui o nome exato da sua cena da estação espacial
    public string nomeCenaEstacao = "EstacaoEspacial";

    private void OnMouseDown()
    {
        SceneManager.LoadScene(nomeCenaEstacao);
    }
}
