using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fietsendiefstal
{
    public partial class Q1 : Form
    {
        public Q1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;sslmode=none";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT fdtabel.Buurt,bevolking, jaar, COUNT(Voorvalnummer) AS voorval FROM buurten, (SELECT fietsendiefstal.Buurt,Voorvalnummer,YEAR(STR_TO_DATE(Kennisname, \"%d-%m-%Y\")) AS jaar FROM fietsendiefstal) AS fdtabel WHERE buurten.buurt = fdtabel.Buurt AND jaar = 2011 AND bevolking > 7900 GROUP BY fdtabel.Buurt,bevolking, jaar ORDER BY bevolking ASC", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart2.Series["Population"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("bevolking"));






                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new home().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;sslmode=none";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT fdtabel.Buurt,bevolking, jaar, COUNT(Voorvalnummer) AS voorval FROM buurten, (SELECT fietsendiefstal.Buurt,Voorvalnummer,YEAR(STR_TO_DATE(Kennisname, \"%d-%m-%Y\")) AS jaar FROM fietsendiefstal) AS fdtabel WHERE buurten.buurt = fdtabel.Buurt AND jaar = 2011 AND bevolking > 7900 GROUP BY fdtabel.Buurt,bevolking, jaar ORDER BY bevolking DESC", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart1.Series["Population"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("bevolking"));
                    this.chart1.Series["Events"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("voorval"));




                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void jaar_Click(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click_1(object sender, EventArgs e)
        {
           




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dict = new Dictionary<int, string>();
            dict.Add(2324, "Toronto");
            dict.Add(64547, "Vancouver");
            dict.Add(42329, "Foobar");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;sslmode=none";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT fdtabel.Buurt,bevolking, jaar, COUNT(Voorvalnummer) AS voorval FROM buurten, (SELECT fietsendiefstal.Buurt,Voorvalnummer,YEAR(STR_TO_DATE(Kennisname, \"%d-%m-%Y\")) AS jaar FROM fietsendiefstal) AS fdtabel WHERE buurten.buurt = fdtabel.Buurt AND jaar = 2011 AND bevolking > 12000 GROUP BY fdtabel.Buurt,bevolking, jaar ORDER BY bevolking ASC;", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart1.Series["Population"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("bevolking"));
                    this.chart1.Series["Events"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("voorval"));






                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;sslmode=none";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT fdtabel.Buurt,bevolking, jaar, COUNT(Voorvalnummer) AS voorval FROM buurten, (SELECT fietsendiefstal.Buurt,Voorvalnummer,YEAR(STR_TO_DATE(Kennisname, \"%d-%m-%Y\")) AS jaar FROM fietsendiefstal) AS fdtabel WHERE buurten.buurt = fdtabel.Buurt AND jaar = 2011 AND bevolking > 10000 GROUP BY fdtabel.Buurt,bevolking, jaar ORDER BY bevolking ASC;", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart1.Series["Population"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("bevolking"));
                    this.chart1.Series["Events"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("voorval"));






                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;sslmode=none";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT fdtabel.Buurt,bevolking, jaar, COUNT(Voorvalnummer) AS voorval FROM buurten, (SELECT fietsendiefstal.Buurt,Voorvalnummer,YEAR(STR_TO_DATE(Kennisname, \"%d-%m-%Y\")) AS jaar FROM fietsendiefstal) AS fdtabel WHERE buurten.buurt = fdtabel.Buurt AND jaar = 2011 AND bevolking > 5000 GROUP BY fdtabel.Buurt,bevolking, jaar ORDER BY bevolking ASC;", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart2.Series["Population"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("bevolking"));
                    this.chart2.Series["Events"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("voorval"));






                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;sslmode=none";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT fdtabel.Buurt,bevolking, jaar, COUNT(Voorvalnummer) AS voorval FROM buurten, (SELECT fietsendiefstal.Buurt,Voorvalnummer,YEAR(STR_TO_DATE(Kennisname, \"%d-%m-%Y\")) AS jaar FROM fietsendiefstal) AS fdtabel WHERE buurten.buurt = fdtabel.Buurt AND jaar = 2011 AND bevolking > 12000 GROUP BY fdtabel.Buurt,bevolking, jaar ORDER BY bevolking ASC;", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart2.Series["Population"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("bevolking"));






                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;sslmode=none";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT fdtabel.Buurt,bevolking, jaar, COUNT(Voorvalnummer) AS voorval FROM buurten, (SELECT fietsendiefstal.Buurt,Voorvalnummer,YEAR(STR_TO_DATE(Kennisname, \"%d-%m-%Y\")) AS jaar FROM fietsendiefstal) AS fdtabel WHERE buurten.buurt = fdtabel.Buurt AND jaar = 2011 AND bevolking > 10000 GROUP BY fdtabel.Buurt,bevolking, jaar ORDER BY bevolking ASC;", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart2.Series["Population"].Points.AddXY(myReader.GetString("buurt"), myReader.GetInt32("bevolking"));






                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
