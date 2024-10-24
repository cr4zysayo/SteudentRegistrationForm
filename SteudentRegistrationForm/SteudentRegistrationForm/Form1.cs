using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SteudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] courses = {
                "Bachelor of Science in Accounting Technology",
                "Bachelor of Science in Civil Engineering",
                "Bachelor of Science in Computer Engineering",
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Criminology",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Midwifery",
                "Bachelor of Science in Nursing",
                "Bachelor of Science in Psychology"
            };

            Program.Items.AddRange(courses);

            for (int i = 1; i <= 31; i++)
            {
                NumberDay.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                NumberMonth.Items.Add(i.ToString());
            }

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                NumberYear.Items.Add(i.ToString());
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegStudent_Click(object sender, EventArgs e)
        {
            string StudentName = Fname.Text + " " + Mname.Text + " " + Lname.Text;
            string gender = GenderMale.Checked ? "Male" : GenderFemale.Checked ? "Female" : "";

            string BDay = NumberDay.SelectedItem?.ToString();
            string BMonth = NumberMonth.SelectedItem?.ToString();
            string BYear = NumberYear.SelectedItem?.ToString();
            string SProgram = Program.SelectedItem?.ToString();

            string message = $"Student name: {StudentName}\nGender: {gender}\nDate of birth:{BMonth}/{BDay}/{BYear}\nProgram: {SProgram}";
            MessageBox.Show(message);
        }

        private void NumberDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }

        }
        private void RegStudent_Click(string message)
        {
            MessageBox.Show(message);
        }

        private void RegStudent_Click(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}
