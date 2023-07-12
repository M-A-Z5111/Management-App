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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadDataAsync();
            this.ticketgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ticketgv.SelectionChanged += new EventHandler(ticketgv_SelectionChanged);
        }

        private async Task loadDataAsync()
        {
            TicketDBasync myticketdb = new TicketDBasync();
            List<Ticket> mylist = new List<Ticket>();
            mylist = await myticketdb.GetTicketListAsync();
            ticketgv.DataSource = mylist;
        }
        private void insertb_Click(object sender, EventArgs e)
        {
            insertb_ClickAsync(sender, e);
        }
        private async Task insertb_ClickAsync(object sender, EventArgs e)
        {
            TicketDBasync ticketDB = new TicketDBasync();
            Ticket ticket = new Ticket();
            ticket.Price = double.Parse(this.pricetb.Text);
            ticket.Seatnb = this.seattb.Text;
            ticket.Tripnb = this.triptb.Text;
            await ticketDB.AddTicketAsync(ticket);
            await loadDataAsync();



        }
        private void deleteb_Click(object sender, EventArgs e)
        {
            deleteb_ClickAsync(sender, e);
        }

        private async Task deleteb_ClickAsync(object sender, EventArgs e)
        {

            Ticket ticket = (Ticket)this.ticketgv.CurrentRow.DataBoundItem;
            TicketDBasync ticketDB = new TicketDBasync();
            await ticketDB.RemoveTicketAsync(ticket);
            await loadDataAsync();

        }
        private void updateb_Click(object sender, EventArgs e)
        {
            updateb_ClickAsync(sender, e);
        }

        private async Task updateb_ClickAsync(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)this.ticketgv.CurrentRow.DataBoundItem;
            TicketDBasync ticketDB = new TicketDBasync();
            ticket.Price = double.Parse(this.pricetb.Text);
            ticket.Seatnb = this.seattb.Text;
            ticket.Tripnb = this.triptb.Text;
            await ticketDB.UpdateTicketAsync(ticket);
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
        private void ticketgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ticketgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = (Ticket)this.ticketgv.CurrentRow.DataBoundItem;
                if (ticket != null)
                {
                    this.pricetb.Text = ticket.Price.ToString();
                    this.seattb.Text = ticket.Seatnb;
                    this.triptb.Text = ticket.Tripnb;




                }

            }
            catch (Exception ex) { return; }

        }


    }
}
