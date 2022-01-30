public struct plantStats {
    double water;
    double health;
    double maturityTimer;
    double nutrition;

    public plantStats (double water, double health, double maturityTimer, double nutrition){
        this.water = water;
        this.health = health;
        this.maturityTimer = maturityTimer;
        this.nutrition = nutrition;
    }

public struct plantGenes {
    double maxHealth;
    double healingRate;
    double maturityTime;
    double waterCap;
    double nutritionCap;
    double nutritionRate;
    double waterRate;

    public plantGenes(double maxHealth, double healingRate, double maturityTime, double waterCapacity, double nutritionCapacity, double waterRate, double nutritionRate) {
        this.maxHealth = maxHealth;
        this.healingRate = healingRate;
        this.maturityTime = maturityTime;
        this.waterCap = waterCapacity;
        this.nutritionCap = nutritionCapacity;
        this.waterRate = waterRate;
        this.nutritionRate = nutritionRate;
    }
}