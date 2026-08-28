/******************************************************************************
* Filename    = StandardDelivery.cs
*
* Author      = Adwaith Nath R
* 
* Project     = ParcelDeliveryCalculator
*****************************************************************************/


namespace ParcelDeliveryCalculator;
public class StandardDelivery : IDeliveryMethod
{
    public decimal CalculatePrice(decimal weightInKg)
    {
        // per Kg 10rs
        return weightInKg * 10;
    }

    public TimeSpan EstimateTime(decimal distanceInKm)
    {
        // Avg Speed of Standard is 60 km/hr
        decimal avgSpeed = 60;
        decimal hours = distanceInKm / avgSpeed;
        return TimeSpan.FromHours((double)hours);
    }

}
