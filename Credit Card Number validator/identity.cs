using System;
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
    public partial class identity : Form
    {
        public identity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

#region Random Name
            Random name = new Random();
            string[] firstname = { "Jimmy", "Alisha", "Conner", "James", "Morgan", "Sally", "Adam", "Jamie", "Charlie", "Danny", "Noah", "Liam", "Mason", "Jacob", "William", "Ethan", "Michael", "Alexander", "Emma", "Olivia", "Sophia", "Ava", "Mia", "Emily", "Madison", "Charlotte" };
            string[] lastname = { "Henry", "Smith", "Paulis", "Hemmingsworth", "Peterson", "Southwick", "Sanchez", "DeVito", "Williams", "Brown", "Davis", "Lee", "Oswald", "Young", "Miller", "Martin", "Jackson", "Gonzalez", "Allen", "May", "Valdez", "Day", "Burton", "Dean", "Bueller", "Sims" };
            string resultName = firstname[name.Next(firstname.Length)] + " " + lastname[name.Next(lastname.Length)];
            textBox1.Text = resultName.ToString();
#endregion

#region Random Address
            try
            {
                Random address = new Random();
                string[] streetName = { "Smith" , "Tailfeather", "Scoop", "Rennault" , "Linger", "Scrim", "Lilac" , "Oasis", "Shore", "Candy","Sahara","Ling","Draft","Course"};
                string[] streetSuffix = { "Dr.", "St.", "Ln.", "Lp.", "Blvd" };
                string[] City = { "Helena", "Holiday", "Shingo", "Gaila", "Oldsmar", "Grenton", "Parston", "Lexington", "Remart", "Hepster" };
                string[] State = { "Maine", "Vermont", "New Hampshire", "New York", "Pennsylvania", "New Jersey", "Hawaii", "Illinois", "Oklahoma", "Colorado" };
                string resultStreet = address.Next(Math.Abs(1000), Math.Abs(10000)).ToString() + " " + streetName[address.Next(streetName.Length)].ToString() + ", " + 
                streetSuffix[address.Next(streetSuffix.Length)].ToString() + ", " + City[address.Next(City.Length)] + " " + State[address.Next(State.Length)] + " " + address.Next(Math.Abs(10000), Math.Abs(99999));
                textBox2.Text = resultStreet.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

#endregion

#region Random email
            try
            {
                Random email = new Random();
                string[] prefix = { "Grandma", "Sharklover", "Birdlover", "Sportsfreak", "Chips", "Pizza", "Refidgerator", "CarFiend" };
                string[] suffix = { "@Hotmail.com", "@Live.com", "@Yahoo.com", "@AOL.com", "@Gmail.com" };
                string resultemail = prefix[email.Next(prefix.Length)] + email.Next(Math.Abs(100)) + suffix[email.Next(suffix.Length)];
                textBox3.Text = resultemail.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
#endregion

#region random phone
            Random phone = new Random();
            int areaCode = phone.Next(100, 999);
            int mid = phone.Next(100, 999);
            int end = phone.Next(1000, 9999);

            string resultphone = areaCode.ToString() + " - " + mid.ToString() + " - " + end.ToString();
            textBox4.Text = resultphone.ToString();
#endregion


            #region random SSN
            Random ssn = new Random();
            int start = phone.Next(100, 999);
            int midssn = ssn.Next(10, 99);
            int endssn = phone.Next(1000, 9999);

            string resultssn = start.ToString() + " - " + midssn.ToString() + " - " + endssn.ToString();
            textBox5.Text = resultssn.ToString();
            #endregion


        }
        private void identity_Load(object sender, EventArgs e)
        {

        }
    }
}
