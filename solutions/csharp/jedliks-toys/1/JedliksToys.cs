class RemoteControlCar
{
    int driven = 0;
    int batteryPercentage = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this.driven} meters";
    }

    public string BatteryDisplay()
    {
        if(this.batteryPercentage == 0){
            return "Battery empty";
        }
        return $"Battery at {this.batteryPercentage}%";
    }

    public void Drive()
    {
        if(this.batteryPercentage == 0){
            return ;
        }
        
        this.batteryPercentage = this.batteryPercentage - 1;
        this.driven = this.driven + 20;
    }
}
