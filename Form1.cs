//  This code written by BBS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.Instrumentation;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;
using ZedGraph;
using System.Threading;
using System.Drawing.Drawing2D;
using XanderUI;

namespace sufrun
{
  
    public partial class Form1 : Form
    {
        
        GraphPane mypanehız = new GraphPane();
        GraphPane mypaneakım = new GraphPane();
        PointPairList listPointhız = new PointPairList();
        PointPairList listPointakım = new PointPairList();
        LineItem myCurvehız;
        LineItem myCurveakım;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            



            this.gc1.BackColor = System.Drawing.Color.Transparent;
            this.gc2.BackColor = System.Drawing.Color.Transparent;
            this.gc3.BackColor = System.Drawing.Color.Transparent;
            this.gc4.BackColor = System.Drawing.Color.Transparent;
            this.gc5.BackColor = System.Drawing.Color.Transparent;
            this.gc6.BackColor = System.Drawing.Color.Transparent;
            this.gc77.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.BBS.BackColor = System.Drawing.Color.Transparent;
            this.BBS1.BackColor = System.Drawing.Color.Transparent;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button7.TabStop = false;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            GrafikHazirla();
            Login();
        }

      
        firebaseconnection con = new firebaseconnection();
        private void GrafikHazirla()
        {
            mypanehız = zedGraphControl1.GraphPane;
            mypaneakım = zedGraphControl2.GraphPane;
            mypanehız.Title.Text = "Hız - Zaman Grafiği";
            mypaneakım.Title.Text = "Akım - Zaman Grafiği";
            mypanehız.XAxis.Title.Text = " t (s)";
            mypaneakım.XAxis.Title.Text = " t (s)";
            mypanehız.YAxis.Title.Text = "Çıkış Hız(Km/h)";
            mypaneakım.YAxis.Title.Text = "Çıkış Akım(W/h)";
            mypanehız.YAxis.Scale.Min = 0;
            mypaneakım.YAxis.Scale.Min = 0;
            mypanehız.YAxis.Scale.Max = 200;
            mypaneakım.YAxis.Scale.Max = 200;
            myCurvehız = mypanehız.AddCurve(null, listPointhız, Color.Red, SymbolType.None);
            myCurveakım = mypaneakım.AddCurve(null, listPointakım, Color.Blue, SymbolType.None);
            myCurvehız.Line.Width = 3;
            myCurveakım.Line.Width = 3;
        }
        double zaman = 0;
        private async void Login()
        {

            try
            {
                while (true)
                {
                    string saniye = DateTime.Now.Second.ToString();
                    string dakika = DateTime.Now.Minute.ToString();
                    string saat = DateTime.Now.Hour.ToString();
                    con.client = new FireSharp.FirebaseClient(con.config);
                    con.response = await con.client.GetAsync("Araba/");
                    Araba user = con.response.ResultAs<Araba>();
                    label2.Text = string.Format(user.Akim.ToString()) + " A";
                    label4.Text = string.Format(user.Hiz.ToString()) + " Km/h";
                    label6.Text = string.Format(user.Maxsic.ToString()) + "°C";
                    label8.Text = string.Format(user.Topger.ToString()) + " W";
                    label10.Text = string.Format(user.Sic1.ToString()) + " °C";
                    label12.Text = string.Format(user.Sic2.ToString()) + " °C";
                    label14.Text = string.Format(user.Sic3.ToString()) + " °C";
                    gc2.SetPointerValue("Scale1", "Pointer1", user.Maxsic);
                    gc1.SetPointerValue("Scale1", "Pointer1", user.Hiz);
                    gc3.SetPointerValue("Scale1", "Pointer1", user.Sic1);
                    gc4.SetPointerValue("Scale1", "Pointer1", user.Sic2);
                    gc5.SetPointerValue("Scale1", "Pointer1", user.Sic3);
                    gc6.SetPointerValue("Scale1", "Pointer1", user.Akim);
                    gc77.SetPointerValue("Scale1", "Pointer1", user.Topger);
                    label36.Text = Convert.ToString(user.Pil1) + "%";
                    label37.Text = Convert.ToString(user.Pil2) + "%";
                    label38.Text = Convert.ToString(user.Pil3) + "%";
                    label39.Text = Convert.ToString(user.Pil4) + "%";
                    label40.Text = Convert.ToString(user.Pil5) + "%";
                    label41.Text = Convert.ToString(user.Pil6) + "%";
                    label42.Text = Convert.ToString(user.Pil7) + "%";
                    label43.Text = Convert.ToString(user.Pil8) + "%";
                    label44.Text = Convert.ToString(user.Pil9) + "%";
                    label45.Text = Convert.ToString(user.Pil10) + "%";
                    label46.Text = Convert.ToString(user.Pil11) + "%";
                    label47.Text = Convert.ToString(user.Pil12) + "%";
                    label48.Text = Convert.ToString(user.Pil13) + "%";
                    label49.Text = Convert.ToString(user.Pil14) + "%";
                    label50.Text = Convert.ToString(user.Pil15) + "%";
                    label51.Text = Convert.ToString(user.Pil16) + "%";
                    label52.Text = Convert.ToString(user.Pil17) + "%";
                    label53.Text = Convert.ToString(user.Pil18) + "%";
                    label54.Text = Convert.ToString(user.Pil19) + "%";
                    label55.Text = Convert.ToString(user.Pil20) + "%";
                    progressBar1.Value = user.Pil1;
                    progressBar2.Value = user.Pil2;
                    progressBar3.Value = user.Pil3;
                    progressBar4.Value = user.Pil4;
                    progressBar5.Value = user.Pil5;
                    progressBar6.Value = user.Pil6;
                    progressBar7.Value = user.Pil7;
                    progressBar8.Value = user.Pil8;
                    progressBar9.Value = user.Pil9;
                    progressBar10.Value = user.Pil10;
                    progressBar11.Value = user.Pil11;
                    progressBar12.Value = user.Pil12;
                    progressBar13.Value = user.Pil13;
                    progressBar14.Value = user.Pil14;
                    progressBar15.Value = user.Pil15;
                    progressBar16.Value = user.Pil16;
                    progressBar17.Value = user.Pil17;
                    progressBar18.Value = user.Pil18;
                    progressBar19.Value = user.Pil19;
                    progressBar20.Value = user.Pil20;
                    zaman += 0.05;
                    listPointhız.Add(new PointPair(zaman, user.Hiz));
                    listPointakım.Add(new PointPair(zaman, user.Akim));
                    mypanehız.XAxis.Scale.Max = zaman;
                    mypaneakım.XAxis.Scale.Max = zaman;
                    mypanehız.AxisChange();
                    mypaneakım.AxisChange();
                    zedGraphControl1.Refresh();
                    zedGraphControl2.Refresh();

                }
            }
            catch (Exception e)
            {
                label2.Text = (e.Message);
                label4.Text = (e.Message);
                label6.Text = (e.Message);
                label8.Text = (e.Message);
                label10.Text = (e.Message);
                label12.Text = (e.Message);
                label14.Text = (e.Message);
                label36.Text = (e.Message);
                label37.Text = (e.Message);
                label38.Text = (e.Message);
                label39.Text = (e.Message);
                label40.Text = (e.Message);
                label41.Text = (e.Message);
                label42.Text = (e.Message);
                label43.Text = (e.Message);
                label44.Text = (e.Message);
                label45.Text = (e.Message);
                label46.Text = (e.Message);
                label47.Text = (e.Message);
                label48.Text = (e.Message);
                label49.Text = (e.Message);
                label50.Text = (e.Message);
                label51.Text = (e.Message);
                label52.Text = (e.Message);
                label53.Text = (e.Message);
                label54.Text = (e.Message);
                label55.Text = (e.Message);
            }

        }
        int i;
        int j;

 

