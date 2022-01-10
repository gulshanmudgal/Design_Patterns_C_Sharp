// See https://aka.ms/new-console-template for more information
using Observer_Pattern.Observers;
using Observer_Pattern.Subjects;


WeatherStation weatherStation = new WeatherStation();
weatherStation.SetMeasurements(36.7, 44.2, 30.04);

ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherStation);

weatherStation.SetMeasurements(36.8, 44.2, 30.04);
weatherStation.SetMeasurements(36.9, 44.2, 30.04);