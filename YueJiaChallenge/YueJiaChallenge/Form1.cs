using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YueJiaChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void drawCustomer(float x, float y,Graphics g) {
            Color col = Color.FromArgb(255,102,204,0);
            Brush br = new SolidBrush(col);
            g.FillEllipse(br, x, y, 9, 9);
        }
        public void drawSupplier(float x, float y, Graphics g)
        {
            Color col = Color.FromArgb(255, 255, 0, 127);
            Brush br = new SolidBrush(col);
            g.FillEllipse(br, x, y, 9, 9);
        }
        public ArrayList customer(int i,Graphics g) {
            ArrayList cust = new ArrayList();
            Random rd = new Random();
            for (int j = 0; j < i; j++) {
                Point pt = new Point(rd.Next(300,1000), rd.Next(0,700));
                cust.Add(pt);
                drawCustomer(pt.X,pt.Y,g);
            }
            return cust;
        }
        public ArrayList supplier(int i, Graphics g)
        {
            ArrayList supp = new ArrayList();
            Random rd = new Random();
            for (int j = 0; j < i; j++)
            {
                Point pt = new Point(rd.Next(350, 950), rd.Next(50, 650));
                supp.Add(pt);
                drawSupplier(pt.X, pt.Y, g);
            }
            return supp;
        }

        public void drawLine(Graphics g,Color color,float x1,float y1,float x2,float y2) {
            Pen p = new Pen(color);
            g.DrawLine(p,x1,y1,x2,y2);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Refresh();
            //draw points
            Graphics g = CreateGraphics();
            try
            {
                ArrayList s = new ArrayList(supplier(Convert.ToInt32(Supp.Text), g));
                ArrayList c = new ArrayList(customer(Convert.ToInt32(Cust.Text), g));
                //draw line logic

                float x = -50;
                float y = -50;
                for (int i = 0; i < c.Count; i++)
                {
                    double min = 999999;
                    for (int j = 0; j < s.Count; j++)
                    {
                        double temp = Math.Sqrt(Math.Pow(((((Point)s[j]).X - ((Point)c[i]).X)), 2) + Math.Pow(((((Point)s[j]).Y - ((Point)c[i]).Y)), 2));
                        if (min > temp)
                        {
                            min = temp;
                            x = ((Point)s[j]).X;
                            y = ((Point)s[j]).Y;
                        }

                    }
                    drawLine(g, Color.FromArgb(255, 0, Convert.ToInt32(x / 4), Convert.ToInt32(y / 4)), x, y, ((Point)c[i]).X, ((Point)c[i]).Y);
                }
            }
            catch (Exception ee) {
                MessageBox.Show(ee.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
