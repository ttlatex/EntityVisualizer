using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityVisualizer
{
    public partial class EntityDialog : Form
    {
        // データソース
        private dynamic _entity;

        public EntityDialog(dynamic entity)
        {
            InitializeComponent();
            _entity = entity;
        }

        private void EntityDialog_Load(object sender, EventArgs e)
        {
            if (_entity.Count == 0) return;

            GridEntity.DataSource = _entity;
            GridEntity.RowHeadersVisible = false; // 行ヘッダ非表示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
