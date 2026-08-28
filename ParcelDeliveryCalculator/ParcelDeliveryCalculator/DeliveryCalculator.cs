/******************************************************************************
* Filename    = DeliveryCalculator.cs
*
* Author      = Adwaith Nath R
* 
* Project     = ParcelDeliveryCalculator
*****************************************************************************/


namespace ParcelDeliveryCalculator;

public sealed class DeliveryCalculator
{
    public decimal Quote(IDeliveryMethod method, decimal weightInkg, decimal distanceInKm)
    {
        try
        {
            // negative weight and distance is not allowed
            if (weightInkg < 0 || distanceInKm < 0)
            {
                throw new Exception("Negative weight or distance");
            }

            decimal price = method.CalculatePrice(weightInkg);
            TimeSpan time = method.EstimateTime(distanceInKm);
            decimal timeInDecimal = (decimal)time.TotalHours;

            // Return Cost per hour
            if (timeInDecimal > 0)
            {
                return price / timeInDecimal;
            }
            else
            {
                throw new Exception("Delivery is not possible");
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
            return -1;
        }
    }
}
