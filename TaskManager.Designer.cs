namespace NanatusuTasks
{
    partial class TaskManager
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtTittleTask = new TextBox();
            button3 = new Button();
            btnComplete = new Button();
            btnAdd = new Button();
            gridTasks = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(532, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 450);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ba4c1e065230e235184d0d9ada7252a3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTittleTask);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnComplete);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(gridTasks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 450);
            panel2.TabIndex = 2;
            // 
            // txtTittleTask
            // 
            txtTittleTask.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTittleTask.Location = new Point(8, 45);
            txtTittleTask.Name = "txtTittleTask";
            txtTittleTask.PlaceholderText = "TITTLE FOR SERVICE...";
            txtTittleTask.Size = new Size(514, 35);
            txtTittleTask.TabIndex = 4;
            
            // 
            // button3
            // 
            button3.Location = new Point(9, 173);
            button3.Name = "button3";
            button3.Size = new Size(514, 27);
            button3.TabIndex = 3;
            button3.Text = "EXCLUDE SERVICE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(8, 136);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(514, 31);
            btnComplete.TabIndex = 2;
            btnComplete.Text = "COMPLETE SERVICE";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(514, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD SERVICE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // gridTasks
            // 
            gridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTasks.Location = new Point(9, 216);
            gridTasks.Name = "gridTasks";
            gridTasks.Size = new Size(514, 226);
            gridTasks.TabIndex = 0;
           
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TaskManager";
            Text = "TaskManager";
            Load += TaskManager_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView gridTasks;
        private Button button3;
        private Button btnComplete;
        private Button btnAdd;
        private TextBox txtTittleTask;
    }
}