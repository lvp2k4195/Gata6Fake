using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainMenus;

    public void PauseGame()
    {
        // Debug.Log("pause game");
        // Pause game

        // Hiển thị menu
        MainMenus.SetActive(true);
    }


    public void Thoát()
    {
        // Debug.Log("pause game");
        // Pause game

        // Hiển thị menu
        MainMenus.SetActive(false);
    }
    void Start()
    {
        MainMenus.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("?");
    }
    public void ToggleMenu()
    {
        // Lấy trạng thái hiện tại của menu
        bool isMenuActive = MainMenus.activeSelf;

        // Đảo ngược trạng thái của menu
        MainMenus.SetActive(!isMenuActive);
    }

}
