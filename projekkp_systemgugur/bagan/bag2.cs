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
namespace projekkp_systemgugur.bagan
{
    public partial class bag2 : Form
    {
        private SqlCommand cmd;

        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        public bag2()
        {
            InitializeComponent();
           
        }
         public bag2(string terima) :
            this()
        {
            label1.Text=terima;
        }
        private void b1_Click(object sender, EventArgs e)
        {
           
        }

        private void b2_Click(object sender, EventArgs e)
        {
           
        }

        private void b11_Click(object sender, EventArgs e)
        {
            b33.Text = b11.Text;
            b22.Enabled = false;
            b22.BackColor = Color.Black;
        }

        private void b22_Click(object sender, EventArgs e)
        {
            b33.Text = b22.Text;
            b11.Enabled = false;
            b11.BackColor = Color.Black;
           
        }


        void diniA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void praremajai()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaiA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasai1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasai2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasah1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasah2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasag1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasag2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasaf1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaf2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasae2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasad2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasac2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasab2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dewasaa1()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dewasaa2()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
	





        void praremajah()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaAh()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }




        void praremajag()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaAg()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }





        void praremajaf()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajafA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }





        void praremajae()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaAe()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }




        void praremajaea()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }




        void praremajada()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajadA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }





        void praremajaca()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajacA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }




        void praremajaba()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajabA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }





        void praremajaa()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void praremajaA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        void remajai()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaiA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajah()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaAh()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajag()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaAg()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajafs()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajafA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajae()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaAe()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        
        void remajaea()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        

        void remajada()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajadaA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void remajaca()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajacA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        
        void remajaba()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajabA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    
        void remajaa()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void remajaA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }





        void diniiA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAai()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void dinihA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAha()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinigA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAga()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        void diniAf()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAaf()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void diniAe()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAea()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAd()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAda()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void dinicA()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAc()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void diniAa()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1); label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void diniAbb()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='1' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b11.Text = sdr.GetString(1); label3.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void diniAb()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='2' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b22.Text = sdr.GetString(1);
                        label4.Text = sdr.GetString(2);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

         void masingmasingbagan()
        {
            if (label1.Text == "Usia Dini Kelas A")
            {
                diniA();
                diniAa();
            }
            else if (label1.Text == "Usia Dini Kelas B")
            {
                diniAb();
                diniAbb();
            }
            else if (label1.Text == "Usia Dini Kelas C")
            {
                dinicA();
                diniAc();
            }
            else if (label1.Text == "Usia Dini Kelas D")
            {
                diniAd();
                diniAda();
            }
            else if (label1.Text == "Usia Dini Kelas E")
            {
                diniAe();
                diniAea();
            }
            else if (label1.Text == "Usia Dini Kelas F")
            {
                diniAaf();
                diniAf();
            }
            else if (label1.Text == "Usia Dini Kelas G")
            {
                diniAga();
                dinigA();
            }
            else if (label1.Text == "Usia Dini Kelas H")
            {
                diniAha();
                dinihA();
            }
            else if (label1.Text == "Usia Dini Kelas I")
            {
                diniiA();
                diniAai();
            }
            else if (label1.Text == "Pra Remaja Kelas A")
            {
                praremajaa();
                praremajaA();
            }
            else if (label1.Text == "Pra Remaja Kelas B")
            {
                praremajaba();
                praremajabA();
            }
            else if (label1.Text == "Pra Remaja Kelas C")
            {
                praremajaca();
                praremajacA();
            }
            else if (label1.Text == "Pra Remaja Kelas D")
            {
               praremajada();
                praremajadA();
            }
            else if (label1.Text == "Pra Remaja Kelas E")
            {
                praremajae();
                praremajaea();
            }
            else if (label1.Text == "Pra Remaja Kelas F")
            {
                praremajafA();
                praremajaf();
            }
            else if (label1.Text == "Pra Remaja Kelas G")
            {
                praremajag();
                praremajaAg();
            }
            else if (label1.Text == "Pra Remaja Kelas H")
            {
                praremajah();
                praremajaAh();
            }
            else if (label1.Text == "Pra Remaja Kelas I")
            {
                praremajai();
                praremajaiA();
            }
            else if (label1.Text == "Remaja Kelas A")
            {
                remajaa();
                remajaA();
            }
            else if (label1.Text == "Remaja Kelas B")
            {
                remajaba();
                remajabA();
            }
            else if (label1.Text == "Remaja Kelas C")
            {
                remajaca();
                remajacA();
            }
            else if (label1.Text == "Remaja Kelas D")
            {
                remajada();
                remajadaA();
            }
            else if (label1.Text == "Remaja Kelas E")
            {
                remajae();
                remajaea();
            }
            else if (label1.Text == "Remaja Kelas F")
            {
                remajafA();
                remajafs();
            }
            else if (label1.Text == "Remaja Kelas G")
            {
                remajag();
                remajaAg();
            }
            else if (label1.Text == "Remaja Kelas H")
            {
                remajah();
                remajaAh();
            }
            else if (label1.Text == "Remaja Kelas I")
            {
                remajai();
                remajaiA();
            }
            else if (label1.Text == "Dewasa Kelas A")
            {
                dewasaa1();
                dewasaa2();
            }
            else if (label1.Text == "Dewasa Kelas B")
            {
                dewasab1();
                dewasab2();
            }
            else if (label1.Text == "Dewasa Kelas C")
            {
                dewasac1();
                dewasac2();
            }
            else if (label1.Text == "Dewasa Kelas D")
            {
                dewasad1();
                dewasad2();
            }
            else if (label1.Text == "Dewasa Kelas E")
            {
                dewasae1();
                dewasae2();
            }
            else if (label1.Text == "Dewasa Kelas F")
            {
                dewasaf1();
                dewasaf2();
            }
            else if (label1.Text == "Dewasa Kelas G")
            {
                dewasag1();
                dewasag2();
            }
            else if (label1.Text == "Dewasa Kelas H")
            {
                dewasah1();
                dewasah2();
            }
            else if (label1.Text == "Dewasa Kelas I")
            {
                dewasai1();
                dewasai2();
            }
            else
            {
                MessageBox.Show("coba lagi");
            }
        }
        private void bag2_Load(object sender, EventArgs e)
        {

        }

        private void b33_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 300;
            if (panel1.Width >= 1400)
            {

                masingmasingbagan();
                timer1.Stop();

            }
        }
    }
}
