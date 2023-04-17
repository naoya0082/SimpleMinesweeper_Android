using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSourceSE;  // SEスピーカー
    public AudioClip[] audioClipsSE;   // SE音源
    //シーン間でのデータ共有
    public static SoundManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySE(int index)
    {
        audioSourceSE.PlayOneShot(audioClipsSE[index]);
    }

    public void SEControl(string switchSE)
    {
        if (switchSE == "on") audioSourceSE.Play();
        else if (switchSE == "off") audioSourceSE.Stop();
    }
}
