using System;

namespace TrafficLights.Models
{
    public class TrafficLight
    {
        private string firstSignal;
        private string secondSignal;
        private string thirdSignal;

        public TrafficLight(string firstSignal, string secondSignal, string thirdSignal)
        {
            this.firstSignal = firstSignal;
            this.secondSignal = secondSignal;
            this.thirdSignal = thirdSignal;
        }

        public void Shift()
        {
            string temp = this.thirdSignal;
            this.thirdSignal = this.secondSignal;
            this.secondSignal = this.firstSignal;
            this.firstSignal = temp;
        }

        public override string ToString()
        {
            return $"{this.firstSignal} {this.secondSignal} {this.thirdSignal}";
        }
    }
}
