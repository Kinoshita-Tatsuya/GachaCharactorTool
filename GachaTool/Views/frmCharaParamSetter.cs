using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GachaTool.Models.ValueObjects;

namespace GachaTool.Views
{
    public partial class frmCharaParamSetter : Form
    {
        public CharactorParameter resultParam = new CharactorParameter();

        public frmCharaParamSetter()
        {
            InitializeComponent();
        }

        private void BtnSaveCharaParam_Click(object sender, EventArgs e)
        {
            if(HaveOmissions())
            {
                MessageBox.Show("入力漏れがあります");
                return;
            }

            resultParam.Name = TxtName.Text;
            resultParam.Rarity = Convert.ToInt16(TxtRarity.Text);
            resultParam.Probability = Convert.ToInt16(TxtProbability.Text);
            resultParam.Image = TxtImage.Text;

            this.Close();
        }

        /// <summary>
        /// 記入漏れがあるか
        /// </summary>
        /// <returns>あったらtrue</returns>
        private bool HaveOmissions()
        {
            if(TxtName.Text.Length == 0 || 
               TxtRarity.Text.Length == 0 ||
               TxtProbability.Text.Length == 0 ||
               TxtImage.Text.Length == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 数字か判断する
        /// </summary>
        /// <param name="e">KeyPressイベントハンドラ</param>
        private void IsNum(KeyPressEventArgs e)
        {
            // 制御文字は入力可
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // 数字(0-9)は入力可
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            
            e.Handled = true;
        }

        private void TxtRarity_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNum(e);
        }

        private void TxtProbability_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNum(e);
        }
    }
}
