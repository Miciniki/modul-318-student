using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
        /* Mit dem hier kann ich als parameter Date Time mitgeben */
        Connections GetConnectionsWithTime(string fromStation, string toStattion, DateTime time);

    }
}