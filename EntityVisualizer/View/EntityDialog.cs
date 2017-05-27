using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntityVisualizer
{
    public partial class EntityDialog : Form
    {
        // データソース
        private Dictionary<string, object>[] _entity;

        public EntityDialog(Dictionary<string, object>[] entity)
        {
            InitializeComponent();
            _entity = entity;
        }

        private void EntityDialog_Load(object sender, EventArgs e)
        {
            GridEntity.RowHeadersVisible = false; // 行ヘッダ非表示
            this.MapToGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// データをグリッドにマッピングする
        /// </summary>
        private void MapToGrid()
        {
            if (this._entity.Length == 0) return;

            var headerNames = _entity[0].Select(x => x.Key).ToArray();

            var dt = new DataTable();

            // 列追加
            foreach (var name in headerNames)
            {
                dt.Columns.Add(name);
            }

            // 行追加
            foreach (var record in this._entity)
            {
                var obj = headerNames.Select(x => record[x]).ToArray();
                dt.Rows.Add(obj);
            }

            // データバインド
            GridEntity.DataSource = dt;

        }
    }
}
