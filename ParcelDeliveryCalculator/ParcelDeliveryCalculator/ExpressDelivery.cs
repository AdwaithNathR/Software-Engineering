/******************************************************************************
* Filename    = ExpressDelivery.cs
*
* Author      = Adwaith Nath R
* 
* Project     = ParcelDeliveryCalculator
*****************************************************************************/



namespace ParcelDeliveryCalculator;
public class ExpressDelivery : IDeliveryMethod
{
    public decimal CalculatePrice(decimal weightInKg)
    {
        // per Kg 50rs
        return weightInKg * 50;
    }

    public TimeSpan EstimateTime(decimal distanceInKm)
    {
        // Avg Speed of Express is 80 km/hr
        decimal avgSpeed = 80;
        decimal hours = distanceInKm / avgSpeed;
        return TimeSpan.FromHours((double)hours);
    }

}
