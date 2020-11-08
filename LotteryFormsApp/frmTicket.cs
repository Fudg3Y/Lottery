using Lotto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryFormsApp
{
    public partial class frmTicket : Form
    {
        List<Ticket> tickets;
        Ticket currentTicket;

        public frmTicket()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnListTickets_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            var testTicket = new Ticket();
            testTicket.Name = txtName.Text;
            testTicket.PhoneNumber = txtPhone.Text;
            int[] balls = { Convert.ToInt32(txtBall1.Text), Convert.ToInt32(txtBall2.Text), Convert.ToInt32(txtBall3.Text), Convert.ToInt32(txtBall4.Text), Convert.ToInt32(txtBall5.Text), Convert.ToInt32(txtBall6.Text) };
            testTicket.Numbers = balls;
            

            tickets.Add(testTicket);
            currentTicket = testTicket;
            MessageBox.Show("Ticket Created", "Lottery", MessageBoxButtons.OK);
            displayTicket();
        }

        

        private void panelTicket_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void displayTicket()
        {
            pan.BackColor = Color.FromArgb(245, 245, 245);

            lblName.Text = currentTicket.Name;
            lblPhone.Text = currentTicket.PhoneNumber;
            lblBalls.Text = string.Join("",currentTicket.Numbers);
            

        }



        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblBalls_Click(object sender, EventArgs e)
        {

        }

        private void lblBalls_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBonusBall_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Ticket ticket in tickets)
            {
                lvTickets.Items.Add(ticket.ToString());
            }
        }

        private void lvTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
                Random random = new Random();
                
                txtBall1.Text = Convert.ToString(random.Next(1,49));
                txtBall2.Text = Convert.ToString(random.Next(1,49));
                txtBall3.Text = Convert.ToString(random.Next(1,49));
                txtBall4.Text = Convert.ToString(random.Next(1,49));
                txtBall5.Text = Convert.ToString(random.Next(1,49));
                txtBall6.Text = Convert.ToString(random.Next(1,49));
        }
    }
}
