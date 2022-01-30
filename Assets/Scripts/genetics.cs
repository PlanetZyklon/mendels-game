private static float MUTATION_CHANCE = 0.05;
private static float MUTATION_FACTOR = 0.20;

public class Genetics {
    private var rand;
    public Genetics() {
        this.rand = new Random();
    }
    public Plant breed(Plant plant1, Plant plant2){
        int split = rand.Next(1,DNA_LENGTH-1);
        vector<float> baby;
        for(int i=0;i<DNA_LENGTH;i++){
            if(i<split){
                baby.Add(plant1[i]);
            } else {
                baby.Add(plant2[i]);
            }
        }
        baby = mutate(baby);
        return baby;
    }

    private vector<float> mutate(vector<float> dna){
            int sign = Math.Pow(-1,rand.Next(2));
            int gene = rand.Next(DNA_LENGTH);
            if(rand.NextDouble() <= MUTATION_CHANCE){
                return dna[gene] + sign*dna[gene]*MUTATION_FACTOR;
            } else {
                return dna;
            }
    }
}