class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int Today()
    {   
        int length = this.birdsPerDay.Length;
        return this.birdsPerDay[length-1];
    }

    public void IncrementTodaysCount()
    {
        int length = this.birdsPerDay.Length;

        int today =  this.birdsPerDay[length-1];
        today = today + 1;

        this.birdsPerDay[length-1] = today;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int count in this.birdsPerDay ){
            if(count == 0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;

        for (int i = 0; i<numberOfDays; i++){
            total += this.birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int total = 0;
        foreach(int count in this.birdsPerDay){
            if(count >= 5){
                total += 1;
            }
        }
        return total;
    }
}
