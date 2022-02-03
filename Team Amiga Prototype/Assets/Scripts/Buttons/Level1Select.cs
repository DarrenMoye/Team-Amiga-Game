using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Select : MonoBehaviour
{
    public void OnButtonCick()
    {
        SceneManager.LoadScene("Level1");
    }
}
