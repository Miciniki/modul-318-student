using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
using System.IO;

namespace ProjektÜK318
{
    

    public partial class Nikola : Form
    {
        private ITransport transport;

        public Nikola()
        {
            

            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Value = DateTime.Now;

            transport = new Transport();
            
        }
        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            btn_Suchen.BackColor = Color.SkyBlue;
            listBox_Ausgabe.Items.Clear();

            //Falls Ankunftsort angegeben wurde, werden die Verbindungen angezeigt
            if (comboBox_Ankunftsort.Text != "" && comboBox_Abfahrtsort.Text != "")
            {

                comboBox_Abfahrtsort.SelectedIndex = 0;
                comboBox_Ankunftsort.SelectedIndex = 0;
                Connections connections = transport.GetConnectionsWithTime(((string)comboBox_Abfahrtsort.SelectedItem), ((string)comboBox_Ankunftsort.SelectedItem), dateTimePicker1.Value);


                //Es werden bis zu Vier verbindungen angezeigt
                foreach (var connection in connections.ConnectionList)
                {
                    var departure = Convert.ToDateTime(connection.From.Departure);
                    var arrival = Convert.ToDateTime(connection.To.Arrival);


                    var obj = connection.Duration.Split('d');
                    var obj2 = obj[1].Split(':');

                    //sorgt für eine schönere Ausgabe beim benuzer
                    var customStringDeparture = String.Format("{0} Uhr {1} Minuten", departure.Hour, departure.Minute);
                    var customStringArrival = String.Format("{0} Uhr {1} Minuten", arrival.Hour, arrival.Minute);
                    var customStringDuration = String.Format("{0} Minuten", int.Parse(obj2[0]) * 60 + int.Parse(obj2[1]));
                    
                    listBox_Ausgabe.Items.Add(customStringDeparture + "               " + customStringDuration + "               " + customStringArrival);
                }
            }
            //Falls nur Abfahrtsort angegeben, sollte Abfahrttafel erscheinen
            else if (comboBox_Abfahrtsort.Text != "" && comboBox_Ankunftsort.Text == "")
            {

                new Anzeigetafel((Station)comboBox_Abfahrtsort.SelectedItem, transport).Show();

            }

            else
            {
                MessageBox.Show("Bitte geben Sie einen Abfahrtsort ein");
                btn_Suchen.BackColor = Color.Red;
            }
        }
        private void UserInput(ComboBox input)
        {

            if (input.Text != string.Empty)
            {

                var text = input.Text;
                var newStations = transport.GetStations(input.Text);

                //ist für Autofill zuständig
                if (newStations.StationList.Count > 0)
                {
                    input.Items.Clear();
                   foreach(var s in newStations.StationList)
                    {
                        input.Items.Add(s.Name);
                    }
                  
                    }
            }
            else
            {

                MessageBox.Show("Es wurde keine Station mit ihrer Eingabe gefunden");

            }
        }

        private void comboBox_Abfahrtsort_TextUpdate(object sender, EventArgs e)
        {
            ComboBox input = comboBox_Abfahrtsort;
            UserInput(input);

        }

        private void comboBox_Ankunftsort_TextUpdate(object sender, EventArgs e)
        {
            ComboBox input = comboBox_Ankunftsort;
            UserInput(input);
        }


        private void Nikola_Load(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Russia;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void button_Mail_Click(object sender, EventArgs e)
        {

            /* Ist für das versenden von mails zuständig
             funktioniert noch nicht einwandfrei*/

            MailMessage message = new MailMessage();
            //SmtpClient smtp = new SmtpClient("192.168.0.113", 25);
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";

            message.From = new MailAddress("niemalspommfritt@gmail.com");
            message.To.Add(new MailAddress("niemalspommfritt@gmail.com"));
            message.Subject = "SBB Verbindungen";

            var body = string.Empty;

            foreach (var item in listBox_Ausgabe.Items)
            {
                body += (string)item;
            }

            message.Body = body;

            client.Send(message);
        }

        private void button_Help_Click_1(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Sie werden mit unserem Kompetentesten Mitarbeiter reden dürfen", "TopHilfe.Nikola", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    System.Diagnostics.Process.Start("https://www.google.com/");
            
        }

        private void button_Sponoring_Click_1(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://m.benedict.ch/");
        }

        private void button_Mail_Click_1(object sender, EventArgs e)
        {

        }
    }
}
