using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using KTV.KTVclass;
namespace KTV
{
    public partial class frmNumber : Form
    {
        public frmNumber()
        {
            InitializeComponent();
        }
        public frmNumber(int inCount)
        {
            InitializeComponent();
            intFalg = inCount;
        }
        public int intFalg = 0;//�ؼ��������
        private void frmNumber_Load(object sender, EventArgs e)
        {
            if(intFalg==1)//����
            {
                this.Text = "���ֵ��";
            }
            if(intFalg==2)//ƴ��
            {
                this.Text = "ƴ�����";
            }
            if(intFalg==3)//����
            {
                this.Text = "���ǵ��";
            }
            if(intFalg==4)//����
            {
                this.Text = "�������";
            }
            txtName.Focus();
                

        }

        //ȷ�����ò�ѯ���
        tbMusicnfoMenthod tbMusice = new tbMusicnfoMenthod();//ʵ��������
        
        private void bntOK_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("������ȷ�Ĳ�ѯ������");
                txtName.Focus();
                return;
            }
            frmDaiGe daige = (frmDaiGe)this.Owner;//ʵ���������
            if (intFalg == 1)//����
            {
                //���÷������ҽ�������ؼ�
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 1) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 1;
                    MessageBox.Show("û�в鵽�������������������");
                    txtName.Text = "";
                    txtName.Focus();
                
                }
            }
            if (intFalg == 2)//ƴ��
            {
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 2) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 2;
                    MessageBox.Show("û�н�飬��������������");
                    txtName.Text = "";
                    txtName.Focus();

                }
            }
            if (intFalg == 3)//����
            {
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 3) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 3;
                    MessageBox.Show("û�н�飬��������������");
                    txtName.Text = "";
                    txtName.Focus();

                }
            }
            if (intFalg == 4)//����
            {
                if (tbMusice.tbFill(daige.lvPlay, txtName.Text.Trim(), 4) != 0)
                {
                    intFalg = 0;
                    this.Close();
                }
                else
                {
                    intFalg = 4;
                    MessageBox.Show("û�н�飬��������������\n ���Զ��������ѯ�������˳�","��ѯ��ʾ");
                    txtName.Text = "";
                    txtName.Focus();

                }
            }
        }
        //�ı�������
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (intFalg == 1)//����
            {
                if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
                {
                    MessageBox.Show("���ֵ�裬���������֣�","���ֵ��");
                    e.Handled = true;
                
                }
            }
            if (intFalg == 2)//ƴ��
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                {
                    MessageBox.Show("ƴ����裬������ƴ����", "ƴ�����");
                    e.Handled = true;

                }
            }

        }
        //�˳�
        private void bntEsce_Click(object sender, EventArgs e)
        {

            DialogResult dra = MessageBox.Show("�Ƿ��˳�"+this.Text,"��Ϣ��ʾ",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dra == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}