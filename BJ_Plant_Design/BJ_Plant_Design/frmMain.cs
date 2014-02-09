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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private  string strxuanze = "------请选择-----";
        private  string connString = "";
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            connString = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
            this.cmbType.SelectedIndex = 0;
            this.cmbFlower_Type.SelectedIndex = 0;
            this.cmbPlant_Hight.SelectedIndex = 0;
            this.cmbFlower_Color.SelectedIndex = 0;
            this.cmbFlower_Date.SelectedIndex = 0;
            this.cmbFruit_Color.SelectedIndex = 0;
            this.cmbFruit_Date.SelectedIndex = 0;
            this.cmbMangement.SelectedIndex = 0;
            this.cmbResistance.SelectedIndex = 0;
            this.cmbIs_cl.SelectedIndex=0;
            this.cmbye_Color.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  DataSet ds = new System.Data.DataSet();
           
            int strplantheight = Cmb_Plant_Hight.Items.IndexOf(0);
           ds=selelct(this.Cmb_Type.SelectedItem.ToString(), this.Cmb_Flower_Color.SelectedItem.ToString(),this.Cmb_Flower_Date.SelectedItem.ToString(),Cmb_Fruit_Color.SelectedItem.ToString(),Cmb_Fruit_Date.SelectedItem.ToString(),strplantheight,this.Cmb_Flower_Type.SelectedItem.ToString(),this.Cmb_Mangement.SelectedItem.ToString(),this.Cmb_Resistance.SelectedItem.ToString());*/


          // this.pictureBox1.ImageLocation = @"E:\touxiang.jpg";
            Image img = new Bitmap(@"images\touxiang.jpg");
            for (int i = 0; i < 5; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Location = new Point(200, 200 + i * 210);
                pbx.Name = "tb" + i.ToString();
                pbx.Height = 200;
                pbx.Width = 200;
                pbx.Image = img;
                this.splitContainer1.Panel2.Controls.Add(pbx);
               
            }
        }
        int a=2;
        private void btn_Click(object sender, EventArgs e)
        {
            frmInfo fc = new frmInfo(a);
            fc.ShowInTaskbar = false;
            fc.Show();
            
        }

        

        
        private  DataSet selelct(string strType, string strflowerdate, string strflowercolor, string strftuitdate, string strfruitcolor, int strplantheight, string strflowertype, string strmanangement, string strResistance) 
        {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            DataSet ds = new DataSet();
            string strSql = "select * from BJ_Plant_Design where 1=1 ";
            if (strType != strxuanze)
            {
                strSql += " and Plant_Type='" + strType;
            }
             if (strflowercolor !=strxuanze) 
            {
                strSql += "' and Flower_Color='" + strflowercolor;
            }
             if (strflowerdate != strxuanze) 
            {
                strSql += "' and Flower_Date='" + strflowerdate;
            }
             if (strfruitcolor != strxuanze) 
            {
                strSql += "' and  Fruit_Color='" + strftuitdate;
            }
            if (strplantheight !=0) 
            {
                strSql += "' and Img_Plant_Height='" + strplantheight;
            }
            if (strflowertype != strxuanze) 
            {
                strSql += "' and Resistance='" + strResistance;
            }
            if(strmanangement!=strxuanze)
            {
                strSql += "' and Management='" + strmanangement + "'";
            }
                
            OleDbCommand cmb = new OleDbCommand(strSql, conn);

         
            OleDbDataAdapter oda = new OleDbDataAdapter(cmb);
            oda.Fill(ds);
            return ds;
        }  
    }
}
