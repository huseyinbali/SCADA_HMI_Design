using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;
using System.Data.SqlClient;

namespace TiaPortal_C_
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti_sql = new SqlConnection("Data Source=DESKTOP-MC6FJ6K\\SQLEXPRESS;Initial Catalog=MotorTakip_SCADA;Integrated Security=True");
        static S7Client plc1 = new S7Client();
        public int baglanti_plc = plc1.ConnectTo("192.168.1.33", 0, 1); 
        public Form1()
        {    
            InitializeComponent();  
        }

        public string acilstop, m1_termik, m2_termik, m3_termik;

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
             listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (baglanti_plc == 0)
            {
                lbl_BaglantiDurum.Text = "PLC'ye bağlandı";
                lbl_BaglantiDurum.ForeColor = Color.Green;
            }
            else
            {
                lbl_BaglantiDurum.Text = "PLC'ye baglı değil";
                lbl_BaglantiDurum.ForeColor = Color.Red;
            }               
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_PlcOku_Click(object sender, EventArgs e)
        {
            var buffer = new byte[14];
            int readResult = plc1.DBRead(1, 0, buffer.Length, buffer);
            lbl_M1sicaklik.Text = Convert.ToString(S7.GetIntAt(buffer, 2));
            lbl_M2sicaklik.Text = Convert.ToString(S7.GetIntAt(buffer, 4));
            lbl_M3sicaklik.Text = Convert.ToString(S7.GetIntAt(buffer, 6));
            lbl_M1vibration.Text = Convert.ToString(S7.GetIntAt(buffer, 8));
            lbl_M2vibration.Text = Convert.ToString(S7.GetIntAt(buffer, 10));
            lbl_M3vibration.Text = Convert.ToString(S7.GetIntAt(buffer, 12));
            acilstop = Convert.ToString(S7.GetBitAt(buffer, 0, 0));
            m1_termik = Convert.ToString(S7.GetBitAt(buffer, 0, 1));
            m2_termik = Convert.ToString(S7.GetBitAt(buffer, 0, 2));
            m3_termik = Convert.ToString(S7.GetBitAt(buffer, 0, 3));

            

            if (acilstop == "True")
            {
                SqlCommand komut2 = new SqlCommand("insert into TBL_Arizalar(Durum,Tarih) values (@D,@T)", baglanti_sql);
                komut2.Parameters.AddWithValue("@D", "Acil stop basili");
                komut2.Parameters.AddWithValue("@T", DateTime.Now);
                baglanti_sql.Open();
                komut2.ExecuteNonQuery();
                baglanti_sql.Close();
                listBox1.Items.Add("Acil Stop Basılı" + "                 " + DateTime.Now);
                listBox1.ForeColor = Color.Red;
            }
            if (m1_termik == "True")
            {
                SqlCommand komut3 = new SqlCommand("insert into TBL_Arizalar(Durum,Tarih) values (@D,@T)", baglanti_sql);
                komut3.Parameters.AddWithValue("@D", "Motor 1 Termik Atti");
                komut3.Parameters.AddWithValue("@T", DateTime.Now);
                baglanti_sql.Open();
                komut3.ExecuteNonQuery();
                baglanti_sql.Close();
                listBox1.Items.Add("Motor 1 Termik hatası" + "      " + DateTime.Now);
                listBox1.ForeColor = Color.Red;
            }
            if (m2_termik == "True")
            {
                SqlCommand komut4 = new SqlCommand("insert into TBL_Arizalar(Durum,Tarih) values (@D,@T)", baglanti_sql);
                komut4.Parameters.AddWithValue("@D", "Motor 2 Termik Atti");
                komut4.Parameters.AddWithValue("@T", DateTime.Now);
                baglanti_sql.Open();
                komut4.ExecuteNonQuery();
                baglanti_sql.Close();
                listBox1.Items.Add("Motor 2 Termik hatası" + "      " + DateTime.Now);
                listBox1.ForeColor = Color.Red;
            }
            if (m3_termik == "True")
            {
                SqlCommand komut5 = new SqlCommand("insert into TBL_Arizalar(Durum,Tarih) values (@D,@T)", baglanti_sql);
                komut5.Parameters.AddWithValue("@D", "Motor 3 Termik Atti");
                komut5.Parameters.AddWithValue("@T", DateTime.Now);
                baglanti_sql.Open();
                komut5.ExecuteNonQuery();
                baglanti_sql.Close();
                listBox1.Items.Add("Motor 3 Termik hatası" + "      " + DateTime.Now);
                listBox1.ForeColor = Color.Red;
            }

            SqlCommand komut = new SqlCommand("insert into TBL_Sensors(M1_Sicaklik,M2_Sicaklik,M3_Sicaklik,M1_Vibration,M2_Vibration,M3_Vibration) values (@S1,@S2,@S3,@V1,@V2,@V3)", baglanti_sql);
            komut.Parameters.AddWithValue("@S1", lbl_M1sicaklik.Text);
            komut.Parameters.AddWithValue("@S2", lbl_M2sicaklik.Text);
            komut.Parameters.AddWithValue("@S3", lbl_M3sicaklik.Text);
            komut.Parameters.AddWithValue("@V1", lbl_M1vibration.Text);
            komut.Parameters.AddWithValue("@V2", lbl_M2vibration.Text);
            komut.Parameters.AddWithValue("@V3", lbl_M3vibration.Text);
            baglanti_sql.Open();
            komut.ExecuteNonQuery();
            baglanti_sql.Close();

        }
    }
}
