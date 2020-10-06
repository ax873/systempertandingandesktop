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
namespace projekkp_systemgugur
{
    public partial class Menuu : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        static int billno = 0;
        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        public Menuu()
        {
            InitializeComponent();
            refresh();
          
        }

        //dbcc checkident('lakidb',RESEED,0) untuk mulai dari 0 


        void autao()
        {

            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.Getconn();
            conn.Open();
            cmd = new SqlCommand("select noid from perempuandb where noid in (select max (noid) from perempuandb)order by noid desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["noid"].ToString().Length - 3, 3)) + 1;
                string joinstr = "0" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 3, 3);

            }
            else
            {
                urut = "B001";

            } rd.Close();
            txtnoid.Text = urut;
            conn.Close();
        }
        void refresh()
        {
            SqlConnection conn = konn.Getconn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from lakidb", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "lakidb");
                    datagridview.DataSource = ds;
                    datagridview.DataMember = "lakidb";
                    datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; datagridview.AllowUserToAddRows = false;
                    datagridview.Refresh();


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        private void bthapus_Click(object sender, EventArgs e)
        {

        }

        private void btubah_Click(object sender, EventArgs e)
        {

        }

        private void bttambah_Click(object sender, EventArgs e)
        {

        }

        private void btsimpan_Click(object sender, EventArgs e)
        {

        }
        void cobahpus()
        {

           
        }

        private void btsimpan_Click_1(object sender, EventArgs e)
        {
            txtnama.text = "";
            txtjenis.Text = "";
            txtalamat.text = "";
            txtkategori.Text = "";
            txtkelas.Text = "";
            txtkontinen.text = "";
            txtnoid.Text = "";
            txtusia.Text = "";
            
            txttgl.text = "";



        }

        private void btubah_Click_1(object sender, EventArgs e)
        {

            

        }

        private void bttambah_Click_1(object sender, EventArgs e)
        {














            if (txtjenis.Text == "Perempuan")
            {
                SqlConnection conn = konn.Getconn();

                cmd = new SqlCommand("insert into perempuandb(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di simpan ");

                if (txtkategori.Text == "Tanding")
                {
                    cmd = new SqlCommand("insert into tandingP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data  ");

                    if (txtusia.Text == "Remaja")
                    {
                        cmd = new SqlCommand("insert into remajaP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");

                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into remajaaP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into remajabP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into remajacP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into remajadP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into remajaeP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into remajafP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into remajagP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into remajahP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into remajaiP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Dewasa")
                    {
                        cmd = new SqlCommand("insert into dewasaP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");

                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into dewasaaP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into dewasabP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into dewasacP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into dewasadP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into dewasafP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into dewasahP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into dewasaiP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into dewasaeP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into dewasagP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                    }


                    else if (txtusia.Text == "Pra Remaja")
                    {
                        cmd = new SqlCommand("insert into praremajaP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");
                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into praremajaaP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into praremajabP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into praremajacP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into praremajadP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into praremajaeP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into praremajafP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into praremajagP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into praremajahP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into praremajaiP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Usia Dini")
                    {
                        cmd = new SqlCommand("insert into usiadiniP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");
                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into diniaP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into dinibP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into dinicP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into dinidP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into dinieP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into dinifP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into dinigP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into dinihP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into diniP(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                    }


                }



            }








            else if (txtjenis.Text == "Laki Laki")
            {
                 SqlConnection conn = konn.Getconn();

                cmd = new SqlCommand("insert into lakidb(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di siman ");

                if (txtkategori.Text == "Tanding")
                {
                    cmd = new SqlCommand("insert into tanding(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data  ");

                    if (txtusia.Text == "Remaja")
                    {
                        cmd = new SqlCommand("insert into remaja(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");

                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into remajaa(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into remajab(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into remajac(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into remajad(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into remajae(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into remajaf(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into remajag(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into remajah(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into remajai(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Dewasa")
                    {
                        cmd = new SqlCommand("insert into dewasa(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");

                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into dewasaa(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into dewasab(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into dewasac(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into dewasad(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into dewasaf(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into dewasah(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into dewasai(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into dewasae(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into dewasag(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                    }


                    else if (txtusia.Text == "Pra Remaja")
                    {
                        cmd = new SqlCommand("insert into praremaja(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");
                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into praremajaa(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into praremajab(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into praremajac(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into praremajad(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into praremajae(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into praremajaf(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into praremajag(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into praremajah(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into praremajai(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Usia Dini")
                    {
                        cmd = new SqlCommand("insert into usiadiniL(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasilusia dini C ");
                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("insert into dinia(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("insert into dinib(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("insert into dinic(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("insert into dinid(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("insert into dinie(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("insert into dinif(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("insert into dinig(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("insert into dinih(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("insert into dinii(noid,nama,kontinen,tgl,alamat,jenis,usia,kelas,kategori)values('" + txtnoid.Text + "','" + txtnama.text + "','" + txtkontinen.text + "','" + txttgl.text + "', '" + txtalamat.text + "','" + txtjenis.Text + "','" + txtusia.Text + "', '" + txtkelas.Text + "', '" + txtkategori.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("data berhasilusia dini C ");
                            conn.Close();

                        }
                        }}
                        else if (txtkategori.Text == "regu")
                        {
                            MessageBox.Show("simpan regu ");
                        }
                        else if (txtkategori.Text == "seni")
                        {
                            MessageBox.Show("simpan seni");
                        }
                else 
                {
                    MessageBox.Show("masukan yng banear ni");
                  
                }

                refresh();  
                
            }
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.datagridview.Rows[e.RowIndex];
            txtnoid.Text = row.Cells["noid"].Value.ToString();
            txtnama.text = row.Cells["nama"].Value.ToString();
            txtkontinen.text = row.Cells["kontinen"].Value.ToString();
            txttgl.text = row.Cells["tgl"].Value.ToString();
            txtalamat.text = row.Cells["alamat"].Value.ToString();
            txtjenis.Text = row.Cells["jenis"].Value.ToString();
            txtusia.Text = row.Cells["usia"].Value.ToString();
            txtkelas.Text = row.Cells["kelas"].Value.ToString();
            txtkategori.Text = row.Cells["kategori"].Value.ToString();

        }


        private void txtkategori_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void datagridview_MouseClick(object sender, MouseEventArgs e)
        {

        }
        void hilang()
        {
            txtjenis.Hide();
            txtkategori.Hide();
            txtusia.Hide();
            txtkelas.Hide();
        }
        void muncul()
        {
            txtjenis.Show();
            txtkategori.Show();
            txtusia.Show();
            txtkelas.Show();
        }





        private void bthapus_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = konn.Getconn();
            conn.Open();

            if (txtjenis.Text == "Perempuan")
            {
                cmd = new SqlCommand("delete from perempuandb where noid='" + txtnoid.Text + "'", conn);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil ");
              //  hapusperem();
                
                if (txtkategori.Text == "Tanding")
                {
                //    hapustandingP();

                    cmd = new SqlCommand("delete from tandingP where noid='" + txtnoid.Text + "'", conn);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("berhasil ");

                    if (txtusia.Text == "Remaja")
                    {
                        //   text
                  //      hapusperempuanremaja();
                        cmd = new SqlCommand("delete from remaja where noid='" + txtnoid.Text + "'", conn);
                    
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");
                       
                        if (txtkelas.Text == "A")
                        {
                    //        hapusperempuanremajaA();
                            cmd = new SqlCommand("delete from remajaaP where noid='" + txtnoid.Text + "'", conn);
                          
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from remajabP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                      //      hapusperempuanremajaB();   //   text

                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from remajacP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from remajadP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from remajaeP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from remajafP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from remajagP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from remajahP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from remajafP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Dewasa")
                    {
                        cmd = new SqlCommand("delete from dewasaP where noid='" + txtnoid.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");

                    

                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("delete from dewasaaP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from dewasabP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from dewasacP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from dewasadP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from dewasafP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from dewasahP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from dewasaiP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from dewasaaeP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from dewasagP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                    }


                    else if (txtusia.Text == "Pra Remaja")
                    {
                        //   text
                        //      hapusperempuanremaja();
                        cmd = new SqlCommand("delete from praremajaP where noid='" + txtnoid.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");

                        if (txtkelas.Text == "A")
                        {
                            //        hapusperempuanremajaA();
                            cmd = new SqlCommand("delete from praremajaaP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from praremajabP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                            //      hapusperempuanremajaB();   //   text

                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from praremajacP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from praremajadP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from praremajaeP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from praremajafP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from praremajagP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from praremajahP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from praremajafP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Usia Dini")
                    {
                        cmd = new SqlCommand("delete from usiadiniP where noid='" + txtnoid.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");
                    
                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("delete from diniaP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from dinibP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from dinicP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from dinidP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from dinieP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from dinifP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from dinigP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from dinihP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from diniP where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                    }


                }



            }








            else if (txtjenis.Text == "Laki Laki")
            {

                cmd = new SqlCommand("delete from lakidb where noid='" + txtnoid.Text + "'", conn);
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil ");
                //  hauserem();

                if (txtkategori.Text == "Tanding")
                {
                    //    haustanding();

                    cmd = new SqlCommand("delete from tanding where noid='" + txtnoid.Text + "'", conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("berhasil ");

                    if (txtusia.Text == "Remaja")
                    {
                        //   text
                        //      hauseremuanremaja();
                        cmd = new SqlCommand("delete from remaja where noid='" + txtnoid.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");

                        if (txtkelas.Text == "A")
                        {
                            //        hauseremuanremajaA();
                            cmd = new SqlCommand("delete from remajaa where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from remajab where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                            //      hauseremuanremajaB();   //   text

                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from remajac where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from remajad where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from remajae where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from remajaf where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from remajag where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from remajah where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from remajaf where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Dewasa")
                    {
                        cmd = new SqlCommand("delete from dewasa where noid='" + txtnoid.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");



                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("delete from dewasaa where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from dewasab where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from dewasac where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from dewasad where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from dewasaf where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from dewasah where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from dewasai where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from dewasaae where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from dewasag where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                    }


                    else if (txtusia.Text == "ra Remaja")
                    {
                        //   text
                        //      hauseremuanremaja();
                        cmd = new SqlCommand("delete from praremaja where noid='" + txtnoid.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");

                        if (txtkelas.Text == "A")
                        {
                            //        hauseremuanremajaA();
                            cmd = new SqlCommand("delete from praremajaa where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from praremajab where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                            //      hauseremuanremajaB();   //   text

                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from praremajac where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();

                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from praremajad where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from ppraremajae where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from praremajaf where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from praremajag where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from praremajah where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from praremajaf where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                    }




                    else if (txtusia.Text == "Usia Dini")
                    {
                        cmd = new SqlCommand("delete from usiadiniL where noid='" + txtnoid.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("berhasil ");

                        if (txtkelas.Text == "A")
                        {
                            cmd = new SqlCommand("delete from dinia where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "B")
                        {
                            cmd = new SqlCommand("delete from dinib where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "C")
                        {
                            cmd = new SqlCommand("delete from dinic where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "D")
                        {
                            cmd = new SqlCommand("delete from dinid where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "E")
                        {
                            cmd = new SqlCommand("delete from dinie where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "F")
                        {
                            cmd = new SqlCommand("delete from dinif where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "G")
                        {
                            cmd = new SqlCommand("delete from dinig where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "H")
                        {
                            cmd = new SqlCommand("delete from dinih where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();
                        }
                        else if (txtkelas.Text == "I")
                        {
                            cmd = new SqlCommand("delete from dini where noid='" + txtnoid.Text + "'", conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("berhasil ");
                            conn.Close();


                        }
                    }


                }
                else if (txtkategori.Text == "regu")
                {
                    MessageBox.Show("simpan regu ");
                }
                else if (txtkategori.Text == "seni")
                {
                    MessageBox.Show("simpan seni");
                }


            } refresh();
            
        }

        private void txtnoid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtkelas_onItemSelected(object sender, EventArgs e)
        {

        }

        private void txtusia_onItemSelected(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtjeniss_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void txtkelass_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        void numbern()
        {
            billno = billno + 1;
            txtnoid.Text = billno.ToString();
        }
        private void txtnoid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


}








