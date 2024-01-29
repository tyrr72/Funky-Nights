using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;

    public bool HasStarted = true;


    void Start()
    {
        beatTempo = beatTempo / 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.instance.Paused)
        {
            transform.position += new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
} 
