class RemoteControlCar
{
    int speed;
    int batteryDrain;
    int battery;
    int distance;
    
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
        this.distance = 0;
    }
    
    public bool BatteryDrained()
    {
        if(this.battery == 0 || this.battery < this.batteryDrain){
            return true;
        }

        return false;
    }

    public int DistanceDriven()
    {
        return this.distance;
    }

    public void Drive()
    {
        if(this.BatteryDrained()){
            return;
        }

        this.battery = this.battery - this.batteryDrain;
        this.distance = this.distance + this.speed;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    int distance;
    
    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
       while(!car.BatteryDrained()){
           car.Drive();
       }

        return car.DistanceDriven() >= this.distance;
    }
}
