using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;


public class Genetics
{

    public Plant breed(Plant plant1, Plant plant2)
    {
        int split = Random.Range(1, Globals.DNA_LENGTH-1);
        List<float> offspring = new List<float>();
        for (int i = 0; i < Globals.DNA_LENGTH; i++)
        {
            if (i < split)
            {
                offspring.Add(plant1.getDnaAt(i));
            }
            else
            {
                offspring.Add(plant2.getDnaAt(i));
            }
        }
        offspring = mutate(offspring);
        return new Plant(offspring);
    }

    private List<float> mutate(List<float> dna)
    {
        float sign = Mathf.Pow(-1.0f, Random.Range(0,2));
        int gene = Random.Range(0, Globals.DNA_LENGTH);
        if (Random.Range(0.0f,1.0f) <= Globals.MUTATION_CHANCE)
        {

            dna[gene] = sign * dna[gene] * Globals.MUTATION_FACTOR;
        }
        return dna;
    }
}