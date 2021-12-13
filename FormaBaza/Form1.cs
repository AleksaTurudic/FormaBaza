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

namespace FormaBaza
{
    public partial class Form1 : Form
    {
        string CS = "Data source = DESKTOP-PI5H8T7; Initial catalog = DomaciBaze; Integrated security = true";

        DataTable podaci = new DataTable();
        int br = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ulica", veza);
            adapter.Fill(podaci);
            osvezi();
        }
        private void osvezi()
        {
            if (podaci.Rows.Count == 0)
            {
                id.Text = "";
                naziv.Text = "";
                opstina.Text = "";
                sprat.Text = "";
                brojeviod.Text = "";
                brojevido.Text = "";

                pocetak.Enabled = false;
                levo.Enabled = false;
                desno.Enabled = false;
                kraj.Enabled = false;

                br = 0;
            }
            else
            {
                id.Text = podaci.Rows[br]["id"].ToString();
                naziv.Text = podaci.Rows[br]["naziv"].ToString();
                opstina.Text = podaci.Rows[br]["opstina"].ToString();
                sprat.Text = podaci.Rows[br]["sprat"].ToString();
                brojeviod.Text = podaci.Rows[br]["brojevi_od"].ToString();
                brojevido.Text = podaci.Rows[br]["brojevi_do"].ToString();

                desno.Enabled = (br != podaci.Rows.Count - 1);
                kraj.Enabled = (br != podaci.Rows.Count - 1);
                levo.Enabled = (br != 0);
                pocetak.Enabled = (br != 0);
            }
        }

        private void pocetak_Click(object sender, EventArgs e)
        {
            br=0;
            osvezi();
        }

        private void levo_Click(object sender, EventArgs e)
        {
            br--;
            osvezi();
        }

        private void desno_Click(object sender, EventArgs e)
        {
            br++;
            osvezi();
        }

        private void kraj_Click(object sender, EventArgs e)
        {
            br = podaci.Rows.Count - 1;
            osvezi();
        }

        private void Unesi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand unos = new SqlCommand("insert into Ulica values ('" + naziv.Text + "', '" + opstina.Text + "','" + sprat.Text.ToString() + "','" + brojeviod.Text.ToString() + "','" + brojevido.Text.ToString() + "')", veza) ;
            veza.Open();
            unos.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ulica", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            osvezi();
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand bris = new SqlCommand("delete from ulica where id=" + id.Text, veza);
            veza.Open();
            bris.ExecuteNonQuery();
            veza.Close();
            br = 0;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ulica", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            osvezi();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand upd = new SqlCommand("UPDATE ulica SET naziv = '" + naziv.Text + "', opstina = '" + opstina.Text + "', sprat = " + sprat.Text + ", brojevi_od = " + brojeviod.Text + ", brojevi_do =" + brojevido.Text + " WHERE id=" + id.Text, veza);
            veza.Open();
            upd.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ulica", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            osvezi();
        }
    }
}
