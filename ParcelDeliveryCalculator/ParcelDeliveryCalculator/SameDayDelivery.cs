/******************************************************************************
* Filename    = SameDayDelivery.cs
*
* Author      = Adwaith Nath R
* 
* Project     = ParcelDeliveryCalculator
*****************************************************************************/



namespace ParcelDeliveryCalculator;
public class SameDayDelivery : IDeliveryMethod
{
    public decimal CalculatePrice(decimal weightInKg)
    {
        // per Kg 30rs
        return weightInKg * 30;
    }

    public TimeSpan EstimateTime(decimal distanceInKm)
    {
        // For same day , max distance is 300km
        if (distanceInKm <= 300)
        {
            // Avg Speed of Sameday is 70 km/hr
            decimal avgSpeed = 70;
            decimal hours = distanceInKm / avgSpeed;
            return TimeSpan.FromHours((double)hours);
        }
        else
        {
            return TimeSpan.Zero;
        }
    }

}
