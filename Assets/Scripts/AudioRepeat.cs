using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRepeat : MonoBehaviour
{

    public AudioSource audioSource;
    public float movementThreshold = 0.01f;

    private Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;

        if(audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, lastPosition) > movementThreshold)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }

        lastPosition = transform.position;

    }
}
