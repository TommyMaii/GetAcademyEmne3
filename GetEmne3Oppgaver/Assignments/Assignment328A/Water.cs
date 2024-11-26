namespace Emne3GetAcademyOppgaver.Assignments.Assignment328A;

public class Water
{
    public double Temperature { get; set; }
    public double Amount { get; }
    public string State { get; set; }
    
    public double ProportionFirstState { get; set; }
    
    public double Proportion { get; set; }
    
    
        

    public Water(double amount, double temperature, double proportion = 0.0)
    {
            Proportion = proportion;
            Temperature = temperature;
            Amount = amount;
            switch (Temperature)
            {
                case < 0:
                    State = WaterState.Ice.ToString();
                    break;
                case <= 100:
                    State = WaterState.Fluid.ToString();
                    break;
                case > 100:
                    State = WaterState.Gas.ToString();
                    break;
            }
            if ((Temperature == 0 || Temperature == 100) && proportion == 0.0)
            {
                throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
            }         
            if (Temperature == 100 && proportion != 0.0)
            {
                State = WaterState.FluidAndGas.ToString();
                ProportionFirstState = proportion;
            }           
            if (Temperature == 0 && proportion != 0.0)
            {
                State = WaterState.IceAndFluid.ToString();
                ProportionFirstState = proportion;
            }
    }

    public void AddEnergy(double energy)
    {
        if (Temperature < 0)
        {
            double energyNeededToHeatWaterToZeroDegrees = Math.Abs(Temperature * Amount);
            double restOfEnergy = energy - energyNeededToHeatWaterToZeroDegrees;
            if (restOfEnergy < 0) energyNeededToHeatWaterToZeroDegrees = energy;
            double increaseInTemperature = energyNeededToHeatWaterToZeroDegrees / Amount;
            Temperature += increaseInTemperature;
            if (Temperature != 0) return;
            Proportion = 1.0;
            var energyToSmeltIce = Amount * Proportion * 80;
            var energyLeftAfterSmeltingIce = energyToSmeltIce - restOfEnergy;
            var iceLeft = energyLeftAfterSmeltingIce / 80; 
            if(iceLeft < 0) iceLeft = 0;
            ProportionFirstState = iceLeft / Amount;
            if (ProportionFirstState == 0.0)
            {
                State = WaterState.Fluid.ToString();
                var incTemp = Math.Abs(energyLeftAfterSmeltingIce / Amount);
                Temperature += incTemp;
                return;
            }
            else
            {
            State = WaterState.IceAndFluid.ToString();
            }
        }

        if (Temperature > 0)
        {
            double energyNeededToHeatWaterToHundredDegrees = Math.Abs((100 - Temperature) * Amount);
            double restEnergy = energy - energyNeededToHeatWaterToHundredDegrees;
            if (restEnergy < 0) energyNeededToHeatWaterToHundredDegrees = energy;
            double increaseInTemperature = energyNeededToHeatWaterToHundredDegrees / Amount;
            Temperature += increaseInTemperature;
            if (Temperature != 100) return;
            Proportion = 1.0;
            var energyToCreateGas = Amount * Proportion * 600;
            var energyLeftAfterEvaporatingFluid = energyToCreateGas - restEnergy;
            var fluidLeft = energyLeftAfterEvaporatingFluid / 600; 
            if(fluidLeft < 0) fluidLeft = 0;
            ProportionFirstState = fluidLeft / Amount;
            if (ProportionFirstState == 0.0)
            {
                State = WaterState.Gas.ToString();
                var incTemp = Math.Abs(energyLeftAfterEvaporatingFluid / Amount);
                Temperature += incTemp;
                return;
            }
            else
            {
                State = WaterState.FluidAndGas.ToString();
            }
        }
    }
}