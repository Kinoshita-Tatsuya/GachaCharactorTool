using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GachaTool.Models.Services;
using MySql.Data.MySqlClient;

namespace GachaTool.Views
{
    public partial class frmGachaCharactor : Form
    {
        public frmGachaCharactor()
        {
            InitializeComponent();
        }

        //読み込みボタン
        private void Button1_Click_1(object sender, EventArgs e)
        {
            using (var connction = Connection.OpenLocal())
            {
                var dataTable = new DataTable();
                var cmd = new MySqlCommand("SELECT * FROM gachatable", connction);
                var dataAdapter = new MySqlDataAdapter(cmd);

                //データ取得 
                dataAdapter.Fill(dataTable);

                //データ表示
                this.dgShowGachaChara.DataSource = dataTable;
            }

            //読み込み時のID数を保存しておく
            currentRowIndex = this.dgShowGachaChara.Rows.Count;
        }

        //更新ボタン
        private void Button1_Click(object sender, EventArgs e)
        {
            //行数の差分割り出す
            var diffRowIndex = this.dgShowGachaChara.Rows.Count - currentRowIndex;

            //行が追加されていなかったら
            if (diffRowIndex < 0) return;

            using (var connction = Connection.OpenLocal())
            {
                //-1は勝手に追加されているrowの分を減らしている
                var insertRowIndex = this.dgShowGachaChara.Rows.Count - diffRowIndex - 1;

                for (; insertRowIndex < dgShowGachaChara.Rows.Count - 1; ++insertRowIndex)
                {
                    var cmd = new MySqlCommand("insert into gachatable " +
                    "values (?ID, ?CharactorName, ?Probability, ?Rarity, ?Image )", connction);

                    cmd.Parameters.Add(new MySqlParameter("ID",
                        Convert.ToInt32(dgShowGachaChara.Rows[insertRowIndex].Cells[0].Value)));

                    cmd.Parameters.Add(new MySqlParameter("CharactorName",
                        Convert.ToString(dgShowGachaChara.Rows[insertRowIndex].Cells[1].Value)));

                    cmd.Parameters.Add(new MySqlParameter("Probability",
                        Convert.ToSingle(dgShowGachaChara.Rows[insertRowIndex].Cells[2].Value)));

                    cmd.Parameters.Add(new MySqlParameter("Rarity",
                        Convert.ToInt32(dgShowGachaChara.Rows[insertRowIndex].Cells[3].Value)));

                    cmd.Parameters.Add(new MySqlParameter("Image",
                        Convert.ToString(dgShowGachaChara.Rows[insertRowIndex].Cells[4].Value)));

                    //実行
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int currentRowIndex;
    }
}
