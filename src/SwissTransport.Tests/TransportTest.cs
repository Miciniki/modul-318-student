// <copyright file="TransportTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissTransport;

namespace SwissTransport.Tests
{
    /// <summary>Diese Klasse enthält parametrisierte Komponententests für Transport.</summary>
    [PexClass(typeof(Transport))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TransportTest
    {
        /// <summary>Test-Stub für GetConnections(String, String)</summary>
        [PexMethod]
        public Connections GetConnectionsTest(
            [PexAssumeUnderTest]Transport target,
            string fromStation,
            string toStattion
        )
        {
            Connections result = target.GetConnections(fromStation, toStattion);
            return result;
            // TODO: Assertionen zu Methode TransportTest.GetConnectionsTest(Transport, String, String) hinzufügen
        }

        /// <summary>Test-Stub für GetConnectionsWithTime(String, String, DateTime)</summary>
        [PexMethod]
        public Connections GetConnectionsWithTimeTest(
            [PexAssumeUnderTest]Transport target,
            string fromStation,
            string toStation,
            DateTime time
        )
        {
            Connections result = target.GetConnectionsWithTime(fromStation, toStation, time)
              ;
            return result;
            // TODO: Assertionen zu Methode TransportTest.GetConnectionsWithTimeTest(Transport, String, String, DateTime) hinzufügen
        }

        /// <summary>Test-Stub für GetStationBoard(String, String)</summary>
        [PexMethod]
        public StationBoardRoot GetStationBoardTest(
            [PexAssumeUnderTest]Transport target,
            string station,
            string id
        )
        {
            StationBoardRoot result = target.GetStationBoard(station, id);
            return result;
            // TODO: Assertionen zu Methode TransportTest.GetStationBoardTest(Transport, String, String) hinzufügen
        }

        /// <summary>Test-Stub für GetStations(String)</summary>
        [PexMethod]
        public Stations GetStationsTest([PexAssumeUnderTest]Transport target, string query)
        {
            Stations result = target.GetStations(query);
            return result;
            // TODO: Assertionen zu Methode TransportTest.GetStationsTest(Transport, String) hinzufügen
        }
    }
}
