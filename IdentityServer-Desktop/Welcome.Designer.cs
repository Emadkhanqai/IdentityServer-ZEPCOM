namespace IdentityServer_Desktop
{
    partial class Welcome
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
            productsDataGrid = new DataGridView();
            authenticateBtn = new Button();
            loader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // productsDataGrid
            // 
            productsDataGrid.AllowUserToAddRows = false;
            productsDataGrid.AllowUserToDeleteRows = false;
            productsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGrid.BackgroundColor = Color.White;
            productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGrid.Dock = DockStyle.Fill;
            productsDataGrid.Location = new Point(0, 0);
            productsDataGrid.Name = "productsDataGrid";
            productsDataGrid.ReadOnly = true;
            productsDataGrid.RowTemplate.Height = 25;
            productsDataGrid.Size = new Size(800, 450);
            productsDataGrid.TabIndex = 0;
            productsDataGrid.Visible = false;

            // 
            // authenticateBtn
            // 
            authenticateBtn.BackColor = SystemColors.WindowFrame;
            authenticateBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            authenticateBtn.ForeColor = SystemColors.ButtonHighlight;
            authenticateBtn.Location = new Point(208, 255);
            authenticateBtn.Name = "authenticateBtn";
            authenticateBtn.Size = new Size(362, 132);
            authenticateBtn.TabIndex = 1;
            authenticateBtn.Text = "Sign-In with Identity Server";
            authenticateBtn.UseVisualStyleBackColor = false;
            authenticateBtn.Click += authenticateBtn_Click;
            // 
            // loader
            // 
            loader.BackColor = Color.Transparent;
            loader.Image = Properties.Resources.loader;
            loader.InitialImage = Properties.Resources.loader;
            loader.Location = new Point(346, 112);
            loader.Name = "loader";
            loader.Size = new Size(100, 67);
            loader.SizeMode = PictureBoxSizeMode.Zoom;
            loader.TabIndex = 2;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(loader);
            Controls.Add(authenticateBtn);
            Controls.Add(productsDataGrid);
            Name = "Welcome";
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productsDataGrid;
        private Button authenticateBtn;
        private PictureBox loader;
    }
}