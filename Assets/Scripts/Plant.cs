using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class Plant
{
    private List<float> dna;
    private plantGenes genome;
    private plantStats stats;

    public Plant(List<float> dnaSequence)
    {
        this.dna = dnaSequence;
        this.genome = dnaToGenes(dna);
        this.stats = dnaToStats(dna);
    }

    public List<float> getDnaAt() { return dna; }
    public float getDnaAt(int i) { return dna[i];  }
    public plantGenes GetGenes() { return genome; }
    public plantStats GetStats() { return stats; }
    public void SetStats(plantStats newstats) { this.stats = newstats; }
    private plantGenes dnaToGenes(List<float> dna)
    {
        return new plantGenes(dna[0], dna[1], dna[2], dna[3], dna[4], dna[5], dna[6]);
    }

    private plantStats dnaToStats(List<float> dna)
    {
        return new plantStats(dna[3], dna[0], dna[2], dna[4]);
    }

}