using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlantBehaviour : MonoBehaviour
{

    public plantStats plantstats;

    public double maturityTime;
    double maturtiyTimer;

    public Sprite deadSprout;  // dead sprout sprite
    public Sprite maturePlant;  // grown alive plant sprite
    public Sprite deadMaturePlant;  // dead grown plant sprite
    public bool isMature;
    public bool isAlive;
    bool grownOnce;

    AudioSource audioSource;

    public AudioClip growSound;

    // Start is called before the first frame update
    void Start()
    {
        maturtiyTimer = maturityTime;
        isMature = false;
        isAlive = true;
        grownOnce = false;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        maturtiyTimer -= Time.deltaTime;

        if (maturtiyTimer < 0 && isAlive && !grownOnce)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = maturePlant;
            isMature = true;
            grownOnce = true;
            audioSource.PlayOneShot(growSound);
        }

        // checks if the sprite is alive
        if(!isAlive && !isMature)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = deadSprout;
        } else if (!isAlive)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = deadMaturePlant;
        }
    }
}
