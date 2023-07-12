using FinalProject.Repositorys.Control;
using FinalProject.Repositorys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class TravelerForm : Form
    {
        public TravelerForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadDataAsync();
            this.travelergv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.travelergv.SelectionChanged += new EventHandler(travelergv_SelectionChanged);
        }

        private async Task loadDataAsync()
        {
            TravelerDBAsync travelerDB = new TravelerDBAsync();
            List<Traveler> mylist = new List<Traveler>();
            mylist = await travelerDB.GetTravelerListAsync();
            travelergv.DataSource = mylist;
        }
        private void insertb_Click(object sender, EventArgs e)
        {
            insertb_ClickAsync(sender, e);
        }

        private async Task insertb_ClickAsync(object sender, EventArgs e)
        {
            Traveler mytraveler = new Traveler();
            mytraveler.Name = this.nametb.Text;
            mytraveler.Age = int.Parse(this.agetb.Text);
            mytraveler.AllowedWeight = double.Parse(this.weighttb.Text);
            mytraveler.Destination = this.destinationtb.Text;
            TravelerDBAsync travelerDB = new TravelerDBAsync();
            await travelerDB.AddTravelerAsync(mytraveler);
            await loadDataAsync();

        }
        private void deleteb_Click(object sender, EventArgs e)
        {
            deleteb_ClickAsync(sender, e);
        }

        private async Task deleteb_ClickAsync(object sender, EventArgs e)
        {
            Traveler mytraveler = (Traveler)this.travelergv.CurrentRow.DataBoundItem;
            TravelerDBAsync travelerDB = new TravelerDBAsync();
            await travelerDB.RemoveTravelerAsync(mytraveler);
            await loadDataAsync();



        }
        private void updateb_Click(object sender, EventArgs e)
        {
            updateb_ClickAsync(sender, e);
        }

        private async Task updateb_ClickAsync(object sender, EventArgs e)
        {
            Traveler mytraveler = (Traveler)this.travelergv.CurrentRow.DataBoundItem;
            mytraveler.Name = this.nametb.Text;
            mytraveler.Age = int.Parse(this.agetb.Text);
            mytraveler.AllowedWeight = double.Parse(this.weighttb.Text);
            mytraveler.Destination = this.destinationtb.Text;
            TravelerDBAsync travelerDB = new TravelerDBAsync();
            await travelerDB.UpdateTravelerAsync(mytraveler);
            await loadDataAsync();


        }

        private void refreshb_Click(object sender, EventArgs e)
        {
            refreshb_ClickAsync(sender, e);
        }
        private async Task refreshb_ClickAsync(object sender, EventArgs e)
        {
            await loadDataAsync();
        }

        private void travelergv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void travelergv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Traveler mytraveler = (Traveler)this.travelergv.CurrentRow.DataBoundItem;
                if (mytraveler != null)
                {
                    this.nametb.Text = mytraveler.Name;
                    this.agetb.Text = mytraveler.Age.ToString();
                    this.weighttb.Text = mytraveler.AllowedWeight.ToString();
                    this.destinationtb.Text = mytraveler.Destination;



                }

            }
            catch (Exception ex) { return; }

        }


    }
}
