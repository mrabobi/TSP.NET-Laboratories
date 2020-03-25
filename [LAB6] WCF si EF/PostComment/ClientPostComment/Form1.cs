using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPostComment
{
    public partial class Form1 : Form
    {
     

        private void InitializeComponent()
        {
            this.dgp = new System.Windows.Forms.DataGridView();
            this.dgc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgp
            // 
            this.dgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp.Location = new System.Drawing.Point(12, 12);
            this.dgp.Name = "dgp";
            this.dgp.RowHeadersWidth = 51;
            this.dgp.RowTemplate.Height = 24;
            this.dgp.Size = new System.Drawing.Size(371, 365);
            this.dgp.TabIndex = 0;
            this.dgp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgp_CellContentClick);
            // 
            // dgc
            // 
            this.dgc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc.Location = new System.Drawing.Point(487, 12);
            this.dgc.Name = "dgc";
            this.dgc.RowHeadersWidth = 51;
            this.dgc.RowTemplate.Height = 24;
            this.dgc.Size = new System.Drawing.Size(371, 365);
            this.dgc.TabIndex = 1;
            this.dgc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgc_CellContentClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(913, 389);
            this.Controls.Add(this.dgc);
            this.Controls.Add(this.dgp);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
