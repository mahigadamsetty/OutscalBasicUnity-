using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyFirstScript : MonoBehaviour
{
    public Button button;
    public string newScene;
    // Start is called before the first frame update
     private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
  private void OnButtonClick()
    {
        Debug.Log("Buuton click");
        SceneManager.LoadScene(newScene);

    }
}
