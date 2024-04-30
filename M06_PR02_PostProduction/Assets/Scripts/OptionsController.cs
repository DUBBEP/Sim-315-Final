using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void LoadScene(string str)
    {
        SceneManager.LoadScene(str);
    }
}
