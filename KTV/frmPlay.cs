using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTV
{
    public partial class frmPlay : Form
    {
        public frmPlay()
        {
            InitializeComponent();
        }
        public frmPlay(string strPaht)
        {
            InitializeComponent();
            strPath = strPaht;
        }
        public string strPath = null;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void frmPlay_Load(object sender, EventArgs e)
        {
            //�����ļ�
            this.axWindowsMediaPlayer1.URL = strPath;
        }

        private void bntExce_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
        }

        private void bntZan_Click(object sender, EventArgs e)
        {
            if (bntZan.Text == "��ͣ(&K)")
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();
                bntZan.Text = "����(&K)";
            }
            else
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
                bntZan.Text = "��ͣ(&K)";
            }
        }
    }
}