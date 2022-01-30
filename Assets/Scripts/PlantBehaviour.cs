using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBehaviour : MonoBehaviour
{

    public plantStats plantstats;
    public plantGenes plantGenes;

    public double maturityTime;
    public double maturtiyTimer;

    public Sprite maturePlant;

    // Start is called before the first frame update
    void Start()
    {
        maturtiyTimer = maturityTime;
    }

    // Update is called once per frame
    void Update()
    {
        maturtiyTimer -= Time.deltaTime;

        if (maturtiyTimer < 0)
        {
            
        }
    }
}
