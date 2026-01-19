using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMenu : MonoBehaviour
{
  public void TryAgain()
  {
    SceneManager.LoadScene(0);
  }

  public void Start()
  {
    SceneManager.LoadScene(0);
  }

  public void Exit()
  {
    Application.Quit();
  }

  private void Update()
  {
   
  }
}