        private async void button1_Click(object sender, EventArgs e)
        {
    
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            ws.Cells[1, 1] = "Zaman";
            ws.Cells[1, 2] = "Hız";
            ws.Cells[1, 3] = "Akim";
            ws.Cells[1, 4] = "Maximum Sıcaklık";
            ws.Cells[1, 5] = "Toplam Gerilim";
            ws.Cells[1, 6] = "Sicaklik 1";
            ws.Cells[1, 7] = "Sicaklik 2";
            ws.Cells[1, 8] = "Sicaklik 3";
            ws.Cells[1, 9] = "Pil1";
            ws.Cells[1, 10] = "Pil2";
            ws.Cells[1, 11] = "Pil3";
            ws.Cells[1, 12] = "Pil4";
            ws.Cells[1, 13] = "Pil5";
            ws.Cells[1, 14] = "Pil6";
            ws.Cells[1, 15] = "Pil7";
            ws.Cells[1, 16] = "Pil8";
            ws.Cells[1, 17] = "Pil9";
            ws.Cells[1, 18] = "Pil10";
            ws.Cells[1, 19] = "Pil11";
            ws.Cells[1, 20] = "Pil12";
            ws.Cells[1, 21] = "Pil13";
            ws.Cells[1, 22] = "Pil14";
            ws.Cells[1, 23] = "Pil15";
            ws.Cells[1, 24] = "Pil16";
            ws.Cells[1, 25] = "Pil17";
            ws.Cells[1, 26] = "Pil18";
            ws.Cells[1, 27] = "Pil19";
            ws.Cells[1, 28] = "Pil20";
            try
            {
                for (i = 2; i < i + 1; i++)
                {
                    for (j = 1; j < 29; j++)
                    {
                        con.response = await con.client.GetAsync("Araba/");
                        con.client = new FireSharp.FirebaseClient(con.config);
                        Araba user = con.response.ResultAs<Araba>();
                        string saniye = DateTime.Now.Second.ToString();
                        string dakika = DateTime.Now.Minute.ToString();
                        string saat = DateTime.Now.Hour.ToString();

                        if (j == 1)
                        {
                            ws.Cells[i, j] = saat + ":" + dakika + ":" + saniye;

                        }
                        else if (j == 2)
                        {
                            ws.Cells[i, j] = user.Hiz;

                        }
                        else if (j == 3)
                        {
                            ws.Cells[i, j] = user.Akim;

                        }
                        else if (j == 4)
                        {
                            ws.Cells[i, j] = user.Maxsic;

                        }
                        else if (j == 5)
                        {
                            ws.Cells[i, j] = user.Topger;

                        }
                        else if (j == 6)
                        {
                            ws.Cells[i, j] = user.Sic1;

                        }
                        else if (j == 7)
                        {
                            ws.Cells[i, j] = user.Sic2;

                        }
                        else if (j == 8)
                        {
                            ws.Cells[i, j] = user.Sic3;

                        }

                        else if (j == 9)
                        {
                            ws.Cells[i, j] = user.Pil1;

                        }
                        else if (j == 10)
                        {
                            ws.Cells[i, j] = user.Pil2;

                        }
                        else if (j == 11)
                        {
                            ws.Cells[i, j] = user.Pil3;

                        }
                        else if (j == 12)
                        {
                            ws.Cells[i, j] = user.Pil4;

                        }
                        else if (j == 13)
                        {
                            ws.Cells[i, j] = user.Pil5;

                        }
                        else if (j == 14)
                        {
                            ws.Cells[i, j] = user.Pil6;

                        }
                        else if (j == 15)
                        {
                            ws.Cells[i, j] = user.Pil7;

                        }
                        else if (j == 16)
                        {
                            ws.Cells[i, j] = user.Pil8;

                        }
                        else if (j == 17)
                        {
                            ws.Cells[i, j] = user.Pil9;

                        }
                        else if (j == 18)
                        {
                            ws.Cells[i, j] = user.Pil10;

                        }
                        else if (j == 19)
                        {
                            ws.Cells[i, j] = user.Pil11;

                        }
                        else if (j == 20)
                        {
                            ws.Cells[i, j] = user.Pil12;

                        }
                        else if (j == 21)
                        {
                            ws.Cells[i, j] = user.Pil13;

                        }
                        else if (j == 22)
                        {
                            ws.Cells[i, j] = user.Pil14;

                        }
                        else if (j == 23)
                        {
                            ws.Cells[i, j] = user.Pil15;

                        }
                        else if (j == 24)
                        {
                            ws.Cells[i, j] = user.Pil16;

                        }
                        else if (j == 25)
                        {
                            ws.Cells[i, j] = user.Pil17;

                        }
                        else if (j == 26)
                        {
                            ws.Cells[i, j] = user.Pil18;

                        }
                        else if (j == 27)
                        {
                            ws.Cells[i, j] = user.Pil19;

                        }
                        else if (j == 28)
                        {
                            ws.Cells[i, j] = user.Pil20;

                        }


                    }
                }
            }
            catch (Exception)
            {

            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Programı kapatmak istiyor musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button7.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Normal;
            button4.Visible = false;
            button7.Visible = true;

        }
        

    }
    }


