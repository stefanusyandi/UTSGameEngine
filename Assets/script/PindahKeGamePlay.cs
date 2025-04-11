using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PindahKeGameplay : MonoBehaviour
{
    public Button tombolMulai;

    void Start()
    {
        // tombolMulai.onClick.AddListener(MulaiGame);
    }

    public void MulaiGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
