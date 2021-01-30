using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Door_sensor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        void open_door()
        {
// method to open the door written by Awsan Al-Haroji
            if (pnl_right.Width == 0)
            {
                pnl_right.Width = 279;
                

                btn_lamp.Hide();
                panel1.BackColor = Color.Green;

            }
            

        }  // this fun for open door

   // method to close the door written by Awsan Al-Haroji     void close_door()
        {

            if (pnl_right.Width != 0)
            {
          
                pnl_right.Width = 0;
                panel1.BackColor = Color.Red;


            }
        }  // this fun for close door
        void adman()
        {
            var state = MessageBox.Show("هل ترغب في عملية اغلاق البوابة بشكل طارئ", "اغلاق ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (state == DialogResult.Yes)
            {
                panel1.Enabled = false;
            }
        }              // this for admin
        void emergences()
        {

// Function to open door immediately when there is a an emergency situation written by Mohammad Al-Qabili
            SoundPlayer sound = new SoundPlayer("awsan.wav");
            sound.Play();
            pnl_right.Width = 279;
            btn_lamp.Hide();
            panel1.BackColor = Color.Green;
            panel1.Enabled = false;

        }      //this for emergency
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
              

        }
        int cou = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (pnl_right.Width == 0)
            {

                open_door();
            }
            
            else
            {
                close_door();
            }

        }

        private void pnl_cont_Paint(object sender, PaintEventArgs e)
        {
            pnl_right.Width = 0;
                btn_lamp.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            open_door();
           
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
           
         
        }

       

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
           

        }

        private void panel1_MouseEnter_1(object sender, EventArgs e)
        {

            open_door();
        }
            
           

        
//this function is for closing the door the moment the cursor 
//leaves the line beneath the door 
//I'll add Thread.Sleep so the door wait a 200 ms and close 
//Edited By Nour Addin Khalil 
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            close_door();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
       

        private void button7_Click(object sender, EventArgs e)
        {
            count++;

            emergences();
        }
        int count = 0;
        private void button7_Click_1(object sender, EventArgs e)
        {
            adman();
           
        }
    }
}
