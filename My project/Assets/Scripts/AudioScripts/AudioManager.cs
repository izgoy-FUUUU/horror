using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource musicSource;
    public AudioSource soundSource;

    public AudioClip bgClip;

    private float musicVolume = 1.0f;
    private float soundVolume = 1.0f;

    private Dictionary<string, AudioClip> soundClips;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad (gameObject);
        }
        else
        {
            Destroy (gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
