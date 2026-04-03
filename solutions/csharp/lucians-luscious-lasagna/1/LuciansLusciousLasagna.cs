class Lasagna
{
    private int EXPECTED_MINUTES = 40;
    
    public int ExpectedMinutesInOven(){
        return this.EXPECTED_MINUTES;
    }

    
    public int RemainingMinutesInOven(int timeInOven){
        return this.EXPECTED_MINUTES - timeInOven;
    }
    
    
    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }
    
    
    public int ElapsedTimeInMinutes(int layers, int timeInOven){
        return this.PreparationTimeInMinutes(layers) + timeInOven;
    }
}
