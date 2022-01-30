public struct plantStats
{
    float water;
    float health;
    float maturityTimer;
    float nutrition;

    public plantStats(float water, float health, float maturityTimer, float nutrition)
    {
        this.water = water;
        this.health = health;
        this.maturityTimer = maturityTimer;
        this.nutrition = nutrition;
    }
}
public struct plantGenes
{
    float maxHealth;
    float healingRate;
    float maturityTime;
    float waterCap;
    float nutritionCap;
    float nutritionRate;
    float waterRate;

    public plantGenes(float maxHealth, float healingRate, float maturityTime, float waterCapacity, float nutritionCapacity, float waterRate, float nutritionRate)
    {
        this.maxHealth = maxHealth;
        this.healingRate = healingRate;
        this.maturityTime = maturityTime;
        this.waterCap = waterCapacity;
        this.nutritionCap = nutritionCapacity;
        this.waterRate = waterRate;
        this.nutritionRate = nutritionRate;
    }
}