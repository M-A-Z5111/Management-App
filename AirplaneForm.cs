using FinalProject.Repositorys.Control;
using FinalProject.Repositorys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//The Graphics class provides methods for drawing to the display device
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Contains classes for creating Windows-based applications that take full advantage of the rich user interface features available in the Microsoft Windows operating system.
// An Event is placed on your Calendar with an option to invite others and set reminders leading up to the date and time of the occurrence.ya3me ma fi asyn w hodeh leshya
//A Task, on the other hand, is an activity that must be performed by a given date, think of it as an item on your to-do list.
//A class is a blueprint from which we can create objects that share the same configuration - properties and methods. An interface is a group of related properties and methods that describe an object, but neither provides implementation nor initialisation for them.
namespace FinalProject
{
    public partial class AirplaneForm : Form
    {
        public AirplaneForm()
        {

            InitializeComponent();

        }
        //EventArgs is also the class you use when an event doesn't have any data associated with it. When you create an event that is only meant to notify other classes that something happened and doesn't need to pass any data, include the EventArgs class as the second parameter in the delegate.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //.Onload calls Control.OnLoad which triggers the Load event
            loadDataAsync();
            this.airplanegv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.airplanegv.SelectionChanged += new EventHandler(airplanegv_SelectionChanged);
            //The event is the thing that RAISES an event, to which something will subscribe. The EventHandler is the thing that HANDLES an event - i.e. it specifies the method that is used to subscribe to the event.
        }

        private async Task loadDataAsync()
        {
            AirplaneDbAsync myairplanedb = new AirplaneDbAsync();
            List<Airplane> mylist = new List<Airplane>();
            mylist = await myairplanedb.GetAirplaneListAsync();
            airplanegv.DataSource = mylist;
        }
        private void Insertbt_Click(object sender, EventArgs e)
        {
            Insertbt_ClickAsync(sender, e);
        }
        private async Task Insertbt_ClickAsync(object sender, EventArgs e)
        {
            Airplane myairplane = new Airplane();
            myairplane.Owner = ownertb.Text;
            myairplane.Capacity = int.Parse(Capacitytb.Text);
            myairplane.DepartureTime = DateTime.Parse(DepartureTimetb.Text);
            myairplane.Color = Colortb.Text;
            AirplaneDbAsync airplanedb = new AirplaneDbAsync();
            await airplanedb.AddAirplaneAsync(myairplane);
            await loadDataAsync();



        }
        private void Deletebt_Click(object sender, EventArgs e)
        {
            Deletebt_ClickAsync(sender, e);
        }
        private async Task Deletebt_ClickAsync(object sender, EventArgs e)
        {

            Airplane myairplane = (Airplane)this.airplanegv.CurrentRow.DataBoundItem;
            AirplaneDbAsync airplanedb = new AirplaneDbAsync();
            await airplanedb.RemoveAirplaneAsync(myairplane);
            await loadDataAsync();

        }
        private void Updatebt_Click(object sender, EventArgs e)
        {
            Updatebt_ClickAsync(sender, e);
        }

        private async Task Updatebt_ClickAsync(object sender, EventArgs e)
        {
            Airplane myairplane = (Airplane)this.airplanegv.CurrentRow.DataBoundItem;

            myairplane.Owner = ownertb.Text;
            myairplane.Capacity = int.Parse(Capacitytb.Text);
            myairplane.DepartureTime = DateTime.Parse(DepartureTimetb.Text);
            myairplane.Color = Colortb.Text;
            AirplaneDbAsync airplanedb = new AirplaneDbAsync();
            await airplanedb.UpdateAirplaneAsync(myairplane);
            await loadDataAsync();


        }

        private void Refreshbt_Click(object sender, EventArgs e)
        {
            Refreshbt_ClickAsync(sender, e);
        }
        private async Task Refreshbt_ClickAsync(object sender, EventArgs e)
        {
            await loadDataAsync();
        }

        private void airplanegv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void airplanegv_SelectionChanged(object sender, EventArgs e)
        // The first parameter (sender) in the above declaration specifies the object that fired the event. The second parameter (e) of the above declaration holds data that can be used in the event handler
        {
            try
            {
                Airplane myairplane = (Airplane)this.airplanegv.CurrentRow.DataBoundItem;
                if (myairplane != null)
                {
                    this.ownertb.Text = myairplane.Owner;
                    this.Capacitytb.Text = myairplane.Capacity.ToString();
                    this.DepartureTimetb.Text = myairplane.DepartureTime.ToString();
                    this.Colortb.Text = myairplane.Color;



                }

            }
            catch (Exception ex) { return; }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String owner;
            owner = this.Searchtext.Text.Trim();
            this.Searchgv.AutoGenerateColumns = true;
            AirplaneDbAsync airplaneDbasync = new AirplaneDbAsync();
            List<Airplane> mylistbyname = new List<Airplane>();
            mylistbyname = airplaneDbasync.GetAirplaneByNameAsParallel(owner);
            Searchgv.DataSource = mylistbyname;

        }

       
    }
}
