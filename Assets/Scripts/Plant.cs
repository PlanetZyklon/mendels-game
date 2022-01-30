
public class Plant {
    private list<float> dna;
    private plantGenes genome;
    private plantStats stats;

    public Plant(vector<float> dnaSequence) {
        this.dna = dna;
        this.genome = dnaToGenes(dna);
        this.plantStats = dnaToStats(dna);
    }

    public list<float> getDna() {return dna;}
    public plantGenes GetGenes() {return genome;}
    public plantStats GetStats() {return stats;}
    public void SetStats(plantStats newstats) { this.stats = plantStats; }
    private plantGenes dnaToGenes(vector<float> dna) {
        return plantGenes(dna[0],dna[1],dna[2],dna[3],dna[4],dna[5],dna[6]);
    }

    private plantStats dnaToStats(vector<float> dna){
        return plantStats(dna[3],dna[0],dna[2],dna[4]);
    }

}