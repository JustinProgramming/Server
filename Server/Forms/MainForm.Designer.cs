namespace Server.Forms
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpClients = new System.Windows.Forms.TabPage();
            this.tpBuilder = new System.Windows.Forms.TabPage();
            this.gbConnected = new System.Windows.Forms.GroupBox();
            this.lvClients = new System.Windows.Forms.ListView();
            this.chMachineName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcMain.SuspendLayout();
            this.tpClients.SuspendLayout();
            this.gbConnected.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpClients);
            this.tcMain.Controls.Add(this.tpBuilder);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(581, 347);
            this.tcMain.TabIndex = 0;
            // 
            // tpClients
            // 
            this.tpClients.Controls.Add(this.gbConnected);
            this.tpClients.Location = new System.Drawing.Point(4, 22);
            this.tpClients.Name = "tpClients";
            this.tpClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpClients.Size = new System.Drawing.Size(573, 321);
            this.tpClients.TabIndex = 0;
            this.tpClients.Text = "Clients";
            this.tpClients.UseVisualStyleBackColor = true;
            // 
            // tpBuilder
            // 
            this.tpBuilder.Location = new System.Drawing.Point(4, 22);
            this.tpBuilder.Name = "tpBuilder";
            this.tpBuilder.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuilder.Size = new System.Drawing.Size(447, 321);
            this.tpBuilder.TabIndex = 1;
            this.tpBuilder.Text = "Builder";
            this.tpBuilder.UseVisualStyleBackColor = true;
            // 
            // gbConnected
            // 
            this.gbConnected.Controls.Add(this.lvClients);
            this.gbConnected.Location = new System.Drawing.Point(6, 6);
            this.gbConnected.Name = "gbConnected";
            this.gbConnected.Size = new System.Drawing.Size(561, 309);
            this.gbConnected.TabIndex = 0;
            this.gbConnected.TabStop = false;
            this.gbConnected.Text = "Connected [0]";
            // 
            // lvClients
            // 
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMachineName,
            this.chIPAddress});
            this.lvClients.FullRowSelect = true;
            this.lvClients.Location = new System.Drawing.Point(6, 21);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(549, 282);
            this.lvClients.TabIndex = 0;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            // 
            // chMachineName
            // 
            this.chMachineName.Text = "Machine Name";
            this.chMachineName.Width = 274;
            // 
            // chIPAddress
            // 
            this.chIPAddress.Text = "IP Address";
            this.chIPAddress.Width = 237;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 347);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.tcMain.ResumeLayout(false);
            this.tpClients.ResumeLayout(false);
            this.gbConnected.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpClients;
        private System.Windows.Forms.GroupBox gbConnected;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader chMachineName;
        private System.Windows.Forms.ColumnHeader chIPAddress;
        private System.Windows.Forms.TabPage tpBuilder;
    }
}