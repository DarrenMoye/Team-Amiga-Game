using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelectButton : MonoBehaviour
{
    public void OnButtonCick()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
