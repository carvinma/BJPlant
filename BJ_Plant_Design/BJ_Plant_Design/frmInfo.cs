using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
namespace BJ_Plant_Design
{
    public partial class frmInfo : Form
    {
        int b;
        public frmInfo(int a)
        {
            this.b = a;
            InitializeComponent();
        }
        private string connString = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            connString = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
            fuzhi();
        }
        private DataSet select(int a) 
        {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            string strsql = "select * from BJ_Plant_Design where Plant_ID=" + a;
            DataSet ds = new DataSet();
            OleDbCommand cmb = new OleDbCommand(strsql,conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmb);
            da.Fill(ds);
            return ds;
        }
        private void fuzhi() 
        {
            DataSet ds=new DataSet();
            ds=select(b);          
            this.lblChinese_Name.Text = ds.Tables[0].Rows[0][2].ToString();
            this.lblLatin_Name.Text = ds.Tables[0].Rows[0][3].ToString();
            this.lblFamliy.Text = ds.Tables[0].Rows[0][4].ToString();
            this.lblCategory.Text = ds.Tables[0].Rows[0][5].ToString();
            this.lblPlant_Type.Text = ds.Tables[0].Rows[0][6].ToString();
            this.lblPlant_Height.Text = ds.Tables[0].Rows[0][7].ToString();
            this.lblCrown_Diameter.Text = ds.Tables[0].Rows[0][8].ToString();
            this.lblFlower_Color.Text = ds.Tables[0].Rows[0][9].ToString();
            this.lblFlower_Date.Text = ds.Tables[0].Rows[0][10].ToString();
            this.lblFruit_Color.Text = ds.Tables[0].Rows[0][11].ToString();
            this.lblFruit_Date.Text = ds.Tables[0].Rows[0][12].ToString();
            this.lblEnjoy_Position.Text = ds.Tables[0].Rows[0][13].ToString();
            this.lblEcology_Habit.Text = ds.Tables[0].Rows[0][14].ToString();
            this.lblCulture.Text = ds.Tables[0].Rows[0][15].ToString();
            
        }
    }
}
