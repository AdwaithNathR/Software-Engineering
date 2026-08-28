# Overview
This Project called Parcel delivery calculator demonstartes polymorphism using an Interface and three classes implementing it.

# Design
IDeliveryMethod is the common interface. StandardDelivery, ExpressDelivery , and SameDayDelivery classes implement IDeliveryMethod interface.
DeliveryCalculator class accepts IDeliveryMethod ,so it can work with any of them without checking types.

# Quote Method
Quote method in DeliveryCalculator class takes IDeliveryMethod, weight, and distance as argument and calculate cost per day using the formula ,

price / time;

This method checks for negative weight, negative distance, and division by zero and produce exception.

# Testing
I used MStest. I have tested price calculation , time estimation , different delivery methods, negative inputs , and SameDay distance limits.

# Limits I added
If the DeliveryCalculator class encounters any exception the value returned by the Quote method will be -1.
For SameDayDelivery there is a limit for distance which 300km. SameDay Delivery won't be done for distance more than 300 and the value returned by the EstimateTime() will be TimeSpan.Zero.

# Environment
The project builds and runs with Visual Studio Community 2022.
