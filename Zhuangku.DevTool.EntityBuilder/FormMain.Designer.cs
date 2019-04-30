namespace Zhuangku.DevTool.EntityBuilder
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ListOld = new System.Windows.Forms.CheckedListBox();
            this.ListNew = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAppendBatch = new System.Windows.Forms.Button();
            this.buttonRemoveBatch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFieldName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBoxAllowNull = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAccessTpye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClassAcessType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxIsPartial = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameSpace = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxUsing = new System.Windows.Forms.RichTextBox();
            this.checkBoxIsSerial = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBoxClassComment = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载文件ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 加载文件ToolStripMenuItem
            // 
            this.加载文件ToolStripMenuItem.Name = "加载文件ToolStripMenuItem";
            this.加载文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.加载文件ToolStripMenuItem.Text = "加载文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 736);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ListOld, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListNew, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 453);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 220);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ListOld
            // 
            this.ListOld.AllowDrop = true;
            this.ListOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOld.FormattingEnabled = true;
            this.ListOld.Items.AddRange(new object[] {
            "添加"});
            this.ListOld.Location = new System.Drawing.Point(3, 3);
            this.ListOld.Name = "ListOld";
            this.ListOld.Size = new System.Drawing.Size(333, 214);
            this.ListOld.TabIndex = 0;
            this.ListOld.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListOld_DragDrop);
            this.ListOld.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListOld_DragEnter);
            // 
            // ListNew
            // 
            this.ListNew.AllowDrop = true;
            this.ListNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListNew.FormattingEnabled = true;
            this.ListNew.Items.AddRange(new object[] {
            "添加"});
            this.ListNew.Location = new System.Drawing.Point(442, 3);
            this.ListNew.Name = "ListNew";
            this.ListNew.Size = new System.Drawing.Size(333, 214);
            this.ListNew.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAppendBatch);
            this.panel2.Controls.Add(this.buttonRemoveBatch);
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Controls.Add(this.buttonAppend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(342, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 214);
            this.panel2.TabIndex = 2;
            // 
            // buttonAppendBatch
            // 
            this.buttonAppendBatch.Location = new System.Drawing.Point(10, 106);
            this.buttonAppendBatch.Name = "buttonAppendBatch";
            this.buttonAppendBatch.Size = new System.Drawing.Size(75, 23);
            this.buttonAppendBatch.TabIndex = 3;
            this.buttonAppendBatch.Text = "》》";
            this.buttonAppendBatch.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveBatch
            // 
            this.buttonRemoveBatch.Location = new System.Drawing.Point(10, 139);
            this.buttonRemoveBatch.Name = "buttonRemoveBatch";
            this.buttonRemoveBatch.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveBatch.TabIndex = 2;
            this.buttonRemoveBatch.Text = "《《";
            this.buttonRemoveBatch.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(10, 73);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "《";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonAppend
            // 
            this.buttonAppend.Location = new System.Drawing.Point(10, 40);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(75, 23);
            this.buttonAppend.TabIndex = 0;
            this.buttonAppend.Text = "》";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBoxFieldName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.richTextBoxComment);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CheckBoxAllowNull);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxDataType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxAccessTpye);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 444);
            this.panel1.TabIndex = 1;
            // 
            // textBoxFieldName
            // 
            this.textBoxFieldName.Location = new System.Drawing.Point(81, 413);
            this.textBoxFieldName.Name = "textBoxFieldName";
            this.textBoxFieldName.Size = new System.Drawing.Size(200, 21);
            this.textBoxFieldName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "成员名称：";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(694, 338);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 25);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(297, 374);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(472, 62);
            this.richTextBoxComment.TabIndex = 7;
            this.richTextBoxComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "备注信息：";
            // 
            // CheckBoxAllowNull
            // 
            this.CheckBoxAllowNull.AutoSize = true;
            this.CheckBoxAllowNull.Location = new System.Drawing.Point(233, 376);
            this.CheckBoxAllowNull.Name = "CheckBoxAllowNull";
            this.CheckBoxAllowNull.Size = new System.Drawing.Size(48, 16);
            this.CheckBoxAllowNull.TabIndex = 5;
            this.CheckBoxAllowNull.Text = "允许";
            this.CheckBoxAllowNull.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "可为空值：";
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Items.AddRange(new object[] {
            "string",
            "bool",
            "int",
            "float",
            "decimal",
            "DateTime",
            "short",
            "byte"});
            this.comboBoxDataType.Location = new System.Drawing.Point(81, 374);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(83, 20);
            this.comboBoxDataType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据类型：";
            // 
            // comboBoxAccessTpye
            // 
            this.comboBoxAccessTpye.FormattingEnabled = true;
            this.comboBoxAccessTpye.Items.AddRange(new object[] {
            "public",
            "private",
            "protect"});
            this.comboBoxAccessTpye.Location = new System.Drawing.Point(81, 338);
            this.comboBoxAccessTpye.Name = "comboBoxAccessTpye";
            this.comboBoxAccessTpye.Size = new System.Drawing.Size(200, 20);
            this.comboBoxAccessTpye.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "可访问性：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 679);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxClassComment);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.checkBoxIsSerial);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.richTextBoxUsing);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxNameSpace);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkBoxIsPartial);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxClassAcessType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxClassName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 302);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出实体类信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "类型名称：";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(86, 25);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(183, 21);
            this.textBoxClassName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "可访问性：";
            // 
            // comboBoxClassAcessType
            // 
            this.comboBoxClassAcessType.FormattingEnabled = true;
            this.comboBoxClassAcessType.Items.AddRange(new object[] {
            "public",
            "private",
            "protect"});
            this.comboBoxClassAcessType.Location = new System.Drawing.Point(86, 60);
            this.comboBoxClassAcessType.Name = "comboBoxClassAcessType";
            this.comboBoxClassAcessType.Size = new System.Drawing.Size(92, 20);
            this.comboBoxClassAcessType.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "部分类：";
            // 
            // checkBoxIsPartial
            // 
            this.checkBoxIsPartial.AutoSize = true;
            this.checkBoxIsPartial.Location = new System.Drawing.Point(233, 62);
            this.checkBoxIsPartial.Name = "checkBoxIsPartial";
            this.checkBoxIsPartial.Size = new System.Drawing.Size(36, 16);
            this.checkBoxIsPartial.TabIndex = 15;
            this.checkBoxIsPartial.Text = "是";
            this.checkBoxIsPartial.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "命名空间：";
            // 
            // textBoxNameSpace
            // 
            this.textBoxNameSpace.Location = new System.Drawing.Point(86, 95);
            this.textBoxNameSpace.Name = "textBoxNameSpace";
            this.textBoxNameSpace.Size = new System.Drawing.Size(183, 21);
            this.textBoxNameSpace.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "引用：";
            // 
            // richTextBoxUsing
            // 
            this.richTextBoxUsing.Location = new System.Drawing.Point(6, 189);
            this.richTextBoxUsing.Name = "richTextBoxUsing";
            this.richTextBoxUsing.Size = new System.Drawing.Size(745, 95);
            this.richTextBoxUsing.TabIndex = 19;
            this.richTextBoxUsing.Text = "";
            // 
            // checkBoxIsSerial
            // 
            this.checkBoxIsSerial.AutoSize = true;
            this.checkBoxIsSerial.Location = new System.Drawing.Point(86, 132);
            this.checkBoxIsSerial.Name = "checkBoxIsSerial";
            this.checkBoxIsSerial.Size = new System.Drawing.Size(36, 16);
            this.checkBoxIsSerial.TabIndex = 21;
            this.checkBoxIsSerial.Text = "是";
            this.checkBoxIsSerial.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "序列化：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "类型备注：";
            // 
            // richTextBoxClassComment
            // 
            this.richTextBoxClassComment.Location = new System.Drawing.Point(288, 51);
            this.richTextBoxClassComment.Name = "richTextBoxClassComment";
            this.richTextBoxClassComment.Size = new System.Drawing.Size(463, 122);
            this.richTextBoxClassComment.TabIndex = 23;
            this.richTextBoxClassComment.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体类生成工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox ListNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxAccessTpye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBoxAllowNull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFieldName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox ListOld;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonAppendBatch;
        private System.Windows.Forms.Button buttonRemoveBatch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameSpace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxIsPartial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxClassAcessType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxClassComment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxIsSerial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBoxUsing;
    }
}

