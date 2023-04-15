using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject horse;
    public float value;
    public Vector3 sizeChange;
    public void MoveLeft()
    {
        value = value - 1f;
        horse.transform.position = new Vector3(value, 5, 100);
    }
    public void MoveRight()
    {
        value = value + 2f;
        horse.transform.position = new Vector3(value, 5, 100);
    }
    public void RotateLeft()
    {
        horse.transform.Rotate(0f, 10f, 0f);
    }
    public void RotateRight()
    {
        horse.transform.Rotate(0f, -10f, 0f);
    }
    public void Grow()
    {
        horse.transform.localScale = horse.transform.localScale + sizeChange;
    }
    public void Reduce()
    {
        horse.transform.localScale = horse.transform.localScale - sizeChange;
    }
    public void HorseReset()
    {
        value = 202;
        horse.transform.position = new Vector3(202, 5, 100);
        horse.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        horse.transform.localScale = new Vector3(1, 1, 1);
    }

     public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void PlayGame4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}