namespace PDF_Name_Filter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            P_Top = new Panel();
            P_topContent = new Panel();
            lbl_FileName = new Label();
            label2 = new Label();
            label1 = new Label();
            Txtbx_SDir = new TextBox();
            pictureBox1 = new PictureBox();
            P_spaceBtm = new Panel();
            P_spaceTop = new Panel();
            P_ctrl = new Panel();
            btn_Filter = new Button();
            RB_Copy = new RadioButton();
            RB_Cut = new RadioButton();
            P_left = new Panel();
            P_bottom = new Panel();
            P_Body = new Panel();
            DGV_FileName = new DataGridView();
            P_Top.SuspendLayout();
            P_topContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            P_ctrl.SuspendLayout();
            P_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_FileName).BeginInit();
            SuspendLayout();
            // 
            // P_Top
            // 
            P_Top.Controls.Add(P_topContent);
            P_Top.Controls.Add(P_spaceBtm);
            P_Top.Controls.Add(P_spaceTop);
            P_Top.Dock = DockStyle.Top;
            P_Top.Location = new Point(0, 0);
            P_Top.Name = "P_Top";
            P_Top.Size = new Size(878, 137);
            P_Top.TabIndex = 0;
            // 
            // P_topContent
            // 
            P_topContent.Controls.Add(lbl_FileName);
            P_topContent.Controls.Add(label2);
            P_topContent.Controls.Add(label1);
            P_topContent.Controls.Add(Txtbx_SDir);
            P_topContent.Controls.Add(pictureBox1);
            P_topContent.Dock = DockStyle.Fill;
            P_topContent.Location = new Point(0, 22);
            P_topContent.Name = "P_topContent";
            P_topContent.Size = new Size(878, 98);
            P_topContent.TabIndex = 3;
            // 
            // lbl_FileName
            // 
            lbl_FileName.AutoSize = true;
            lbl_FileName.Location = new Point(400, 46);
            lbl_FileName.Name = "lbl_FileName";
            lbl_FileName.Size = new Size(57, 15);
            lbl_FileName.TabIndex = 7;
            lbl_FileName.Text = "FileName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 9);
            label2.Name = "label2";
            label2.Size = new Size(227, 30);
            label2.TabIndex = 6;
            label2.Text = "PDF Name Filter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 46);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Source Directory";
            // 
            // Txtbx_SDir
            // 
            Txtbx_SDir.Location = new Point(166, 64);
            Txtbx_SDir.Name = "Txtbx_SDir";
            Txtbx_SDir.Size = new Size(633, 23);
            Txtbx_SDir.TabIndex = 4;
            Txtbx_SDir.TextChanged += Txtbx_SDir_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 98);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // P_spaceBtm
            // 
            P_spaceBtm.Dock = DockStyle.Bottom;
            P_spaceBtm.Location = new Point(0, 120);
            P_spaceBtm.Name = "P_spaceBtm";
            P_spaceBtm.Size = new Size(878, 17);
            P_spaceBtm.TabIndex = 2;
            // 
            // P_spaceTop
            // 
            P_spaceTop.Dock = DockStyle.Top;
            P_spaceTop.Location = new Point(0, 0);
            P_spaceTop.Name = "P_spaceTop";
            P_spaceTop.Size = new Size(878, 22);
            P_spaceTop.TabIndex = 1;
            // 
            // P_ctrl
            // 
            P_ctrl.Controls.Add(btn_Filter);
            P_ctrl.Controls.Add(RB_Copy);
            P_ctrl.Controls.Add(RB_Cut);
            P_ctrl.Dock = DockStyle.Right;
            P_ctrl.Location = new Point(727, 137);
            P_ctrl.Name = "P_ctrl";
            P_ctrl.Size = new Size(151, 294);
            P_ctrl.TabIndex = 1;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(6, 106);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(133, 56);
            btn_Filter.TabIndex = 2;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // RB_Copy
            // 
            RB_Copy.AutoSize = true;
            RB_Copy.Location = new Point(6, 57);
            RB_Copy.Name = "RB_Copy";
            RB_Copy.Size = new Size(75, 19);
            RB_Copy.TabIndex = 1;
            RB_Copy.TabStop = true;
            RB_Copy.Text = "Duplicate";
            RB_Copy.UseVisualStyleBackColor = true;
            // 
            // RB_Cut
            // 
            RB_Cut.AutoSize = true;
            RB_Cut.Location = new Point(6, 32);
            RB_Cut.Name = "RB_Cut";
            RB_Cut.Size = new Size(55, 19);
            RB_Cut.TabIndex = 0;
            RB_Cut.TabStop = true;
            RB_Cut.Text = "Move";
            RB_Cut.UseVisualStyleBackColor = true;
            // 
            // P_left
            // 
            P_left.Dock = DockStyle.Left;
            P_left.Location = new Point(0, 137);
            P_left.Name = "P_left";
            P_left.Size = new Size(32, 294);
            P_left.TabIndex = 2;
            // 
            // P_bottom
            // 
            P_bottom.Dock = DockStyle.Bottom;
            P_bottom.Location = new Point(32, 407);
            P_bottom.Name = "P_bottom";
            P_bottom.Size = new Size(695, 24);
            P_bottom.TabIndex = 3;
            // 
            // P_Body
            // 
            P_Body.Controls.Add(DGV_FileName);
            P_Body.Dock = DockStyle.Fill;
            P_Body.Location = new Point(32, 137);
            P_Body.Name = "P_Body";
            P_Body.Size = new Size(695, 270);
            P_Body.TabIndex = 4;
            // 
            // DGV_FileName
            // 
            DGV_FileName.BackgroundColor = SystemColors.ButtonFace;
            DGV_FileName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_FileName.Dock = DockStyle.Fill;
            DGV_FileName.GridColor = SystemColors.Info;
            DGV_FileName.Location = new Point(0, 0);
            DGV_FileName.MultiSelect = false;
            DGV_FileName.Name = "DGV_FileName";
            DGV_FileName.ReadOnly = true;
            DGV_FileName.RowHeadersVisible = false;
            DGV_FileName.Size = new Size(695, 270);
            DGV_FileName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 431);
            Controls.Add(P_Body);
            Controls.Add(P_bottom);
            Controls.Add(P_left);
            Controls.Add(P_ctrl);
            Controls.Add(P_Top);
            Name = "Form1";
            Text = "Form1";
            P_Top.ResumeLayout(false);
            P_topContent.ResumeLayout(false);
            P_topContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            P_ctrl.ResumeLayout(false);
            P_ctrl.PerformLayout();
            P_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_FileName).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel P_Top;
        private Panel P_topContent;
        private PictureBox pictureBox1;
        private Panel P_spaceBtm;
        private Panel P_spaceTop;
        private Label label2;
        private Label label1;
        private TextBox Txtbx_SDir;
        private Panel P_ctrl;
        private Button btn_Filter;
        private RadioButton RB_Copy;
        private RadioButton RB_Cut;
        private Panel P_left;
        private Panel P_bottom;
        private Panel P_Body;
        private DataGridView DGV_FileName;
        private Label lbl_FileName;
    }
}
