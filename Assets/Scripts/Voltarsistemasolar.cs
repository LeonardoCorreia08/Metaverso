using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarSistemaSolar : MonoBehaviour
{
    // Coloque aqui o nome exato da sua cena do sistema solar
    public string nomeCenaSistemaSolar = "SistemaSolar";

    private void Update()
    {
        // Pressiona ESC para voltar ao sistema solar
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(nomeCenaSistemaSolar);
        }
    }
}
