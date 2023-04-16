using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    // Start is called before the first frame update
    public float fadeDuration = 1f;
    public float displayDuration = 1f;
    public GameObject Player;
    public CanvasGroup ExitBK;
    public CanvasGroup FailBK;
    bool IsExit=false;
    bool IsFail = false;
    public float timer = 0f;
    public AudioSource winaudio;
    public AudioSource failaudio;
    bool IsPlay=false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject==Player)
        {
            IsExit = true;
        }
    }

    public void Caught()
    {
        IsFail = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsExit)
        {
            EndLevel(ExitBK,false,winaudio);
        }
        else if (IsFail)
        {
            EndLevel(FailBK,true,failaudio);
        }
        
    }
    void EndLevel(CanvasGroup  isCanvasGroup,bool doRestart,AudioSource playaudio)
    {
        if (!IsPlay)
        {
            playaudio.Play();
            IsPlay = true;
        }
        timer += Time.deltaTime;
        isCanvasGroup.alpha = timer / fadeDuration;
        if(timer>fadeDuration+displayDuration)
        {
            if(doRestart)
            {
                SceneManager.LoadScene(0);
            }else if(!doRestart)
            {
                Application.Quit();
            }
            
        }
    }
}
