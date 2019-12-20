using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektÜK318
{
    public partial class Anzeigetafel : Form
    {

        private StationBoardRoot stationBoard;
        public Anzeigetafel()
        {
            InitializeComponent();
        }
        public Anzeigetafel(Station station, ITransport transport)
        {
            InitializeComponent();
            stationBoard = transport.GetStationBoard(station.Name, station.Id);

            //eine Liste wird erstellt und in meine Liste kopiert
            IList<StationBoardViewModel> listArrivals = new List<StationBoardViewModel>();

            //Diese List gibt jetzt für jeden Vorhandenen eintrag einen Resultat zurück
            foreach (StationBoard arrival in stationBoard.Entries)
            {
                var stationBoardViewModel = new StationBoardViewModel();

                stationBoardViewModel.DeparturePoint = station.Name;
                stationBoardViewModel.DepartureTime = arrival.Stop.Departure.ToShortTimeString();
                stationBoardViewModel.ArrivalPoint = arrival.To;

                listArrivals.Add(stationBoardViewModel);
            }

            //Die Liste mit den Einträgen wird ausgegeben
            dataGrid_Ausgabe.DataSource = listArrivals;

            //dataGrid_Ausgabe.Columns.Add()


        }

        private void dataGrid_Ausgabe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Anzeigetafel_Load(object sender, EventArgs e)
        {

        }
    }
}
