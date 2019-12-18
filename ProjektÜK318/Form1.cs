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
    

    public partial class Form1 : Form
    {
        private Transport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LabelDatum_Click(object sender, EventArgs e)
        {

        }

        private void buttonVerbindungsuchen_Click(object sender, EventArgs e)
        {
            var Abfahrtsort = Convert.ToString(comboBoxAbfahrtsort.Text);

            var Route = Convert.ToString(transport.GetConnections(from VAR in Abfahrtsort ));
            treeView1.Show(Route);
        }

        private void comboBoxAbfahrtsort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAbfahrtsort_DropDown(object sender, EventArgs e)
        {
                var Abfahrtsort = Convert.ToString(comboBoxAbfahrtsort.Text);
                transport.GetStations(Abfahrtsort);
                Stations stations = transport.GetStations(Abfahrtsort);
                comboBoxAbfahrtsort.Items.Clear();
                foreach (Station station in stations.StationList)
                {
                    comboBoxAbfahrtsort.Items.Add(station.Name);
                }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
