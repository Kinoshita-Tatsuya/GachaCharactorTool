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
using GachaTool.Models.ValueObjects;
using MySql.Data.MySqlClient;

namespace GachaTool.Views
{
    public partial class frmGachaCharactor : Form
    {
        public frmGachaCharactor()
        {
            InitializeComponent();
        }

        private void FrmGachaCharactor_Load(object sender, EventArgs e)
        {
            DisplayDB();

            dgShowGachaChara.AllowUserToAddRows = false;
        }

        //読み込みボタン
        private void BtnLoadGachaChara_Click(object sender, EventArgs e)
        {
            DisplayDB();
        }

        //更新ボタン
        private void BtnGachaCharaUpdate_Click(object sender, EventArgs e)
        {
            var sql = new StringBuilder();

            for (var row = 0; row < dgShowGachaChara.RowCount; ++row)
            {
                sql.Append("UPDATE ");
                sql.Append("gachatable");
                sql.Append(" SET ");

                for (var column = 1; column < dgShowGachaChara.ColumnCount; ++column)
                {
                    string value = dgShowGachaChara.Rows[row].Cells[column].Value.ToString();

                    if (value == "" || value == null) continue;

                    sql.Append("`").Append(dgShowGachaChara.Columns[column].Name).Append("`");
                    sql.Append(" = ");

                    sql.Append("'").Append(value).Append("'");
                    sql.Append(",");
                }

                sql.Remove(sql.Length - 1, 1);

                sql.Append(" WHERE (`Id` = ");
                sql.Append(dgShowGachaChara.Rows[row].Cells[0].Value.ToString());
                sql.Append(");");

                using (var con = Connection.OpenLocal())
                {
                    var cmd = new MySqlCommand(sql.ToString(), con);

                    cmd.ExecuteNonQuery();
                }

                sql.Clear();
            }
        }

        private void DisplayDB()
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
        }

        /// <summary>
        /// IDを自動的に割り当てる
        /// </summary>
        /// <returns>次のIDの値</returns>
        private int AssignID()
        {
            var rowCnt = dgShowGachaChara.RowCount;

            int nextId = Convert.ToInt16(dgShowGachaChara.Rows[rowCnt - 1].Cells[0].Value) + 1;

            dgShowGachaChara.Rows[rowCnt - 1].Cells[0].Value = nextId;

            return nextId;
        }

        private void BtnInsertChara_Click(object sender, EventArgs e)
        {
            var frm = new frmCharaParamSetter();
            frm.ShowDialog();

            var param = new CharactorParameter();
            param = frm.resultParam;

            frm.Dispose();

            using (var connction = Connection.OpenLocal())
            {
                var cmd = new MySqlCommand("insert into gachatable " +
                "values (@ID, @CharactorName, @Probability, @Rarity, @Image )", connction);
                
                param.ID = AssignID();

                cmd.Parameters.Add(new MySqlParameter("@ID", param.ID));
                cmd.Parameters.Add(new MySqlParameter("@CharactorName", param.Name));
                cmd.Parameters.Add(new MySqlParameter("@Probability", param.Probability));
                cmd.Parameters.Add(new MySqlParameter("@Rarity", param.Rarity));
                cmd.Parameters.Add(new MySqlParameter("@Image", param.Image));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
