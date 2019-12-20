using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class StationBoardRoot
    {
        [JsonProperty("Station")]
        public Station Station { get; set; }

        [JsonProperty("stationboard")]
        public List<StationBoard> Entries { get; set; }
    }

    public class StationBoard
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("stop")]
        public Stop Stop { get; set; }
        /// <summary>
        /// Die ToString methode wird überschrieben, dass heisst das sie jetzt nicht "To String" macht, sondern es gibt "To" + "Stop" aus das habe ich nur aus dem Grund gemacht, da ich es nicht schaffe sauber die Mathode Stop.Departure aufzurufen 
        /// </summary>
        /// <returns> Ankunftsort und die Ankunftszeit</returns>
        public override string ToString()
        {
            return string.Format(" To: {0}, Stop: {1}",
                To,
                Stop.Departure.ToLongTimeString());
        }
    }

    /// <summary>
    /// Diese methode wird für den Aufruf von der Anzeigetafel verwendet so kann ich später diese Elemente einfacher beschreiben und auslesen 
    /// </summary>
    public class StationBoardViewModel
    {
        public string DeparturePoint { get; set; }

        public string ArrivalPoint { get; set; }

        public string DepartureTime { get; set; }
    }


    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }
    }
}