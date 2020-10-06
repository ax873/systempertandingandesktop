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
   
    public partial class bagan4 : Form
    {
        private SqlCommand cmd;

        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        public bagan4()
        {
            InitializeComponent();
        }
         public bagan4(string terima) :
            this()
        {
            label1.Text=terima;
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
                 diniA(); dinia4();
                 diniAa3();
                 diniAa();
             }
             else if (label1.Text == "Usia Dini Kelas B")
             {
                 diniAb(); dinib4();
                 diniAb();
                 diniAbb();
             }
             else if (label1.Text == "Usia Dini Kelas C")
             {
                 dinicA(); dinic4();
                 diniAc();
                 diniAc3();
             }
             else if (label1.Text == "Usia Dini Kelas D")
             {
                 diniAd(); dinid4();
                 diniAda();
                 diniAd3();
             }
             else if (label1.Text == "Usia Dini Kelas E")
             {
                 diniAe();
                 diniAea(); dinie4();
                 diniAe3();
             }
             else if (label1.Text == "Usia Dini Kelas F")
             {
                 diniAaf(); dinif4();
                 diniAf();
                 diniAf3();
             }
             else if (label1.Text == "Usia Dini Kelas G")
             {
                 diniAga(); dinig4();
                 dinigA();
                 diniAg3();
             }
             else if (label1.Text == "Usia Dini Kelas H")
             {
                 diniAha(); dinih4();
                 dinihA();
                 diniAh3();
             }
             else if (label1.Text == "Usia Dini Kelas I")
             {
                 diniiA();
                 diniAai(); dinii4();
                 diniAi3();
             }
             else if (label1.Text == "Pra Remaja Kelas A")
             {
                 praremajaa();
                 praremajaa3();
                 praremajaa4();
                 praremajaA();
             }
             else if (label1.Text == "Pra Remaja Kelas B")
             {
                 praremajaba();
                 praremajabA();
                 praremajab4();
                 praremajab3();
             }
             else if (label1.Text == "Pra Remaja Kelas C")
             {
                 praremajaca();
                 praremajac3();
                 praremajac4();
                 praremajacA();
             }
             else if (label1.Text == "Pra Remaja Kelas D")
             {
                 praremajada();
                 praremajadA();
                 praremajad3();
                 praremajad4();
             }
             else if (label1.Text == "Pra Remaja Kelas E")
             {
                 praremajae();
                 praremajae4();
                 praremajaea();
                 praremajae3();
             }
             else if (label1.Text == "Pra Remaja Kelas F")
             {
                 praremajafA();
                 praremajaf();
                 praremajaf4();
                 praremajaf3();
             }
             else if (label1.Text == "Pra Remaja Kelas G")
             {
                 praremajag();
                 praremajag3();
                 praremajaAg();
                 praremajag4();
             }
             else if (label1.Text == "Pra Remaja Kelas H")
             {
                 praremajah();
                 praremajah4();
                 praremajah3();
                 praremajaAh();
             }
             else if (label1.Text == "Pra Remaja Kelas I")
             {
                 praremajai();
                 praremajai3();
                 praremajai4();
                 praremajaiA();
             }
             else if (label1.Text == "Remaja Kelas A")
             {
                 remajaa(); remajaa4();
                 remajaa3();
                 remajaA();
             }
             else if (label1.Text == "Remaja Kelas B")
             {
                 remajaba(); remajab4();
                 remajab3();
                 remajabA();
             }
             else if (label1.Text == "Remaja Kelas C")
             {
                 remajac3();
                 remajaca(); remajac4();
                 remajacA();
             }
             else if (label1.Text == "Remaja Kelas D")
             {
                 remajad3(); remajad4();
                 remajada();
                 remajadaA();
             }
             else if (label1.Text == "Remaja Kelas E")
             {
                 remajae3(); remajae4();
                 remajae();
                 remajaea();
             }
             else if (label1.Text == "Remaja Kelas F")
             {
                 remajaf3(); remajaf4();
                 remajafA();
                 remajafs();
             }
             else if (label1.Text == "Remaja Kelas G")
             {
                 remajag3(); remajag4();
                 remajag();
                 remajaAg();
             }
             else if (label1.Text == "Remaja Kelas H")
             {
                 remajah3(); remajah4();
                 remajah();
                 remajaAh();
             }
             else if (label1.Text == "Remaja Kelas I")
             {
                 remajai3();
                 remajai(); remajai4();
                 remajaiA();
             }
             else if (label1.Text == "Dewasa Kelas A")
             {
                 dewasaa1(); dewasaa4();
                 dewasaa3();
                 dewasaa2();
             }
             else if (label1.Text == "Dewasa Kelas B")
             {
                 dewasab1(); dewasab4();
                 dewasab2();
                 dewasab3();
             }
             else if (label1.Text == "Dewasa Kelas C")
             {
                 dewasac1(); dewasac4();
                 dewasac3();
                 dewasac2();
             }
             else if (label1.Text == "Dewasa Kelas D")
             {
                 dewasad1();
                 dewasad3(); dewasad4();
                 dewasad2();
             }
             else if (label1.Text == "Dewasa Kelas E")
             {
                 dewasae1();
                 dewasae3(); dewasae4();
                 dewasae2();
             }
             else if (label1.Text == "Dewasa Kelas F")
             {
                 dewasaf1(); dewasaf4();
                 dewasaf3();
                 dewasaf2();
             }
             else if (label1.Text == "Dewasa Kelas G")
             {
                 dewasag1();
                 dewasag3(); dewasag4();
                 dewasag2();
             }
             else if (label1.Text == "Dewasa Kelas H")
             {
                 dewasah1();
                 dewasah3(); dewasah4();
                 dewasah2();
             }
             else if (label1.Text == "Dewasa Kelas I")
             {
                 dewasai1(); dewasai4();
                 dewasai2();
                 dewasai3();
             }
             else
             {
                 MessageBox.Show("coba lagi");
             }
         }
        private void bagan4_Load(object sender, EventArgs e)
        {

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



        private void b44_Click(object sender, EventArgs e)
        {
            b77.Text = b44.Text;
            b66.Enabled = false;
            b66.BackColor = Color.Black;
        }

        private void b55_Click(object sender, EventArgs e)
        {
            b77.Text = b66.Text;
            b44.Enabled = false;
            b44.BackColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void b33_Click(object sender, EventArgs e)
        {
            b55.Text = b33.Text;
            b77.Enabled = false;
            b77.BackColor = Color.Black;

        }

        private void b22_Click(object sender, EventArgs e)
        {
            b33.Text = b22.Text;
            b11.Enabled = false;
            b11.BackColor = Color.Black;
        }

        private void b11_Click(object sender, EventArgs e)
        {
            b33.Text = b11.Text;
            b22.Enabled = false;
            b22.BackColor = Color.Black;
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

        private void b77_Click(object sender, EventArgs e)
        {
            b55.Text = b77.Text;
            b33.Enabled = false;
            b33.BackColor = Color.Black;
        }

        private void b66_Click(object sender, EventArgs e)
        {
            b77.Text = b66.Text;
            b44.Enabled = false;
            b44.BackColor = Color.Black;
        }
    }
}
