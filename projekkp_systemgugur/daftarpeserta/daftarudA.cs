using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projekkp_systemgugur.daftarpeserta
{
    public partial class daftarudA : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        public daftarudA()
        {
            InitializeComponent();
        }
        public daftarudA(string terima) :
            this()
        {
            txtnama.Text=terima;
        }

        private void daftarudA_FormClosed(object sender, FormClosedEventArgs e)
        {
           pilihan f2 = new pilihan();
            f2.Show();
            this.Hide();
        }

        void refresh()
        {
            if (txtnama.Text == "Usia Dini Kelas A")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                //  cmd = new SqlCommand("select * from lakidb //where tbberat='Usia Dini'and tbkategori='TANDING' and tbkelas='A'", conn);
                cmd = new SqlCommand("select * from diniaP ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "diniaP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "diniaP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);
                
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                  
        
            label2.Text = dataGridView1.RowCount.ToString();
        


                }
                conn.Close();
            }


            else if (txtnama.Text == "Usia Dini Kelas H")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dinihP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dinihP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dinihP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Usia Dini Kelas i")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from diniP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "diniP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "diniP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }



            else if (txtnama.Text == "Usia Dini Kelas G")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dinigP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dinigP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dinigP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }


            else if (txtnama.Text == "Usia Dini Kelas F")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dinifP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dinifP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dinifP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Usia Dini Kelas E")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dinieP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dinieP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dinieP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }


            else if (txtnama.Text == "Usia Dini Kelas D")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dinidP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dinidP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dinidP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Pra Remaja Kelas A")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajaaP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajaaP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajaaP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }




            else if (txtnama.Text == "Dewasa Kelas I")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasaiP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasaiP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasaiP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Dewasa Kelas H")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasahP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasahP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasahP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Dewasa Kelas G")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasagP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasagP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasagP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Dewasa Kelas F")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasafP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasafP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasafP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Dewasa Kelas E")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasaeP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasaeP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasaeP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Dewasa Kelas D")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasadP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasadP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasadP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Dewasa Kelas A")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasaaP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasaaP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasaaP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Dewasa Kelas C")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasacP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasacP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasacP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Dewasa Kelas B")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dewasabP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dewasabP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dewasabP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Remaja Kelas I")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajaiP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajaiP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajaiP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Remaja Kelas H")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajahP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajahP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajahP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Remaja Kelas G")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajagP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajagP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajagP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Remaja Kelas F")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajafP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajafP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajafP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Remaja Kelas E")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajaeP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajaeP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajaeP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Remaja Kelas D")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajadP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajadP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajadP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Remaja Kelas C")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajacP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajacP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajacP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Remaja Kelas B")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajabP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajabP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajabP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Remaja Kelas A")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from remajaaP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "remajaaP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "remajaaP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Pra Remaja Kelas I")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajaiP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajaiP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajaiP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Pra Remaja Kelas H")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajahP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajahP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajahP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Pra Remaja Kelas G")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajagP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajagP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajagP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else if (txtnama.Text == "Pra Remaja Kelas F")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajafP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajafP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajafP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Pra Remaja Kelas E")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajaeP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajaeP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajaeP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Pra Remaja Kelas D")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajadP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajadP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajadP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Pra Remaja Kelas C")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajacP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajacP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajacP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Pra Remaja Kelas B")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from praremajabP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "praremajabP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "praremajabP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Usia Dini Kelas B")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dinibP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dinibP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dinibP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);
          
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }

            else if (txtnama.Text == "Usia Dini Kelas C")
            {
                SqlConnection conn = konn.Getconn();

                conn.Open();
                cmd = new SqlCommand("select * from dinicP", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dinicP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "dinicP";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
                da = new SqlDataAdapter(cmd);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    label2.Text = dataGridView1.RowCount.ToString();

                }


                conn.Close();
            }
            else
            {
                MessageBox.Show("hhhhh");
                
            }
               
               
        }


        void pindah()
        {
            if (label2.Text == "1")
            {
                MessageBox.Show("Karena jumlah peserta tidak memungkinkan maka kami putuskan TIDAK DI TANDINGKAN");
            }
            else if (label2.Text == "2")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bag2 f2 = new bagan.bag2(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "3")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan3 f2 = new bagan.bagan3(kiriman);
                f2.Show();
                this.Hide();
            }



            else if (label2.Text == "13")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan13 f2 = new bagan.bagan13(kiriman);
                f2.Show();
                this.Hide();
            }

            else if (label2.Text == "14")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan14 f2 = new bagan.bagan14(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "15")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan15 f2 = new bagan.bagan15(kiriman);
                f2.Show();
                this.Hide();
            }












            else if (label2.Text == "12")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan12 f2 = new bagan.bagan12(kiriman);
                f2.Show();
                this.Hide();
            }





            else if (label2.Text == "11")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan11 f2 = new bagan.bagan11(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "10")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan10 f2 = new bagan.bagan10(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "9")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan9 f2 = new bagan.bagan9(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "8")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan8 f2 = new bagan.bagan8(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "7")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan7 f2 = new bagan.bagan7(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "6")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan6 f2 = new bagan.bagan6(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "5")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan5 f2 = new bagan.bagan5(kiriman);
                f2.Show();
                this.Hide();
            }
            else if (label2.Text == "4")
            {
                string kiriman;
                kiriman = txtnama.Text;
                bagan.bagan4 f2 = new bagan.bagan4(kiriman);
                f2.Show();
                this.Hide();
            }


            else
            {
                MessageBox.Show("labas uy");
            }
        }



        private void daftarudA_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 300;
            if (panel2.Width >= 1400)
            {

                refresh();
                timer1.Stop();

            }
        }

        private void txtbagan_Click(object sender, EventArgs e)
        {
            pindah();
        }

        private void daftarudA_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
