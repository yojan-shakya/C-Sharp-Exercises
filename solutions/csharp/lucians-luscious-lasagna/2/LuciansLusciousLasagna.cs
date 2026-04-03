class Lasagna
{
    private int EXPECTED_MINUTES = 40;
    
    public int ExpectedMinutesInOven() => this.EXPECTED_MINUTES; 

    public int RemainingMinutesInOven(int timeInOven) => this.EXPECTED_MINUTES - timeInOven;
    
    
    public int PreparationTimeInMinutes(int layers) =>  layers * 2;
    
    public int ElapsedTimeInMinutes(int layers, int timeInOven) =>this.PreparationTimeInMinutes(layers) + timeInOven;
       
}
