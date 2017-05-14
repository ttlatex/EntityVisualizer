using System;
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
            GridEntity.DataSource = _entity;
            GridEntity.RowHeadersVisible = false; // 行ヘッダ非表示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
