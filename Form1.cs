using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finaldemopitottube
{
    public partial class FINALDEMOPITOTTUBE : Form
    {
        public FINALDEMOPITOTTUBE()
        {
            InitializeComponent();
            rof_comboBox.Text = "SELECT";
            podate_textBox.ForeColor = SystemColors.GrayText;
            podate_textBox.Text = "DD/MM/YYYY";
            this.podate_textBox.Leave += new System.EventHandler(this.podate_textBox_Leave);
            this.podate_textBox.Enter += new System.EventHandler(this.podate_textBox_Enter);

            staticpressure_label.Text = "";
            staticpressure_textBox.Hide();

            temp_label.Text = "";
            temp_textBox.Hide();
        }
            private void podate_textBox_Leave(object sender, EventArgs e)
            {
                if (podate_textBox.Text.Length == 0)
                {
                    podate_textBox.Text = "DD/MM/YYYY";
                    podate_textBox.ForeColor = SystemColors.GrayText;
                }
            }

            private void podate_textBox_Enter(object sender, EventArgs e)
            {
                if (podate_textBox.Text == "DD/MM/YYYY")
                {
                    podate_textBox.Text = "";
                    podate_textBox.ForeColor = SystemColors.WindowText;
                }
            }
        

        private void logo_Click(object sender, EventArgs e)
        {
            string url = "https://www.scientificdevices.org/";
            System.Diagnostics.Process.Start(url);
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            const string V = "";

            client_textBox.Text = V;
            pono_textBox.Text = V;
            wono_textBox.Text = V;
            tagno_textBox.Text = V;

            podate_textBox.ForeColor = SystemColors.GrayText;
            podate_textBox.Text = "DD/MM/YYYY";
            this.podate_textBox.Leave += new System.EventHandler(this.podate_textBox_Leave);
            this.podate_textBox.Enter += new System.EventHandler(this.podate_textBox_Enter);

            rof_comboBox.Text = "SELECT";

            rof_textBox.Text = V;
            ac_textBox.Text = V;
            Re_textBox.Text = V;
            velocity_textBox.Text = V;

            pipeid_textBox.Text = V;
            probewidth_textBox.Text = V;
            fluiddensity_textBox.Text = V;
            temp_textBox.Text = V;
            flow_textBox.Text = V;
            staticpressure_textBox.Text = V;
            viscosity_textBox.Text = V;


        }

        private void printpreview_button_Click(object sender, EventArgs e)
        {
            finalprintPreviewDialog.Document = finalprintDocument;
            finalprintPreviewDialog.Show();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            finalprintDialog.ShowDialog();
            finalprintDocument.Print();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            //string C = Convert.ToString(client_textBox.Text);

            if (client_textBox.Text == "")
            {
                client_textBox.Text = "   -";
            }
            else
            {

            }

            //string pono = Convert.ToString(pono_textBox.Text);

            if (pono_textBox.Text == "")
            {
                pono_textBox.Text = "   -";
            }
            else
            {

            }


            if (podate_textBox.Text == "DD/MM/YYYY")
            {
                podate_textBox.Text = "   -";
            }
            else
            {

            }

            if (staticpressure_textBox.Text == "150")
            {
                staticpressure_textBox.Text = Convert.ToString(0.000017);
            }
            else if (staticpressure_textBox.Text == "")
            {
                staticpressure_textBox.Text = Convert.ToString(150);
            }

            if (temp_textBox.Text == "20")
            {
                temp_textBox.Text = Convert.ToString(20);
            }
            else if (temp_textBox.Text == "")
            {
                temp_textBox.Text = Convert.ToString(20);
            }

            //string wono = Convert.ToString(wono_textBox.Text);

            if (wono_textBox.Text == "")
            {
                wono_textBox.Text = "   -";
            }
            else
            {

            }

            if (tagno_textBox.Text == "")
            {
                tagno_textBox.Text = "   -";
            }
            else
            {

            }

            double d = double.Parse(probewidth_textBox.Text);

            if (viscosity_textBox.Text == "0.000017")
            {
                viscosity_textBox.Text = Convert.ToString(0.000017);
                //double VIS = Convert.ToDouble(viscosity_textBox.Text);
            }
           else if (viscosity_textBox.Text == "")
            {
                viscosity_textBox.Text = Convert.ToString(0.000017);
                //double VIS = Convert.ToDouble(viscosity_textBox.Text);
            }

            double VIS = Convert.ToDouble(viscosity_textBox.Text);

            if (staticpressure_textBox.Text == "")
            {
                staticpressure_textBox.Text = Convert.ToString(150);
            }
            else
            {
                //double.Parse(temp_textBox.Text);
            }
            double P = double.Parse(staticpressure_textBox.Text);

            if (temp_textBox.Text == "")
            {
                temp_textBox.Text = Convert.ToString(20);
            }
            else
            {
                //double.Parse(temp_textBox.Text);
            }
             double t = double.Parse(temp_textBox.Text);
            
            double D = double.Parse(pipeid_textBox.Text);
            double D2o = D * D;
            double D2 = ((Math.Truncate(D2o * 10000) / 10000));
            //double D2 = Math.Round(D2o, 4);


            double Ro = double.Parse(fluiddensity_textBox.Text);
            double R = ((Math.Truncate(Ro * 10000) / 10000));
            //double R = Math.Round(Ro, 4);

            double Qo = double.Parse(flow_textBox.Text);
            double Q = ((Math.Truncate(Qo * 10000) / 10000));
            //double Q = Math.Round(Qo, 4);

            double Bd = Convert.ToDouble(d * 10);
            double Bo = Convert.ToDouble(((4 * Bd) / (3.14 * D)));
            double B = ((Math.Truncate(Bo * 1000000) / 1000000));
            //double B = Math.Round(Bo, 4);
            //textBox1.Text = Convert.ToString(B);

            double DDH =(D / 1000) ;

            double Vo = Convert.ToDouble(((Q / (0.785398 * ((DDH) * (DDH)))) / 3600));
            double V = ((Math.Truncate(Vo * 1000000) / 1000000));
            //double V = Math.Round(Vo, 4);
            velocity_textBox.Text = Convert.ToString(V);

            double DVR = (d * V * R);
            //textBox1.Text = Convert.ToString(DVR);


            double Reo = Convert.ToDouble(((DVR) / (100 * (VIS))));
            double Re = ((Math.Truncate(Reo * 1000) / 1000));
            //double Re = Math.Round(Reo, 2);
            Re_textBox.Text = Convert.ToString(Re);

            double C1 = -1.5;
            double C2 = 0.57;

            double OMC2BO = (1 - (C2 * B));
            double OMC2B = ((Math.Truncate(OMC2BO * 100000000) / 100000000));
            //textBox1.Text = Convert.ToString(OMC2B);

            double Ko = Convert.ToDouble(((OMC2B) / (Math.Sqrt(1 - (C1 * ((OMC2B) * (OMC2B)))))));
            double K = (Math.Truncate(10000 * Ko) / 10000);
            //double K = Math.Round(Ko,4);
            ac_textBox.Text = Convert.ToString(K);

            double Gflv = 0.9;
            double Fnalv = 0.000396;
            double Fnalm = 0.012511;
            double Fnagsm = 0.012511;
            double Fnavsc = 0.0011227;
            double Fnavac = 0.012511;
            double Faalv = 1;
            double Faalm = 1.008;
            double Faavsc = 1;
            double Faagsm = 1.008;
            double Faavac = 1.008;
            double Ftfvsco = Convert.ToDouble((Math.Sqrt((289 / (t + 273)))));
            double Ftfvsc = ((Math.Truncate(Ftfvsco * 1000000) / 1000000));
            //double Ftfvsc = Math.Round(Ftfvsco, 6);
            double Ftbvsc = 1;
            double Fpbvsc = 1;
            double Fgvsc = 1;
            double Fpvvsc = 1;
            double Yagsm = 1;
            double Yavsc = 1;
            double Yavac = 1;
            double KPao = Convert.ToDouble((0.009806645969 * (10332 + Convert.ToDouble(staticpressure_textBox.Text))));
            double KPa = ((Math.Truncate(KPao * 100000000) / 100000000));
            //double KPa = Math.Round(KPao, 8);


            if (rof_comboBox.SelectedIndex == 0)
            {
                double lveo = Convert.ToDouble(((Q / (Fnalv * K * D2 * Faalv * (Math.Sqrt((1 / Gflv))))) * (Q / (Fnalv * K * D2 * Faalv * (Math.Sqrt((1 / Gflv)))))));
                double lvo = ((Math.Truncate(lveo * 1000000) / 1000000));
                //double lvo = Math.Round(lveo, 6);
                rof_textBox.Text = Convert.ToString(lvo) + " mmwc at  " + t + "°c";
            }
            else if (rof_comboBox.SelectedIndex == 1)
            {
                double lmeo = Convert.ToDouble(((Q / (Fnalm * K * D2 * Faalm * (Math.Sqrt(R)))) * (Q / (Fnalm * K * D2 * Faalm * (Math.Sqrt(R))))));
                double lmo = ((Math.Truncate(lmeo * 1000000) / 1000000));
                //double lmo = Math.Round(lmeo, 6);
                rof_textBox.Text = Convert.ToString(lmo) + " mmwc at  " + t + "°c";
            }
            else if (rof_comboBox.SelectedIndex == 2)
            {
                double gsmeo = Convert.ToDouble((Q / (Fnagsm * K * D * D * Yagsm * Faagsm * (Math.Sqrt(R)))) * (Q / (Fnagsm * K * D * D * Yagsm * Faagsm * (Math.Sqrt(R)))));
                double gsmo = ((Math.Truncate(gsmeo * 1000000) / 1000000));
                //double gsmo = Math.Round(gsmeo, 6);
                rof_textBox.Text = Convert.ToString(gsmo) + " mmwc at  " + t + "°c";
            }
            else if (rof_comboBox.SelectedIndex == 3)
            {
                double vsceo = Convert.ToDouble((Q / (Fnavsc * K * D2 * Yavsc * Fpbvsc * Ftbvsc * Ftfvsc * Fgvsc * Fpvvsc * Faavsc * (Math.Sqrt(KPa)))) * (Q / (Fnavsc * K * D2 * Yavsc * Fpbvsc * Ftbvsc * Ftfvsc * Fgvsc * Fpvvsc * Faavsc * (Math.Sqrt(KPa)))));
                double vsco = ((Math.Truncate(vsceo * 1000000) / 1000000));
                //double vsco = Math.Round(vsceo, 6);
                rof_textBox.Text = Convert.ToString(vsco) + " mmwc at  " + t + "°c";
            }
            else if (rof_comboBox.SelectedIndex == 4)
            {
                double vaceo = Convert.ToDouble((Q / (Fnavac * K * D2 * Yavac * Faavac * (Math.Sqrt(1 / R)))) * (Q / (Fnavac * K * D2 * Yavac * Faavac * (Math.Sqrt(1 / R)))));
                double vaco = ((Math.Truncate(vaceo * 1000000) / 1000000));
                //double vaco = Math.Round(vaceo, 6);
                rof_textBox.Text = Convert.ToString((vaco)) + " mmwc at  " + t + "°c";
            }
            else
            {
                rof_comboBox.Text = "SELECT";
            }

            if (rof_comboBox.Text == "SELECT")
            {
                rof_textBox.Text = "-";
            }

        }

        private void finalprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //string C = Convert.ToString(client_textBox.Text);

            if (client_textBox.Text == "")
            {
                client_textBox.Text = "   -";
            }
            else
            {

            }

            //string pono = Convert.ToString(pono_textBox.Text);

            if (pono_textBox.Text == "")
            {
                pono_textBox.Text = "   -";
            }
            else
            {

            }

            if (podate_textBox.Text == "DD/MM/YYYY")
            {
                podate_textBox.Text = "   -";
            }
            else
            {

            }

            //string wono = Convert.ToString(wono_textBox.Text);

            if (wono_textBox.Text == "")
            {
                wono_textBox.Text = "   -";
            }
            else
            {

            }

            if (tagno_textBox.Text == "")
            {
                tagno_textBox.Text = "   -";
            }
            else
            {

            }

            double d = double.Parse(probewidth_textBox.Text);

            if (viscosity_textBox.Text == "0.000017")
            {
                viscosity_textBox.Text = Convert.ToString(0.000017);
            }
            else if (viscosity_textBox.Text == "")
            {
                viscosity_textBox.Text = Convert.ToString(0.000017);
            }

            if (staticpressure_textBox.Text == "150")
            {
                staticpressure_textBox.Text = Convert.ToString(0.000017);
            }
            else if (staticpressure_textBox.Text == "")
            {
                staticpressure_textBox.Text = Convert.ToString(150);
            }

            if (temp_textBox.Text == "20")
            {
                temp_textBox.Text = Convert.ToString(20);
            }
            else if (temp_textBox.Text == "")
            {
                temp_textBox.Text = Convert.ToString(20);
            }

            if (staticpressure_textBox.Text == "")
            {
                staticpressure_textBox.Text = Convert.ToString(150);
            }
            else
            {
                //double.Parse(temp_textBox.Text);
            }
            double P = double.Parse(staticpressure_textBox.Text);

            if (temp_textBox.Text == "")
            {
                temp_textBox.Text = Convert.ToString(20);
            }
            else
            {
                //double.Parse(temp_textBox.Text);
            }
            double t = double.Parse(temp_textBox.Text);

            double D = double.Parse(pipeid_textBox.Text);
            double D2o = D * D;
            double D2 = ((Math.Truncate(D2o * 10000) / 10000));
            //double D2 = Math.Round(D2o, 4);


            double Ro = double.Parse(fluiddensity_textBox.Text);
            double R = ((Math.Truncate(Ro * 10000)/ 10000));
            //double R = Math.Round(Ro, 4);

            double Qo = double.Parse(flow_textBox.Text);
            double Q = ((Math.Truncate(Qo * 10000) / 10000));
            //double Q = Math.Round(Qo, 4);

            double Bo = Convert.ToDouble(((4 * d) / (Math.PI * D)));
            double B = ((Math.Truncate(Bo * 10000)/ 10000));
            //double B = Math.Round(Bo, 4);

            double Vo = Convert.ToDouble(((Q / (0.785398 * ((D / 1000) * (D / 1000)))) / 3600));
            double V = ((Math.Truncate(Vo * 10000) / 10000));
            //double V = Math.Round(Vo, 4);
            velocity_textBox.Text = Convert.ToString(V);

            double Reo = Convert.ToDouble(((d * V * R) / (100 * (Convert.ToDouble(viscosity_textBox.Text)))));
            double Re = ((Math.Truncate(Reo * 100) / 100));
            //double Re = Math.Round(Reo, 2);
            Re_textBox.Text = Convert.ToString(Re);

            double C1 = -1.5;
            double C2 = 0.57;

            double OMC2BO = (1-(C2 * B));
            double OMC2B = ((Math.Truncate(OMC2BO * 100000000) / 100000000));
            //textBox1.Text = Convert.ToString(OMC2B);

            double Ko = Convert.ToDouble(((OMC2B) / (Math.Sqrt(1 - (C1 * ((OMC2B) *(OMC2B)))))));
            double K = (Math.Truncate(10000 * Ko)/10000);
            //double K = Math.Round(Ko,4);
            ac_textBox.Text = Convert.ToString(K);

            double Gflv = 0.9;
            double Fnalv = 0.000396;
            double Fnalm = 0.012511;
            double Fnagsm = 0.012511;
            double Fnavsc = 0.0011227;
            double Fnavac = 0.012511;
            double Faalv = 1;
            double Faalm = 1.008;
            double Faavsc = 1;
            double Faagsm = 1.008;
            double Faavac = 1.008;
            double Ftfvsco = Convert.ToDouble((Math.Sqrt((289 / (Convert.ToDouble(temp_textBox.Text) + 273)))));
            double Ftfvsc = ((Math.Truncate(Ftfvsco * 1000000) / 1000000));
            //double Ftfvsc = Math.Round(Ftfvsco, 6);
            double Ftbvsc = 1;
            double Fpbvsc = 1;
            double Fgvsc = 1;
            double Fpvvsc = 1;
            double Yagsm = 1;
            double Yavsc = 1;
            double Yavac = 1;
            double KPao = Convert.ToDouble((0.009806645969 * (10332 + Convert.ToDouble(staticpressure_textBox.Text))));
            double KPa = ((Math.Truncate(KPao * 100000000) / 100000000));
            //double KPa = Math.Round(KPao, 8);

            if (rof_comboBox.Text == "SELECT")
            {
                rof_textBox.Text = "   -";
            }

            Bitmap bmp = Properties.Resources.logoFFCY_22;
            Image footer = bmp;

            Font drawFont = new Font("Roboto", 12);
            Font drawFontm = new Font("Roboto", 11, FontStyle.Bold);
            Font drawFontBold = new Font("Roboto", 12, FontStyle.Bold);
            Font drawFontUnderline = new Font("Roboto", 12, FontStyle.Underline);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawHeader = new Font("Square721 BT", 19, FontStyle.Bold);
            Font drawFooter = new Font("Roboto", 9, FontStyle.Bold);

            e.Graphics.DrawString("PITOT TUBE DIFFERENTIAL PRESSURE CALCULATOR", drawHeader, drawBrush, new Point(30, 40));

            e.Graphics.DrawString(DateTime.Now.Date.ToString("dd/MM/yyyy"), drawFont, drawBrush, new Point(25, 115));
            e.Graphics.DrawString("Page 1", drawFont, drawBrush, new Point(750, 115));
            e.Graphics.DrawString(DashLine.Text, drawFontBold, drawBrush, new Point(25, 120));

            e.Graphics.DrawString("CLIENT: ", drawFontBold, drawBrush, new Point(25, 155));
            e.Graphics.DrawString(client_textBox.Text , drawFont, drawBrush, new Point(90, 155));

            e.Graphics.DrawString("P.O. No.: ", drawFontBold, drawBrush, new Point(25, 175));
            e.Graphics.DrawString(pono_textBox.Text , drawFont, drawBrush, new Point(95, 175));

            e.Graphics.DrawString("P.O. DATE: ", drawFontBold, drawBrush, new Point(350, 175));
            e.Graphics.DrawString(podate_textBox.Text, drawFont, drawBrush, new Point(435, 175));

            e.Graphics.DrawString("W.O. No.: ", drawFontBold, drawBrush, new Point(25, 195));
            e.Graphics.DrawString(wono_textBox.Text , drawFont, drawBrush, new Point(100, 195));

            e.Graphics.DrawString("TAG No.: ", drawFontBold, drawBrush, new Point(350, 195));
            e.Graphics.DrawString(tagno_textBox.Text, drawFont, drawBrush, new Point(435, 195));

            e.Graphics.DrawString(DashLine.Text, drawFontBold, drawBrush, new Point(25, 210));

            e.Graphics.DrawString("INPUT DATA:", drawFontBold, drawBrush, new Point(25, 235));
            e.Graphics.DrawString("_____________", drawFontBold, drawBrush, new Point(25, 235));

            e.Graphics.DrawString("PIPE INTERNAL DIAMETER: ", drawFont, drawBrush, new Point(38, 305));
            e.Graphics.DrawString(D + " mm", drawFont, drawBrush, new Point(513, 305));

            e.Graphics.DrawString("OPERATING FLUID DENSITY: ", drawFont, drawBrush, new Point(38, 325));
            e.Graphics.DrawString(R + " kg/m³", drawFont, drawBrush, new Point(513, 325));

            e.Graphics.DrawString("FLOW: ", drawFont, drawBrush, new Point(38, 345));
            e.Graphics.DrawString(Qo + " m³/hr", drawFont, drawBrush, new Point(513, 345));

            e.Graphics.DrawString("PROBE WIDTH: ", drawFont, drawBrush, new Point(38, 365));
            e.Graphics.DrawString(d + " cm", drawFont, drawBrush, new Point(513, 365));

            e.Graphics.DrawString("OPERATING TEMPRATURE: ", drawFont, drawBrush, new Point(38, 385));
            e.Graphics.DrawString(t + " °c", drawFont, drawBrush, new Point(513, 385));

            e.Graphics.DrawString("STATIC PRESSURE: ", drawFont, drawBrush, new Point(38, 405));
            e.Graphics.DrawString(Convert.ToString(staticpressure_textBox.Text) + " mmwc", drawFont, drawBrush, new Point(513, 405));

            e.Graphics.DrawString("FLUID VISCOSITY: ", drawFont, drawBrush, new Point(38, 425));
            e.Graphics.DrawString(viscosity_textBox.Text + " kg/m-s", drawFont, drawBrush, new Point(513, 425));

            e.Graphics.DrawString("OUTPUT DATA: ", drawFontBold, drawBrush, new Point(25, 465));
            e.Graphics.DrawString("_______________", drawFontBold, drawBrush, new Point(25, 465));


            e.Graphics.DrawString("ANNUBAR COEFFICIENT: ", drawFont, drawBrush, new Point(38, 515));
            e.Graphics.DrawString(K + "", drawFont, drawBrush, new Point(513, 515));

            e.Graphics.DrawString("REYNOLDS NO.(Re): ", drawFont, drawBrush, new Point(38, 535));
            e.Graphics.DrawString(Re + "", drawFont, drawBrush, new Point(513, 535));

            e.Graphics.DrawString("VELOCITY: ", drawFont, drawBrush, new Point(38, 555));
            e.Graphics.DrawString(Vo + " m/s", drawFont, drawBrush, new Point(513, 555));


            if (rof_comboBox.SelectedIndex == 0)
            {
                double lveo = Convert.ToDouble(((Q / (Fnalv * K * D2 * Faalv * (Math.Sqrt((1 / Gflv))))) * (Q / (Fnalv * K * D2 * Faalv * (Math.Sqrt((1 / Gflv)))))));
                double lvo = ((Math.Truncate(lveo * 1000000) / 1000000));
                //double lvo = Math.Round(lveo, 6);
                e.Graphics.DrawString("MEASUREMENT CONDITION: ", drawFontBold, drawBrush, new Point(38, 285));
                e.Graphics.DrawString(rof_comboBox.Text, drawFontm, drawBrush, new Point(270, 285));
                e.Graphics.DrawString("DIFFERENTIAL PRESSURE: ", drawFontBold, drawBrush, new Point(38, 575));
                e.Graphics.DrawString(lvo + " mmwc at  " + Convert.ToDouble(temp_textBox.Text) + "°c", drawFontBold, drawBrush, new Point(513, 575));
            }
            else if (rof_comboBox.SelectedIndex == 1)
            {
                double lmeo = Convert.ToDouble(((Q / (Fnalm * K * D2 * Faalm * (Math.Sqrt(R)))) * (Q / (Fnalm * K * D2 * Faalm * (Math.Sqrt(R))))));
                double lmo = ((Math.Truncate(lmeo * 1000000) / 1000000));
                //double lmo = Math.Round(lmeo, 6);
                e.Graphics.DrawString("MEASUREMENT CONDITION: ", drawFontBold, drawBrush, new Point(38, 285));
                e.Graphics.DrawString(rof_comboBox.Text, drawFontm, drawBrush, new Point(270, 285));
                e.Graphics.DrawString("DIFFERENTIAL PRESSURE: ", drawFontBold, drawBrush, new Point(38, 575));
                e.Graphics.DrawString(lmo + " mmwc at  " + Convert.ToDouble(temp_textBox.Text) + "°c", drawFontBold, drawBrush, new Point(513, 575));
            }
            else if (rof_comboBox.SelectedIndex == 2)
            {
                double gsmeo = Convert.ToDouble((Q / (Fnagsm * K * D * D * Yagsm * Faagsm * (Math.Sqrt(R)))) * (Q / (Fnagsm * K * D * D * Yagsm * Faagsm * (Math.Sqrt(R)))));
                double gsmo = ((Math.Truncate(gsmeo * 1000000) / 1000000));
                //double gsmo = Math.Round(gsmeo, 6);
                e.Graphics.DrawString("MEASUREMENT CONDITION: ", drawFontBold, drawBrush, new Point(38, 285));
                e.Graphics.DrawString(rof_comboBox.Text, drawFontm, drawBrush, new Point(270, 285));
                e.Graphics.DrawString("DIFFERENTIAL PRESSURE: ", drawFontBold, drawBrush, new Point(38, 575));
                e.Graphics.DrawString(gsmo + " mmwc at  " + Convert.ToDouble(temp_textBox.Text) + "°c", drawFontBold, drawBrush, new Point(513, 575));
            }
            else if (rof_comboBox.SelectedIndex == 3)
            {
                double vsceo = Convert.ToDouble((Q / (Fnavsc * K * D2 * Yavsc * Fpbvsc * Ftbvsc * Ftfvsc * Fgvsc * Fpvvsc * Faavsc * (Math.Sqrt(KPa)))) * (Q / (Fnavsc * K * D2 * Yavsc * Fpbvsc * Ftbvsc * Ftfvsc * Fgvsc * Fpvvsc * Faavsc * (Math.Sqrt(KPa)))));
                double vsco = ((Math.Truncate(vsceo * 1000000) / 1000000));
                //double vsco = Math.Round(vsceo, 6);
                e.Graphics.DrawString("MEASUREMENT CONDITION: ", drawFontBold, drawBrush, new Point(38, 285));
                e.Graphics.DrawString(rof_comboBox.Text, drawFontm, drawBrush, new Point(270, 285));
                e.Graphics.DrawString("DIFFERENTIAL PRESSURE: ", drawFontBold, drawBrush, new Point(38, 575));
                e.Graphics.DrawString(vsco + " mmwc at  " + Convert.ToDouble(temp_textBox.Text) + "°c", drawFontBold, drawBrush, new Point(513, 575));
            }
            else if (rof_comboBox.SelectedIndex == 4)
            {
                double vaceo = Convert.ToDouble((Q / (Fnavac * K * D2 * Yavac * Faavac * (Math.Sqrt(1 / R)))) * (Q / (Fnavac * K * D2 * Yavac * Faavac * (Math.Sqrt(1 / R)))));
                double vaco = ((Math.Truncate(vaceo * 1000000) / 1000000));
                //double vaco = Math.Round(vaceo, 6);
                e.Graphics.DrawString("MEASUREMENT CONDITION: ", drawFontBold, drawBrush, new Point(38, 285));
                e.Graphics.DrawString(rof_comboBox.Text, drawFontm, drawBrush, new Point(270, 285));
                e.Graphics.DrawString("DIFFERENTIAL PRESSURE: ", drawFontBold, drawBrush, new Point(38, 575));
                e.Graphics.DrawString(vaco + " mmwc at  " + Convert.ToDouble(temp_textBox.Text) + "°c", drawFontBold, drawBrush, new Point(513, 575));
            }
            else
            {
                e.Graphics.DrawString("DIFFERENTIAL PRESSURE: ", drawFontBold, drawBrush, new Point(38, 575));
                e.Graphics.DrawString("NOT SELECTED!", drawFontBold, drawBrush, new Point(513, 575));
            }


            e.Graphics.DrawString(DashLine.Text, drawFontBold, drawBrush, new Point(25, 610));

            e.Graphics.DrawImage(footer, 25, 945, footer.Width, footer.Height);

            e.Graphics.DrawString("Office No. 53, Shree Manoshi Complex, Plot No. 5 & 6, Sector 3, Opp. Ghansoli Railway Station,", drawFooter, drawBrush, new Point(25, 990));
            e.Graphics.DrawString("Ghansoli (East), Navi Mumbai – 400701, Maharashtra, INDIA.", drawFooter, drawBrush, new Point(25, 1010));
            e.Graphics.DrawString("Tel:  +91-22-2549 1407 / 2549 1408 / 2549 1409 / +91-22-2549 2779 / 2754 0585 / 2754 0586", drawFooter, drawBrush, new Point(25, 1030));
            //e.Graphics.DrawString("Fax: +91-22-2549 2708 / 2549 1408", drawFooter, drawBrush, new Point(25, 1030));
            e.Graphics.DrawString("Email: sales@scientificdevices.org", drawFooter, drawBrush, new Point(25, 1050));
            e.Graphics.DrawString("Website: sdbplonline.com | scientificdevices.org", drawFooter, drawBrush, new Point(25, 1070));

        }

        private void FINALDEMOPITOTTUBE_Load(object sender, EventArgs e)
        {
            
        }

        private void DashLine_Click(object sender, EventArgs e)
        {

        }

        private void podate_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rof_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rof_comboBox.SelectedIndex == 3)
            {
                staticpressure_label.Text = "STATIC PR. (mmwc):";
                staticpressure_textBox.Show();

                temp_label.Text = "OPTG. TEMP. (°c):";
                temp_textBox.Show();
            }
            else
            {
                staticpressure_label.Text = "";
                staticpressure_textBox.Hide();

                temp_label.Text = "";
                temp_textBox.Hide();
            }
        }

        private void title_label_Click(object sender, EventArgs e)
        {

        }
    }
}
