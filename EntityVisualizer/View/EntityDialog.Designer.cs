namespace EntityVisualizer
{
    partial class EntityDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridEntity = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEntity
            // 
            this.GridEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEntity.Location = new System.Drawing.Point(0, 0);
            this.GridEntity.Name = "GridEntity";
            this.GridEntity.RowTemplate.Height = 21;
            this.GridEntity.Size = new System.Drawing.Size(510, 261);
            this.GridEntity.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntityDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 293);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridEntity);
            this.Name = "EntityDialog";
            this.Text = "エンティティ ビジュアライザ";
            this.Load += new System.EventHandler(this.EntityDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEntity;
        private System.Windows.Forms.Button button1;
    }
}