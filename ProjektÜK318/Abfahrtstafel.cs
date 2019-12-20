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
    public partial class Abfahrtstafel : Form
    {

        private StationBoardRoot stationBoard;
        private StationBoard selectedItem;
        private ITransport transport;

        public Abfahrtstafel()
        {
            InitializeComponent();
        }
        public Abfahrtstafel(Station station, ITransport transport)
        {
            InitializeComponent();
            stationBoard = transport.GetStationBoard(station.Name, station.Id);

            //eine Liste wird erstellt und in meine Liste kopiert
            IList<StationBoardViewModel> listArrivals = new List<StationBoardViewModel>();

            //Diese List gibt jetzt für jeden Vorhandenen eintrag einen Resultat zurück
            foreach (StationBoard arrival in stationBoard.Entries)
            {
                var stationBoardViewModel = new StationBoardViewModel
                {
                    DeparturePoint = station.Name,
                    DepartureTime = arrival.Stop.Departure.ToShortTimeString(),
                    ArrivalPoint = arrival.To
                };

                listArrivals.Add(stationBoardViewModel);
            }

            //Die Liste mit den Einträgen wird ausgegeben
            dataGrid_Ausgabe.DataSource = listArrivals;

            


        }

        public Abfahrtstafel(StationBoard selectedItem, ITransport transport)
        {
            this.selectedItem = selectedItem;
            this.transport = transport;
        }

        private void DataGrid_Ausgabe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Anzeigetafel_Load(object sender, EventArgs e)
        {

        }
    }
}
