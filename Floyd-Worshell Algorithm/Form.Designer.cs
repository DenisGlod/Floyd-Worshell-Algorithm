namespace Floyd_Worshell_Algorithm
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.vertexName = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitter = new System.Windows.Forms.Splitter();
            this.dgvWeight = new System.Windows.Forms.DataGridView();
            this.dgvPath = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.rtbPath = new System.Windows.Forms.RichTextBox();
            this.rtbWeight = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decide = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTable1Action = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTable2Action = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearSolutionAction = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPath)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vertexName
            // 
            this.vertexName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vertexName.Location = new System.Drawing.Point(11, 29);
            this.vertexName.Name = "vertexName";
            this.vertexName.Size = new System.Drawing.Size(198, 20);
            this.vertexName.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.правкаToolStripMenuItem,
            this.About});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(417, 24);
            this.menu.TabIndex = 9;
            this.menu.Text = "menuStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "fw";
            this.openFileDialog.Filter = "Algorithm Floyd Warshall (*.fw)|*.fw";
            this.openFileDialog.Title = "Открыть";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "fw";
            this.saveFileDialog.Filter = "Algorithm Floyd Warshall (*.fw)|*.fw";
            this.saveFileDialog.Title = "Сохранить";
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.Window;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter.Location = new System.Drawing.Point(0, 236);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(417, 3);
            this.splitter.TabIndex = 10;
            this.splitter.TabStop = false;
            // 
            // dgvWeight
            // 
            this.dgvWeight.AllowUserToAddRows = false;
            this.dgvWeight.AllowUserToDeleteRows = false;
            this.dgvWeight.AllowUserToResizeRows = false;
            this.dgvWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWeight.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvWeight.Location = new System.Drawing.Point(0, 90);
            this.dgvWeight.Margin = new System.Windows.Forms.Padding(20);
            this.dgvWeight.Name = "dgvWeight";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeight.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWeight.Size = new System.Drawing.Size(210, 116);
            this.dgvWeight.TabIndex = 11;
            // 
            // dgvPath
            // 
            this.dgvPath.AllowUserToAddRows = false;
            this.dgvPath.AllowUserToDeleteRows = false;
            this.dgvPath.AllowUserToResizeRows = false;
            this.dgvPath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPath.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPath.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPath.Location = new System.Drawing.Point(210, 90);
            this.dgvPath.Margin = new System.Windows.Forms.Padding(20);
            this.dgvPath.Name = "dgvPath";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPath.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPath.Size = new System.Drawing.Size(207, 116);
            this.dgvPath.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Location = new System.Drawing.Point(210, 90);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 116);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.vertexName);
            this.panel1.Controls.Add(this.accept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 66);
            this.panel1.TabIndex = 14;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(355, 29);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(49, 20);
            this.start.TabIndex = 5;
            // 
            // end
            // 
            this.end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.end.Location = new System.Drawing.Point(298, 29);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(49, 20);
            this.end.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Controls.Add(this.rtbPath);
            this.panel2.Controls.Add(this.rtbWeight);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 209);
            this.panel2.TabIndex = 15;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(210, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 209);
            this.splitter3.TabIndex = 12;
            this.splitter3.TabStop = false;
            // 
            // rtbPath
            // 
            this.rtbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbPath.Location = new System.Drawing.Point(210, 0);
            this.rtbPath.Name = "rtbPath";
            this.rtbPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbPath.Size = new System.Drawing.Size(207, 209);
            this.rtbPath.TabIndex = 11;
            this.rtbPath.Text = "";
            // 
            // rtbWeight
            // 
            this.rtbWeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbWeight.Location = new System.Drawing.Point(3, 0);
            this.rtbWeight.Name = "rtbWeight";
            this.rtbWeight.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbWeight.Size = new System.Drawing.Size(207, 209);
            this.rtbWeight.TabIndex = 10;
            this.rtbWeight.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 209);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(0, 448);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(417, 21);
            this.tbResult.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название вершин:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Начало:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Конец:";
            // 
            // decide
            // 
            this.decide.BackColor = System.Drawing.Color.SlateGray;
            this.decide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.decide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decide.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.decide.Location = new System.Drawing.Point(0, 206);
            this.decide.Name = "decide";
            this.decide.Size = new System.Drawing.Size(417, 30);
            this.decide.TabIndex = 4;
            this.decide.Text = "Решить";
            this.decide.UseVisualStyleBackColor = false;
            this.decide.Click += new System.EventHandler(this.Decide_Click);
            // 
            // accept
            // 
            this.accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accept.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.ok;
            this.accept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accept.Location = new System.Drawing.Point(215, 25);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(77, 27);
            this.accept.TabIndex = 3;
            this.accept.Text = "Принять";
            this.accept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save,
            this.toolStripMenuItem1,
            this.Exit});
            this.File.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.file;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(64, 20);
            this.File.Text = "Файл";
            // 
            // Open
            // 
            this.Open.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.open;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(132, 22);
            this.Open.Text = "Открыть";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.save;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(132, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // Exit
            // 
            this.Exit.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.exit;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearAllAction,
            this.ClearTable1Action,
            this.ClearTable2Action,
            this.ClearSolutionAction});
            this.правкаToolStripMenuItem.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.new_message;
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // ClearAllAction
            // 
            this.ClearAllAction.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.eraser;
            this.ClearAllAction.Name = "ClearAllAction";
            this.ClearAllAction.Size = new System.Drawing.Size(183, 22);
            this.ClearAllAction.Text = "Очистить все";
            this.ClearAllAction.Click += new System.EventHandler(this.ClearAllAction_Click);
            // 
            // ClearTable1Action
            // 
            this.ClearTable1Action.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.eraser;
            this.ClearTable1Action.Name = "ClearTable1Action";
            this.ClearTable1Action.Size = new System.Drawing.Size(183, 22);
            this.ClearTable1Action.Text = "Очистить таблицу 1";
            this.ClearTable1Action.Click += new System.EventHandler(this.ClearTable1Action_Click);
            // 
            // ClearTable2Action
            // 
            this.ClearTable2Action.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.eraser;
            this.ClearTable2Action.Name = "ClearTable2Action";
            this.ClearTable2Action.Size = new System.Drawing.Size(183, 22);
            this.ClearTable2Action.Text = "Очистить таблицу 2";
            this.ClearTable2Action.Click += new System.EventHandler(this.ClearTable2Action_Click);
            // 
            // ClearSolutionAction
            // 
            this.ClearSolutionAction.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.eraser;
            this.ClearSolutionAction.Name = "ClearSolutionAction";
            this.ClearSolutionAction.Size = new System.Drawing.Size(183, 22);
            this.ClearSolutionAction.Text = "Очистить решение";
            this.ClearSolutionAction.Click += new System.EventHandler(this.ClearSolutionAction_Click);
            // 
            // About
            // 
            this.About.Image = global::Floyd_Worshell_Algorithm.Properties.Resources.about;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(110, 20);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 469);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvPath);
            this.Controls.Add(this.dgvWeight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.decide);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(354, 508);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Флойда-Уоршелла";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPath)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button decide;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.TextBox vertexName;
        private System.Windows.Forms.DataGridView dgvWeight;
        private System.Windows.Forms.DataGridView dgvPath;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearAllAction;
        private System.Windows.Forms.ToolStripMenuItem ClearTable1Action;
        private System.Windows.Forms.ToolStripMenuItem ClearTable2Action;
        private System.Windows.Forms.ToolStripMenuItem ClearSolutionAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.RichTextBox rtbPath;
        private System.Windows.Forms.RichTextBox rtbWeight;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

