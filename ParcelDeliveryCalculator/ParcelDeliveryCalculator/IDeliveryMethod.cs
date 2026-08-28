/******************************************************************************
* Filename    = IDeliveryMethod.cs
*
* Author      = Adwaith Nath R
* 
* Project     = ParcelDeliveryCalculator
*****************************************************************************/


namespace ParcelDeliveryCalculator;
public interface IDeliveryMethod
{
    decimal CalculatePrice(decimal weightInKg);
    TimeSpan EstimateTime(decimal distanceInKm);
}
