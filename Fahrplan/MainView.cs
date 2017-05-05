﻿
using SwissTransport;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Fahrplan
{
    public partial class MainView : Form
    {
        private ITransport suche;

        public MainView() 
        {
            InitializeComponent();
            suche = new Transport();
        }
         
        // Sucht eine Verbindung von den beiden eingegebenen Stationen.
        private void Btn_suche_Click(object sender, EventArgs e)
        {
            var connections = suche.GetConnections(txtbox_von.Text, txtbox_nach.Text);

            Resultate.Items.Clear();
            
            // Zeigt jede mögliche verbindung an
            foreach (Connection result in connections.ConnectionList) {
                ConnectionPoint from = result.From;
                ConnectionPoint to = result.To;
                Resultate.Items.Add(("Von: " + from.Station.Name + "\n"
                    + " Abfahrt: " + ValidateDateTime(result.From.Departure) + "\n"
                    + " Nach: " + to.Station.Name + "\n"
                    + " Ankunft:" + ValidateDateTime(result.To.Arrival) + "\n"
                    + " Länge der Reise " + result.Duration));
                Console.WriteLine(result.From.Departure);
            }
        }
        // Zeigt alle Verbindungen von einer Station an
        private void Btn_abfahrtsortsuche_Click(object sender, EventArgs e)
        {
           
                suche = new Transport();
                Stations stations = suche.GetStations(txtbox_von.Text);
                Station station = stations.StationList[0];
                String id = station.Id;

                StationBoardRoot stationBoard = suche.GetStationBoard(txtbox_von.Text, id);

                Resultate.Items.Clear();



                // Zeigt die nächste möglichen Verbindungen an
                foreach (StationBoard result in stationBoard.Entries)
                {

                    Resultate.Items.Add(("Von: " + txtbox_von.Text + "\n"
                         + " Abfahrt: " + ValidateDateTime(result.Stop.Departure.ToString()) + "\n"
                         + " Nach: " + result.To));
                    Console.WriteLine(result.Name);

                }
            

        }
        // Leert alle felder
        private void Btn_neuesuche_Click(object sender, EventArgs e)
        {
            txtbox_von.ResetText();
            txtbox_nach.ResetText();
            Resultate.Items.Clear();

        }

        // Validiert die Zeit, das die Zeit keine Buchstaben beinhalten 
        private String ValidateDateTime(String time)

        {
            DateTimeOffset datetime = DateTimeOffset.Parse(time);
            String result = datetime.ToString();
            result = result.Split('+')[0];

            return result;

        }

        // Sucht Stationen für das Autocomplet
        public void StationSearch(ComboBox Box)
        {
            if (Box.Text.Count() > 2)
            {
                var stationfrom = suche.GetStations(Box.Text + ",");

                foreach (Station station in stationfrom.StationList)
                {
                    Box.Items.Add(station.Name);
                    Box.SelectionStart = Box.Text.Length;

                }
                Box.DroppedDown = true;
            }
        }

        // Komplettiert die suche automatisch für das Von Feld
            private void Txt_von_TextUpdate(object sender, EventArgs e)
            {
                try
                {
                    StationSearch(txtbox_von);
                }
                catch (Exception)
                {
                Resultate.Items.Add("Schreiben sie langsamer");
            }
            }
        // Komplettiert die suche automatisch für das Nach Feld
        private void Txt_nach_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                StationSearch(txtbox_nach);
            }
            catch (Exception)
            {
                Resultate.Items.Add("Schreiben sie langsamer");
            }
        }
    }
    }
    
