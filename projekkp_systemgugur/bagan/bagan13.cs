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
    public partial class bagan13 : Form
    {
        private SqlCommand cmd;

        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        public bagan13()
        {
            InitializeComponent();
        }
         public bagan13(string terima) :
            this()
        {
            label1.Text=terima;
        }
        private void bagan13_Load(object sender, EventArgs e)
        {

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


        void remajaa13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void remajab13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void remajac13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void remajad13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void remajae13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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


        void remajaf13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void remajag13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void remajah13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void remajai13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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


        void dinia13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dinib13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dinic13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dinid13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dinie13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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


        void dinif13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void dinig13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void dinih13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void dinii13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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



        void dewasaa13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dewasab13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dewasac13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dewasad13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void dewasae13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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


        void dewasaf13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void dewasag13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void dewasah13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void dewasai13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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



        void praremajaa13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void praremajab13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void praremajac13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void praremajad13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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
        void praremajae13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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


        void praremajaf13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void praremajag13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void praremajah13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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

        void praremajai13()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='13' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b117.Text = sdr.GetString(1); label14.Text = sdr.GetString(2);
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





        void remajaa12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void remajab12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void remajac12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void remajad12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void remajae12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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


        void remajaf12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void remajag12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void remajah12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void remajai12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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


        void dinia12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dinib12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dinic12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dinid12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dinie12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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


        void dinif12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void dinig12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void dinih12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void dinii12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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



        void dewasaa12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dewasab12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dewasac12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dewasad12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void dewasae12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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


        void dewasaf12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void dewasag12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void dewasah12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void dewasai12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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



        void praremajaa12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void praremajab12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void praremajac12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void praremajad12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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
        void praremajae12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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


        void praremajaf12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void praremajag12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void praremajah12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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

        void praremajai12()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='12' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b116.Text = sdr.GetString(1); label10.Text = sdr.GetString(2);
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





        void remajaa11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void remajab11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void remajac11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void remajad11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void remajae11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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


        void remajaf11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void remajag11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void remajah11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void remajai11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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


        void dinia11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dinib11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dinic11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dinid11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dinie11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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


        void dinif11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void dinig11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void dinih11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void dinii11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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



        void dewasaa11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dewasab11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dewasac11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dewasad11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void dewasae11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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


        void dewasaf11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void dewasag11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void dewasah11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void dewasai11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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



        void praremajaa11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void praremajab11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void praremajac11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void praremajad11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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
        void praremajae11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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


        void praremajaf11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void praremajag11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void praremajah11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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

        void praremajai11()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='11' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b115.Text = sdr.GetString(1); label13.Text = sdr.GetString(2);
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






        void praremajaa10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void praremajab10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void praremajac10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void praremajad10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void praremajae10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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


        void praremajaf10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void praremajag10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void praremajah10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void praremajai10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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




        void dewasaa10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dewasab10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dewasac10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dewasad10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dewasae10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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


        void dewasaf10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void dewasag10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void dewasah10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void dewasai10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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



        void dinia10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dinib10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dinic10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dinid10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void dinie10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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


        void dinif10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void dinig10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void dinih10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void dinii10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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



        void remajaa10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void remajab10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void remajac10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void remajad10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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
        void remajae10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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


        void remajaf10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void remajag10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void remajah10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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

        void remajai10()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='10' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b114.Text = sdr.GetString(1); label12.Text = sdr.GetString(2);
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



        void remajaa8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void remajaa9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void remajab9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void remajac9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void remajad9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void remajae9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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


        void remajaf9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void remajag9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void remajah9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void remajai9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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


        void dinia9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dinib9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dinic9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dinid9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dinie9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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


        void dinif9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void dinig9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void dinih9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void dinii9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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



        void dewasaa9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dewasab9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dewasac9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dewasad9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void dewasae9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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


        void dewasaf9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void dewasag9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void dewasah9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void dewasai9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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



        void praremajaa9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void praremajab9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void praremajac9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void praremajad9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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
        void praremajae9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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


        void praremajaf9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void praremajag9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void praremajah9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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

        void praremajai9()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='9' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b113.Text = sdr.GetString(1); label11.Text = sdr.GetString(2);
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





        void remajab8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void remajac8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void remajad8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void remajae8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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


        void remajaf8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void remajag8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void remajah8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void remajai8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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


        void dinia8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dinib8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dinic8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dinid8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dinie8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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


        void dinif8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void dinig8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void dinih8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void dinii8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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



        void dewasaa8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dewasab8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dewasac8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dewasad8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void dewasae8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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


        void dewasaf8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void dewasag8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void dewasah8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void dewasai8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void praremajaa8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void praremajab8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void praremajac8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void praremajad8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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
        void praremajae8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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


        void praremajaf8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void praremajag8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void praremajah8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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

        void praremajai8()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='8' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b112.Text = sdr.GetString(1); label9.Text = sdr.GetString(2);
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




        void dewasaa7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dewasab7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dewasac7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dewasad7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dewasae7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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


        void dewasaf7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void dewasag7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void dewasah7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void dewasai7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dinia7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dinib7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dinic7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dinid7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void dinie7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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


        void dinif7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void dinig7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void dinih7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void dinii7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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




        void praremajaa7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void praremajab7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void praremajac7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void praremajad7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void praremajae7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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


        void praremajaf7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void praremajag7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void praremajah7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void praremajai7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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









        void remajaa6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void remajab6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void remajac6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void remajad6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void remajae6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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


        void remajaf6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void remajag6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void remajah6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void remajai6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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


        void dinia6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dinib6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dinic6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dinid6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dinie6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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


        void dinif6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void dinig6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void dinih6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void dinii6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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



        void dewasaa6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dewasab6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dewasac6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dewasad6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void dewasae6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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


        void dewasaf6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void dewasag6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void dewasah6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void dewasai6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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



        void praremajaa6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void praremajab6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void praremajac6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void praremajad6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void praremajae6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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


        void praremajaf6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void praremajag6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void praremajah6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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

        void praremajai6()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='6' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b1010.Text = sdr.GetString(1); label7.Text = sdr.GetString(2);
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
        void remajaa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void remajab3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void remajac3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void remajad3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void remajae3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void remajaf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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

        void remajag3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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

        void remajah3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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

        void remajai3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void diniAa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void diniAc3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void diniAd3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void diniAe3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void diniAf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void diniAg3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void diniAh3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void diniAi3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
        void praremajaa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajab3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajac3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajad3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajae3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajaf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajag3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajah3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajai3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasaa3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasab3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasac3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasad3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasae3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasaf3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasag3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasah3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void dewasai3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1); label2.Text = sdr.GetString(2);
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
        void praremajaa4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void praremajab4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void praremajac4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void praremajad4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void praremajae4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void praremajaf4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void praremajag4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void praremajah4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void praremajai4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void praremajaa5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void praremajab5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajabP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void praremajac5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajacP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void praremajad5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajadP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void praremajae5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaeP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void praremajaf5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajafP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void praremajag5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajagP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void praremajah5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajahP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void praremajai5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from praremajaiP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void remajaa5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void remajab5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void remajac5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void remajad5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void remajae5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void remajaf5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void remajag5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void remajah5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void remajai5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dewasaa5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dewasab5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dewasac5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dewasad5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dewasae5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dewasaf5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void dewasag5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void dewasah5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void dewasai5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dinia5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dinib5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dinic5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dinid5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dinie5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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
        void dinif5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void dinig5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void dinih5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void dinii5()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='5' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b88.Text = sdr.GetString(1); label6.Text = sdr.GetString(2);
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

        void dewasaa4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dewasab4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasabP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dewasac4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasacP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dewasad4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasadP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dewasae4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaeP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dewasaf4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasafP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void dewasag4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasagP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void dewasah4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasahP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void dewasai4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dewasaiP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void dinia4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dinib4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dinic4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinicP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dinid4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinidP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dinie4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinieP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void dinif4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinifP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void dinig4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinigP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void dinih4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinihP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void dinii4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from diniP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void remajaa4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void remajab4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void remajac4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void remajad4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void remajae4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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


        void remajaf4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void remajag4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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
        void remajaa7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaaP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void remajab7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajabP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void remajac7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajacP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void remajad7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajadP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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
        void remajae7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaeP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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


        void remajaf7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajafP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void remajag7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajagP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void remajah7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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

        void remajai7()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='7' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b111.Text = sdr.GetString(1); label8.Text = sdr.GetString(2);
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



        void remajah4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajahP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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

        void remajai4()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from remajaiP where noid='4' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b66.Text = sdr.GetString(1); label5.Text = sdr.GetString(2);
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


        void diniAb3()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from dinibP where noid='3' ", conn);
                    da = new SqlDataAdapter(cmd);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        b44.Text = sdr.GetString(1);
                        label2.Text = sdr.GetString(2);
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
                diniA(); dinia5(); dinia7(); dinia10(); dinia13();
                diniAa3(); dinia4(); dinia8(); dinia11();
                diniAa(); dinia6(); dinia9(); dinia12();
            }
            else if (label1.Text == "Usia Dini Kelas B")
            {
                diniAb(); dinib5(); dinib7(); dinib10(); dinib13();
                diniAb(); dinib4(); dinib8(); dinib11();
                diniAbb(); dinib6(); dinib9(); dinib12();
            }
            else if (label1.Text == "Usia Dini Kelas C")
            {
                dinicA(); dinic5(); dinic7(); dinic10(); dinic13();
                diniAc(); dinic6(); dinic8(); dinic11();
                diniAc3(); dinic4(); dinic9(); dinic12();
            }
            else if (label1.Text == "Usia Dini Kelas D")
            {
                diniAd(); dinid5(); dinid7(); dinid11(); dinid13();
                diniAda(); dinid4(); dinid8(); dinid10();
                diniAd3(); dinid6(); dinid9(); dinid12();
            }
            else if (label1.Text == "Usia Dini Kelas E")
            {
                diniAe(); dinie5(); dinie7(); dinie11(); dinie13();
                diniAea(); dinie4(); dinie8(); dinie10();
                diniAe3(); dinie6(); dinie9(); dinie12();
            }
            else if (label1.Text == "Usia Dini Kelas F")
            {
                diniAaf(); dinif5(); dinif7(); dinif11(); dinif13();
                diniAf(); dinif4(); dinif8(); dinif10();
                diniAf3(); dinif6(); dinif9(); dinif12();
            }
            else if (label1.Text == "Usia Dini Kelas G")
            {
                diniAga(); dinig4(); dinig7(); dinig11(); dinig13();
                dinigA(); dinig5(); dinig8(); dinig10();
                diniAg3(); dinig6(); dinig9(); dinig12();
            }
            else if (label1.Text == "Usia Dini Kelas H")
            {
                diniAha(); dinih4(); dinih7(); dinih10(); dinih13();
                dinihA(); dinih5(); dinih8(); dinih11();
                diniAh3(); dinih6(); dinih9(); dinih12();
            }
            else if (label1.Text == "Usia Dini Kelas I")
            {
                diniiA(); dinii4(); dinii7(); dinii10(); dinii13();
                diniAai(); dinii5(); dinii8(); dinii11();
                diniAi3(); dinii6(); dinii9(); dinii12();
            }
            else if (label1.Text == "Pra Remaja Kelas A")
            {
                praremajaa(); praremajaa6(); praremajaa11();
                praremajaa3(); praremajaa7(); praremajaa12();
                praremajaa5(); praremajaa8(); praremajaa13();
                praremajaa4(); praremajaa9();
                praremajaA(); praremajaa10();
            }
            else if (label1.Text == "Pra Remaja Kelas B")
            {
                praremajaba(); praremajab6(); praremajab11();
                praremajabA(); praremajab7(); praremajab12();
                praremajab4(); praremajab8(); praremajab13();
                praremajab5(); praremajab9();
                praremajab3(); praremajab10();
            }
            else if (label1.Text == "Pra Remaja Kelas C")
            {
                praremajaca(); praremajac6(); praremajac9(); praremajac13();
                praremajac3(); praremajac5(); praremajac10();
                praremajac4(); praremajac7(); praremajac11();
                praremajacA(); praremajac8(); praremajac12();
            }
            else if (label1.Text == "Pra Remaja Kelas D")
            {
                praremajada(); praremajad6(); praremajad9(); praremajad13();
                praremajadA(); praremajad5(); praremajad10();
                praremajad3(); praremajad7(); praremajad11();
                praremajad4(); praremajad8(); praremajad12();
            }
            else if (label1.Text == "Pra Remaja Kelas E")
            {
                praremajae(); praremajae5(); praremajae9(); praremajae13();
                praremajae4(); praremajae6(); praremajae10();
                praremajaea(); praremajae7(); praremajae11();
                praremajae3(); praremajae8(); praremajae12();
            }
            else if (label1.Text == "Pra Remaja Kelas F")
            {
                praremajafA(); praremajaf5(); praremajaf9(); praremajaf13();
                praremajaf(); praremajaf6(); praremajaf10();
                praremajaf4(); praremajaf7(); praremajaf11();
                praremajaf3(); praremajaf8(); praremajaf12();
            }
            else if (label1.Text == "Pra Remaja Kelas G")
            {
                praremajag(); praremajag5(); praremajag9(); praremajag13();
                praremajag3(); praremajag6(); praremajag10();
                praremajaAg(); praremajag7(); praremajag11();
                praremajag4(); praremajag8(); praremajag12();
            }
            else if (label1.Text == "Pra Remaja Kelas H")
            {
                praremajah(); praremajah6(); praremajah9(); praremajah13();
                praremajah4(); praremajah5(); praremajah10();
                praremajah3(); praremajah7(); praremajah11();
                praremajaAh(); praremajah8(); praremajah12();
            }
            else if (label1.Text == "Pra Remaja Kelas I")
            {
                praremajai(); praremajai5(); praremajai9(); praremajai13();
                praremajai3(); praremajai6(); praremajai10();
                praremajai4(); praremajai7(); praremajai11();
                praremajaiA(); praremajai8(); praremajai12();
            }
            else if (label1.Text == "Remaja Kelas A")
            {
                remajaa(); remajaa5(); remajaa7(); remajaa10(); remajaa13();
                remajaa3(); remajaa4(); remajaa8(); remajaa11();
                remajaA(); remajaa6(); remajaa9(); remajaa12();
            }
            else if (label1.Text == "Remaja Kelas B")
            {
                remajaba(); remajab5(); remajab7(); remajab10(); remajab13();
                remajab3(); remajab4(); remajab8(); remajab11();
                remajabA(); remajab6(); remajab9(); remajab12();
            }
            else if (label1.Text == "Remaja Kelas C")
            {
                remajac3(); remajac5(); remajac7(); remajac10(); remajac13();
                remajaca(); remajac4(); remajac8(); remajac11();
                remajacA(); remajac6(); remajac9(); remajac12();
            }
            else if (label1.Text == "Remaja Kelas D")
            {
                remajad3(); remajad5(); remajad7(); remajad10(); remajad13();
                remajada(); remajad4(); remajad8(); remajad11();
                remajadaA(); remajad6(); remajad9(); remajad12();
            }
            else if (label1.Text == "Remaja Kelas E")
            {
                remajae3(); remajae5(); remajae8(); remajae10(); remajae13();
                remajae(); remajae4(); remajae7(); remajae11();
                remajaea(); remajae6(); remajae9(); remajae12();
            }
            else if (label1.Text == "Remaja Kelas F")
            {
                remajaf3(); remajaf5(); remajaf8(); remajaf10(); remajaf13();
                remajafA(); remajaf4(); remajaf7(); remajaf11();
                remajafs(); remajaf6(); remajaf9(); remajaf12();
            }
            else if (label1.Text == "Remaja Kelas G")
            {
                remajag3(); remajag5(); remajag8(); remajag10(); remajag13();
                remajag(); remajag4(); remajag7(); remajag11();
                remajaAg(); remajag6(); remajag9(); remajag12();
            }
            else if (label1.Text == "Remaja Kelas H")
            {
                remajah3(); remajah5(); remajah8(); remajah10(); remajah13();
                remajah(); remajah4(); remajah7(); remajah11();
                remajaAh(); remajah6(); remajah9(); remajah12();
            }
            else if (label1.Text == "Remaja Kelas I")
            {
                remajai3(); remajai5(); remajai8(); remajai10(); remajai13();
                remajai(); remajai4(); remajai7(); remajai11();
                remajaiA(); remajai6(); remajai9(); remajai12();
            }
            else if (label1.Text == "Dewasa Kelas A")
            {
                dewasaa1(); dewasaa5(); dewasaa7(); dewasaa10(); dewasaa13();
                dewasaa3(); dewasaa4(); dewasaa8(); dewasaa11();
                dewasaa2(); dewasaa6(); dewasaa9(); dewasaa12();
            }
            else if (label1.Text == "Dewasa Kelas B")
            {
                dewasab1(); dewasab5(); dewasab7(); dewasab10(); dewasab13();
                dewasab2(); dewasab4(); dewasab8(); dewasab11();
                dewasab3(); dewasab6(); dewasab9(); dewasab12();
            }
            else if (label1.Text == "Dewasa Kelas C")
            {
                dewasac1(); dewasac5(); dewasac7(); dewasac10(); dewasac13();
                dewasac3(); dewasac4(); dewasac8(); dewasac11();
                dewasac2(); dewasac6(); dewasac9(); dewasac12();
            }
            else if (label1.Text == "Dewasa Kelas D")
            {
                dewasad1(); dewasad5(); dewasad8(); dewasad10(); dewasad13();
                dewasad3(); dewasad4(); dewasad7(); dewasad11();
                dewasad2(); dewasad6(); dewasad9(); dewasad12();
            }
            else if (label1.Text == "Dewasa Kelas E")
            {
                dewasae1(); dewasae5(); dewasae7(); dewasae10(); dewasae13();
                dewasae3(); dewasae4(); dewasae8(); dewasae11();
                dewasae2(); dewasae6(); dewasae9(); dewasae12();
            }
            else if (label1.Text == "Dewasa Kelas F")
            {
                dewasaf1(); dewasaf5(); dewasaf8(); dewasaf10(); dewasaf13();
                dewasaf3(); dewasaf4(); dewasaf7(); dewasaf11();
                dewasaf2(); dewasaf6(); dewasaf9(); dewasaf12();
            }
            else if (label1.Text == "Dewasa Kelas G")
            {
                dewasag1(); dewasag5(); dewasag7(); dewasag10(); dewasag13();
                dewasag3(); dewasag4(); dewasag8(); dewasag11();
                dewasag2(); dewasag6(); dewasag9(); dewasag12();
            }
            else if (label1.Text == "Dewasa Kelas H")
            {
                dewasah1(); dewasah5(); dewasah7(); dewasah10(); dewasah13();
                dewasah3(); dewasah4(); dewasah8(); dewasah11();
                dewasah2(); dewasah6(); dewasah9(); dewasah12();
            }
            else if (label1.Text == "Dewasa Kelas I")
            {
                dewasai1(); dewasai5(); dewasai7(); dewasai10(); dewasai13();
                dewasai2(); dewasai4(); dewasai8(); dewasai11();
                dewasai3(); dewasai6(); dewasai9(); dewasai12();
            }
            else
            {
                MessageBox.Show("coba lagi");
            }
        }

        private void b117_Click(object sender, EventArgs e)
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
