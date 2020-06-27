using AirMonitor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AirMonitor.ViewModels
{
    public class DetailsViewModel: BaseViewModel
    {

        public DetailsViewModel(AllData data)
        {
            var Data = data.MeasurementItem.Indexes[0];
            var Values = data.MeasurementItem.Values;
            var Standards = data.MeasurementItem.Standards;
            CaqiValue = (int)(Math.Round(Data.Value));
            CaqiDescription = Data.Advice;
            CaqiTitle = Data.Description;
            Pm25Value = (int)(Math.Round(Values[1].Value));
            Pm25Percent = (int)(Math.Round(Standards[0].Percent));
            Pm10Value = (int)(Math.Round(Values[2].Value));
            Pm10Percent = (int)(Math.Round(Standards[1].Percent));
            PressureValue = (int)(Math.Round(Values[3].Value));
            HumidityValue = Values[4].Value/100;
        }

        private int _caqiValue;
        public int CaqiValue
        {
            get => _caqiValue;
            set => SetProperty(ref _caqiValue, value);
        }

        private string _caqiTitle;
        public string CaqiTitle
        {
            get => _caqiTitle;
            set => SetProperty(ref _caqiTitle, value);
        }

        private string _caqiDescription;
        public string CaqiDescription
        {
            get => _caqiDescription;
            set => SetProperty(ref _caqiDescription, value);
        }

        private int _pm25Value;
        public int Pm25Value
        {
            get => _pm25Value;
            set => SetProperty(ref _pm25Value, value);
        }

        private int _pm25Percent;
        public int Pm25Percent
        {
            get => _pm25Percent;
            set => SetProperty(ref _pm25Percent, value);
        }

        private int _pm10Value;
        public int Pm10Value
        {
            get => _pm10Value;
            set => SetProperty(ref _pm10Value, value);
        }

        private int _pm10Percent;
        public int Pm10Percent
        {
            get => _pm10Percent;
            set => SetProperty(ref _pm10Percent, value);
        }

        private double _humidityValue;
        public double HumidityValue
        {
            get => _humidityValue;
            set => SetProperty(ref _humidityValue, value);
        }

        private int _pressureValue;
        public int PressureValue
        {
            get => _pressureValue;
            set => SetProperty(ref _pressureValue, value);
        }
    }
}
