﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credit_Card_Number_validator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Todo: only display numbers that pass the luhn algorithm if generated
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        bool Mod10Check(string creditCardNumber)
        {

            int sumOfDigits = 0;
            int index = 0;
            foreach (int digit in creditCardNumber.Where(e => e >= '0' && e <= '9').Reverse())
            {
                int temp = (index % 2 == 0) ? digit - 48 : (digit - 48) * 2;
                sumOfDigits += temp < 10 ? temp : temp - 9;
                index++;
            }

            return sumOfDigits % 10 == 0;
        }

        public void button1_Click(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text.Length < 16)
            {
                MessageBox.Show("Card number not long enough","Invalid card number");

            }
            else
            {
                string a = maskedTextBox1.Text;
                bool isValid = Mod10Check(a);
                if (isValid == true)
                {
                    label1.Text = "Valid";
                }
                else
                {
                    label1.Text = "Invalid";
                }

            }
                 

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }
        long longRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }
        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void visaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                long r = longRandom(Math.Abs(4000000000000000), Math.Abs(4999999999999999), new Random());
                string input = maskedTextBox1.Text;
                bool isValid = Mod10Check(input);


            }
            catch (Exception vex)
            {
                MessageBox.Show(vex.ToString());
            }
        }

        private void discoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                long r = longRandom(Math.Abs(6000000000000000), Math.Abs(6999999999999999), new Random());
                maskedTextBox1.Text = r.ToString();
            }
            catch (Exception exd)
            {
                MessageBox.Show(exd.ToString());
            }

        }

        private void masterCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                long r = longRandom(Math.Abs(5000000000000000), Math.Abs(5999999999999999), new Random());
                maskedTextBox1.Text = r.ToString();
            }
            catch (Exception mex)
            {
                MessageBox.Show(mex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void fakeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            identity newForm = new identity();
            newForm.Show();
            Random address = new Random();
            string[] streetName = { "Smith", "Tailfeather", "Scoop", "Rennault", "Linger", "Scrim", "Lilac", "Oasis", "Shore", "Candy", "Sahara", "Ling", "Draft", "Course" };
            string[] streetSuffix = { "Dr.", "St.", "Ln.", "Lp.", "Blvd" };
            string[] City = { "Helena", "Holiday", "Shingo", "Gaila", "Oldsmar", "Grenton", "Parston", "Lexington", "Remart", "Hepster" };
            string[] State = { "Maine", "Vermont", "New Hampshire", "New York", "Pennsylvania", "New Jersey", "Hawaii", "Illinois", "Oklahoma", "Colorado" };
            string resultStreet = address.Next(Math.Abs(1000), Math.Abs(10000)).ToString() + " " + streetName[address.Next(streetName.Length)].ToString() + ", " +
            streetSuffix[address.Next(streetSuffix.Length)].ToString() + ", " + City[address.Next(City.Length)] + " " + State[address.Next(State.Length)] + " " + address.Next(Math.Abs(10000), Math.Abs(99999));
            
        }

    }
}
