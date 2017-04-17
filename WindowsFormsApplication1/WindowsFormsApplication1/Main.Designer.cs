namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.AddAbil_Add = new System.Windows.Forms.Button();
			this.abil1 = new System.Windows.Forms.ComboBox();
			this.abil2 = new System.Windows.Forms.ComboBox();
			this.abil3 = new System.Windows.Forms.ComboBox();
			this.AddAbilBox = new System.Windows.Forms.GroupBox();
			this.AddAbil_Reset = new System.Windows.Forms.Button();
			this.AddedAbilBox = new System.Windows.Forms.GroupBox();
			this.AddedBox7 = new System.Windows.Forms.GroupBox();
			this.DeleteBtn7 = new System.Windows.Forms.Button();
			this.label7_3 = new System.Windows.Forms.Label();
			this.label7_2 = new System.Windows.Forms.Label();
			this.label7_1 = new System.Windows.Forms.Label();
			this.AddedBox6 = new System.Windows.Forms.GroupBox();
			this.DeleteBtn6 = new System.Windows.Forms.Button();
			this.label6_3 = new System.Windows.Forms.Label();
			this.label6_2 = new System.Windows.Forms.Label();
			this.label6_1 = new System.Windows.Forms.Label();
			this.AddedBox5 = new System.Windows.Forms.GroupBox();
			this.DeleteBtn5 = new System.Windows.Forms.Button();
			this.label5_3 = new System.Windows.Forms.Label();
			this.label5_2 = new System.Windows.Forms.Label();
			this.label5_1 = new System.Windows.Forms.Label();
			this.AddedBox4 = new System.Windows.Forms.GroupBox();
			this.DeleteBtn4 = new System.Windows.Forms.Button();
			this.label4_3 = new System.Windows.Forms.Label();
			this.label4_2 = new System.Windows.Forms.Label();
			this.label4_1 = new System.Windows.Forms.Label();
			this.AddedBox3 = new System.Windows.Forms.GroupBox();
			this.DeleteBtn3 = new System.Windows.Forms.Button();
			this.label3_3 = new System.Windows.Forms.Label();
			this.label3_2 = new System.Windows.Forms.Label();
			this.label3_1 = new System.Windows.Forms.Label();
			this.AddedBox2 = new System.Windows.Forms.GroupBox();
			this.DeleteBtn2 = new System.Windows.Forms.Button();
			this.label2_3 = new System.Windows.Forms.Label();
			this.label2_2 = new System.Windows.Forms.Label();
			this.label2_1 = new System.Windows.Forms.Label();
			this.AddedBox1 = new System.Windows.Forms.GroupBox();
			this.DeleteBtn1 = new System.Windows.Forms.Button();
			this.label1_3 = new System.Windows.Forms.Label();
			this.label1_2 = new System.Windows.Forms.Label();
			this.label1_1 = new System.Windows.Forms.Label();
			this.Tooptip_Add = new System.Windows.Forms.ToolTip(this.components);
			this.Tooltip_Added = new System.Windows.Forms.ToolTip(this.components);
			this.ToolTip_Result = new System.Windows.Forms.ToolTip(this.components);
			this.ResultAbilBox = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ResultFilterBox = new System.Windows.Forms.GroupBox();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.result_1 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddAbilBox.SuspendLayout();
			this.AddedAbilBox.SuspendLayout();
			this.AddedBox7.SuspendLayout();
			this.AddedBox6.SuspendLayout();
			this.AddedBox5.SuspendLayout();
			this.AddedBox4.SuspendLayout();
			this.AddedBox3.SuspendLayout();
			this.AddedBox2.SuspendLayout();
			this.AddedBox1.SuspendLayout();
			this.ResultAbilBox.SuspendLayout();
			this.ResultFilterBox.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AddAbil_Add
			// 
			this.AddAbil_Add.Location = new System.Drawing.Point(6, 93);
			this.AddAbil_Add.Name = "AddAbil_Add";
			this.AddAbil_Add.Size = new System.Drawing.Size(75, 23);
			this.AddAbil_Add.TabIndex = 0;
			this.AddAbil_Add.Text = "추가";
			this.AddAbil_Add.UseVisualStyleBackColor = true;
			this.AddAbil_Add.Click += new System.EventHandler(this.AddAbil_Add_Click);
			// 
			// abil1
			// 
			this.abil1.BackColor = System.Drawing.SystemColors.Window;
			this.abil1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.abil1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.abil1.FormattingEnabled = true;
			this.abil1.Location = new System.Drawing.Point(21, 15);
			this.abil1.Name = "abil1";
			this.abil1.Size = new System.Drawing.Size(121, 20);
			this.abil1.TabIndex = 1;
			this.abil1.SelectedIndexChanged += new System.EventHandler(this.abil1_SelectedIndexChanged);
			// 
			// abil2
			// 
			this.abil2.BackColor = System.Drawing.SystemColors.Window;
			this.abil2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.abil2.FormattingEnabled = true;
			this.abil2.Location = new System.Drawing.Point(21, 41);
			this.abil2.Name = "abil2";
			this.abil2.Size = new System.Drawing.Size(121, 20);
			this.abil2.TabIndex = 2;
			this.abil2.SelectedIndexChanged += new System.EventHandler(this.abil2_SelectedIndexChanged);
			// 
			// abil3
			// 
			this.abil3.BackColor = System.Drawing.SystemColors.Window;
			this.abil3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.abil3.FormattingEnabled = true;
			this.abil3.Location = new System.Drawing.Point(21, 67);
			this.abil3.Name = "abil3";
			this.abil3.Size = new System.Drawing.Size(121, 20);
			this.abil3.TabIndex = 3;
			this.abil3.SelectedIndexChanged += new System.EventHandler(this.abil3_SelectedIndexChanged);
			// 
			// AddAbilBox
			// 
			this.AddAbilBox.Controls.Add(this.AddAbil_Reset);
			this.AddAbilBox.Controls.Add(this.abil3);
			this.AddAbilBox.Controls.Add(this.abil2);
			this.AddAbilBox.Controls.Add(this.abil1);
			this.AddAbilBox.Controls.Add(this.AddAbil_Add);
			this.AddAbilBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AddAbilBox.Location = new System.Drawing.Point(12, 253);
			this.AddAbilBox.Name = "AddAbilBox";
			this.AddAbilBox.Size = new System.Drawing.Size(169, 126);
			this.AddAbilBox.TabIndex = 4;
			this.AddAbilBox.TabStop = false;
			this.AddAbilBox.Text = "추가할 특성";
			// 
			// AddAbil_Reset
			// 
			this.AddAbil_Reset.Location = new System.Drawing.Point(87, 93);
			this.AddAbil_Reset.Name = "AddAbil_Reset";
			this.AddAbil_Reset.Size = new System.Drawing.Size(75, 23);
			this.AddAbil_Reset.TabIndex = 4;
			this.AddAbil_Reset.Text = "초기화";
			this.AddAbil_Reset.UseVisualStyleBackColor = true;
			this.AddAbil_Reset.Click += new System.EventHandler(this.AddAblil_Reset_Click);
			// 
			// AddedAbilBox
			// 
			this.AddedAbilBox.BackColor = System.Drawing.SystemColors.Control;
			this.AddedAbilBox.Controls.Add(this.AddedBox7);
			this.AddedAbilBox.Controls.Add(this.AddedBox6);
			this.AddedAbilBox.Controls.Add(this.AddedBox5);
			this.AddedAbilBox.Controls.Add(this.AddedBox4);
			this.AddedAbilBox.Controls.Add(this.AddedBox3);
			this.AddedAbilBox.Controls.Add(this.AddedBox2);
			this.AddedAbilBox.Controls.Add(this.AddedBox1);
			this.AddedAbilBox.Location = new System.Drawing.Point(203, 14);
			this.AddedAbilBox.Name = "AddedAbilBox";
			this.AddedAbilBox.Size = new System.Drawing.Size(256, 590);
			this.AddedAbilBox.TabIndex = 5;
			this.AddedAbilBox.TabStop = false;
			this.AddedAbilBox.Text = "추가된 특성";
			// 
			// AddedBox7
			// 
			this.AddedBox7.Controls.Add(this.DeleteBtn7);
			this.AddedBox7.Controls.Add(this.label7_3);
			this.AddedBox7.Controls.Add(this.label7_2);
			this.AddedBox7.Controls.Add(this.label7_1);
			this.AddedBox7.Location = new System.Drawing.Point(6, 500);
			this.AddedBox7.Name = "AddedBox7";
			this.AddedBox7.Size = new System.Drawing.Size(244, 74);
			this.AddedBox7.TabIndex = 6;
			this.AddedBox7.TabStop = false;
			this.AddedBox7.Text = "아이템7";
			this.AddedBox7.Visible = false;
			// 
			// DeleteBtn7
			// 
			this.DeleteBtn7.Location = new System.Drawing.Point(192, 17);
			this.DeleteBtn7.Name = "DeleteBtn7";
			this.DeleteBtn7.Size = new System.Drawing.Size(46, 51);
			this.DeleteBtn7.TabIndex = 3;
			this.DeleteBtn7.Text = "삭제";
			this.DeleteBtn7.UseVisualStyleBackColor = true;
			this.DeleteBtn7.Click += new System.EventHandler(this.Added_DeleteButton_Click);
			// 
			// label7_3
			// 
			this.label7_3.AutoSize = true;
			this.label7_3.Location = new System.Drawing.Point(6, 59);
			this.label7_3.Name = "label7_3";
			this.label7_3.Size = new System.Drawing.Size(109, 12);
			this.label7_3.TabIndex = 2;
			this.label7_3.Text = "실수로 데미지 증가";
			// 
			// label7_2
			// 
			this.label7_2.AutoSize = true;
			this.label7_2.Location = new System.Drawing.Point(6, 38);
			this.label7_2.Name = "label7_2";
			this.label7_2.Size = new System.Drawing.Size(53, 12);
			this.label7_2.TabIndex = 1;
			this.label7_2.Text = "잠재력++";
			// 
			// label7_1
			// 
			this.label7_1.AutoSize = true;
			this.label7_1.Location = new System.Drawing.Point(6, 17);
			this.label7_1.Name = "label7_1";
			this.label7_1.Size = new System.Drawing.Size(47, 12);
			this.label7_1.TabIndex = 0;
			this.label7_1.Text = "잠재력+";
			// 
			// AddedBox6
			// 
			this.AddedBox6.Controls.Add(this.DeleteBtn6);
			this.AddedBox6.Controls.Add(this.label6_3);
			this.AddedBox6.Controls.Add(this.label6_2);
			this.AddedBox6.Controls.Add(this.label6_1);
			this.AddedBox6.Location = new System.Drawing.Point(6, 420);
			this.AddedBox6.Name = "AddedBox6";
			this.AddedBox6.Size = new System.Drawing.Size(244, 74);
			this.AddedBox6.TabIndex = 5;
			this.AddedBox6.TabStop = false;
			this.AddedBox6.Text = "아이템6";
			this.AddedBox6.Visible = false;
			// 
			// DeleteBtn6
			// 
			this.DeleteBtn6.Location = new System.Drawing.Point(192, 17);
			this.DeleteBtn6.Name = "DeleteBtn6";
			this.DeleteBtn6.Size = new System.Drawing.Size(46, 51);
			this.DeleteBtn6.TabIndex = 3;
			this.DeleteBtn6.Text = "삭제";
			this.DeleteBtn6.UseVisualStyleBackColor = true;
			this.DeleteBtn6.Click += new System.EventHandler(this.Added_DeleteButton_Click);
			// 
			// label6_3
			// 
			this.label6_3.AutoSize = true;
			this.label6_3.Location = new System.Drawing.Point(6, 59);
			this.label6_3.Name = "label6_3";
			this.label6_3.Size = new System.Drawing.Size(109, 12);
			this.label6_3.TabIndex = 2;
			this.label6_3.Text = "실수로 데미지 증가";
			// 
			// label6_2
			// 
			this.label6_2.AutoSize = true;
			this.label6_2.Location = new System.Drawing.Point(6, 38);
			this.label6_2.Name = "label6_2";
			this.label6_2.Size = new System.Drawing.Size(53, 12);
			this.label6_2.TabIndex = 1;
			this.label6_2.Text = "잠재력++";
			// 
			// label6_1
			// 
			this.label6_1.AutoSize = true;
			this.label6_1.Location = new System.Drawing.Point(6, 17);
			this.label6_1.Name = "label6_1";
			this.label6_1.Size = new System.Drawing.Size(47, 12);
			this.label6_1.TabIndex = 0;
			this.label6_1.Text = "잠재력+";
			// 
			// AddedBox5
			// 
			this.AddedBox5.Controls.Add(this.DeleteBtn5);
			this.AddedBox5.Controls.Add(this.label5_3);
			this.AddedBox5.Controls.Add(this.label5_2);
			this.AddedBox5.Controls.Add(this.label5_1);
			this.AddedBox5.Location = new System.Drawing.Point(6, 340);
			this.AddedBox5.Name = "AddedBox5";
			this.AddedBox5.Size = new System.Drawing.Size(244, 74);
			this.AddedBox5.TabIndex = 4;
			this.AddedBox5.TabStop = false;
			this.AddedBox5.Text = "아이템5";
			this.AddedBox5.Visible = false;
			// 
			// DeleteBtn5
			// 
			this.DeleteBtn5.Location = new System.Drawing.Point(192, 17);
			this.DeleteBtn5.Name = "DeleteBtn5";
			this.DeleteBtn5.Size = new System.Drawing.Size(46, 51);
			this.DeleteBtn5.TabIndex = 3;
			this.DeleteBtn5.Text = "삭제";
			this.DeleteBtn5.UseVisualStyleBackColor = true;
			this.DeleteBtn5.Click += new System.EventHandler(this.Added_DeleteButton_Click);
			// 
			// label5_3
			// 
			this.label5_3.AutoSize = true;
			this.label5_3.Location = new System.Drawing.Point(6, 59);
			this.label5_3.Name = "label5_3";
			this.label5_3.Size = new System.Drawing.Size(109, 12);
			this.label5_3.TabIndex = 2;
			this.label5_3.Text = "실수로 데미지 증가";
			// 
			// label5_2
			// 
			this.label5_2.AutoSize = true;
			this.label5_2.Location = new System.Drawing.Point(6, 38);
			this.label5_2.Name = "label5_2";
			this.label5_2.Size = new System.Drawing.Size(53, 12);
			this.label5_2.TabIndex = 1;
			this.label5_2.Text = "잠재력++";
			// 
			// label5_1
			// 
			this.label5_1.AutoSize = true;
			this.label5_1.Location = new System.Drawing.Point(6, 17);
			this.label5_1.Name = "label5_1";
			this.label5_1.Size = new System.Drawing.Size(47, 12);
			this.label5_1.TabIndex = 0;
			this.label5_1.Text = "잠재력+";
			// 
			// AddedBox4
			// 
			this.AddedBox4.Controls.Add(this.DeleteBtn4);
			this.AddedBox4.Controls.Add(this.label4_3);
			this.AddedBox4.Controls.Add(this.label4_2);
			this.AddedBox4.Controls.Add(this.label4_1);
			this.AddedBox4.Location = new System.Drawing.Point(6, 260);
			this.AddedBox4.Name = "AddedBox4";
			this.AddedBox4.Size = new System.Drawing.Size(244, 74);
			this.AddedBox4.TabIndex = 3;
			this.AddedBox4.TabStop = false;
			this.AddedBox4.Text = "아이템4";
			this.AddedBox4.Visible = false;
			// 
			// DeleteBtn4
			// 
			this.DeleteBtn4.Location = new System.Drawing.Point(192, 17);
			this.DeleteBtn4.Name = "DeleteBtn4";
			this.DeleteBtn4.Size = new System.Drawing.Size(46, 51);
			this.DeleteBtn4.TabIndex = 3;
			this.DeleteBtn4.Text = "삭제";
			this.DeleteBtn4.UseVisualStyleBackColor = true;
			this.DeleteBtn4.Click += new System.EventHandler(this.Added_DeleteButton_Click);
			// 
			// label4_3
			// 
			this.label4_3.AutoSize = true;
			this.label4_3.Location = new System.Drawing.Point(6, 59);
			this.label4_3.Name = "label4_3";
			this.label4_3.Size = new System.Drawing.Size(109, 12);
			this.label4_3.TabIndex = 2;
			this.label4_3.Text = "실수로 데미지 증가";
			// 
			// label4_2
			// 
			this.label4_2.AutoSize = true;
			this.label4_2.Location = new System.Drawing.Point(6, 38);
			this.label4_2.Name = "label4_2";
			this.label4_2.Size = new System.Drawing.Size(53, 12);
			this.label4_2.TabIndex = 1;
			this.label4_2.Text = "잠재력++";
			// 
			// label4_1
			// 
			this.label4_1.AutoSize = true;
			this.label4_1.Location = new System.Drawing.Point(6, 17);
			this.label4_1.Name = "label4_1";
			this.label4_1.Size = new System.Drawing.Size(47, 12);
			this.label4_1.TabIndex = 0;
			this.label4_1.Text = "잠재력+";
			// 
			// AddedBox3
			// 
			this.AddedBox3.Controls.Add(this.DeleteBtn3);
			this.AddedBox3.Controls.Add(this.label3_3);
			this.AddedBox3.Controls.Add(this.label3_2);
			this.AddedBox3.Controls.Add(this.label3_1);
			this.AddedBox3.Location = new System.Drawing.Point(6, 180);
			this.AddedBox3.Name = "AddedBox3";
			this.AddedBox3.Size = new System.Drawing.Size(244, 74);
			this.AddedBox3.TabIndex = 2;
			this.AddedBox3.TabStop = false;
			this.AddedBox3.Text = "아이템3";
			this.AddedBox3.Visible = false;
			this.AddedBox3.Enter += new System.EventHandler(this.AddedBox3_Enter);
			// 
			// DeleteBtn3
			// 
			this.DeleteBtn3.Location = new System.Drawing.Point(192, 17);
			this.DeleteBtn3.Name = "DeleteBtn3";
			this.DeleteBtn3.Size = new System.Drawing.Size(46, 51);
			this.DeleteBtn3.TabIndex = 3;
			this.DeleteBtn3.Text = "삭제";
			this.DeleteBtn3.UseVisualStyleBackColor = true;
			this.DeleteBtn3.Click += new System.EventHandler(this.Added_DeleteButton_Click);
			// 
			// label3_3
			// 
			this.label3_3.AutoSize = true;
			this.label3_3.Location = new System.Drawing.Point(6, 59);
			this.label3_3.Name = "label3_3";
			this.label3_3.Size = new System.Drawing.Size(109, 12);
			this.label3_3.TabIndex = 2;
			this.label3_3.Text = "실수로 데미지 증가";
			// 
			// label3_2
			// 
			this.label3_2.AutoSize = true;
			this.label3_2.Location = new System.Drawing.Point(6, 38);
			this.label3_2.Name = "label3_2";
			this.label3_2.Size = new System.Drawing.Size(53, 12);
			this.label3_2.TabIndex = 1;
			this.label3_2.Text = "잠재력++";
			// 
			// label3_1
			// 
			this.label3_1.AutoSize = true;
			this.label3_1.Location = new System.Drawing.Point(6, 17);
			this.label3_1.Name = "label3_1";
			this.label3_1.Size = new System.Drawing.Size(47, 12);
			this.label3_1.TabIndex = 0;
			this.label3_1.Text = "잠재력+";
			// 
			// AddedBox2
			// 
			this.AddedBox2.Controls.Add(this.DeleteBtn2);
			this.AddedBox2.Controls.Add(this.label2_3);
			this.AddedBox2.Controls.Add(this.label2_2);
			this.AddedBox2.Controls.Add(this.label2_1);
			this.AddedBox2.Location = new System.Drawing.Point(6, 100);
			this.AddedBox2.Name = "AddedBox2";
			this.AddedBox2.Size = new System.Drawing.Size(244, 74);
			this.AddedBox2.TabIndex = 1;
			this.AddedBox2.TabStop = false;
			this.AddedBox2.Text = "아이템2";
			this.AddedBox2.Visible = false;
			// 
			// DeleteBtn2
			// 
			this.DeleteBtn2.Location = new System.Drawing.Point(192, 17);
			this.DeleteBtn2.Name = "DeleteBtn2";
			this.DeleteBtn2.Size = new System.Drawing.Size(46, 51);
			this.DeleteBtn2.TabIndex = 3;
			this.DeleteBtn2.Text = "삭제";
			this.DeleteBtn2.UseVisualStyleBackColor = true;
			this.DeleteBtn2.Click += new System.EventHandler(this.Added_DeleteButton_Click);
			// 
			// label2_3
			// 
			this.label2_3.AutoSize = true;
			this.label2_3.Location = new System.Drawing.Point(6, 59);
			this.label2_3.Name = "label2_3";
			this.label2_3.Size = new System.Drawing.Size(109, 12);
			this.label2_3.TabIndex = 2;
			this.label2_3.Text = "실수로 데미지 증가";
			// 
			// label2_2
			// 
			this.label2_2.AutoSize = true;
			this.label2_2.Location = new System.Drawing.Point(6, 38);
			this.label2_2.Name = "label2_2";
			this.label2_2.Size = new System.Drawing.Size(53, 12);
			this.label2_2.TabIndex = 1;
			this.label2_2.Text = "잠재력++";
			// 
			// label2_1
			// 
			this.label2_1.AutoSize = true;
			this.label2_1.Location = new System.Drawing.Point(6, 17);
			this.label2_1.Name = "label2_1";
			this.label2_1.Size = new System.Drawing.Size(47, 12);
			this.label2_1.TabIndex = 0;
			this.label2_1.Text = "잠재력+";
			// 
			// AddedBox1
			// 
			this.AddedBox1.Controls.Add(this.DeleteBtn1);
			this.AddedBox1.Controls.Add(this.label1_3);
			this.AddedBox1.Controls.Add(this.label1_2);
			this.AddedBox1.Controls.Add(this.label1_1);
			this.AddedBox1.Location = new System.Drawing.Point(6, 20);
			this.AddedBox1.Name = "AddedBox1";
			this.AddedBox1.Size = new System.Drawing.Size(244, 74);
			this.AddedBox1.TabIndex = 0;
			this.AddedBox1.TabStop = false;
			this.AddedBox1.Text = "아이템1";
			this.AddedBox1.Visible = false;
			// 
			// DeleteBtn1
			// 
			this.DeleteBtn1.Location = new System.Drawing.Point(192, 17);
			this.DeleteBtn1.Name = "DeleteBtn1";
			this.DeleteBtn1.Size = new System.Drawing.Size(46, 51);
			this.DeleteBtn1.TabIndex = 3;
			this.DeleteBtn1.Text = "삭제";
			this.DeleteBtn1.UseVisualStyleBackColor = true;
			this.DeleteBtn1.Click += new System.EventHandler(this.Added_DeleteButton_Click);
			// 
			// label1_3
			// 
			this.label1_3.AutoSize = true;
			this.label1_3.Location = new System.Drawing.Point(6, 59);
			this.label1_3.Name = "label1_3";
			this.label1_3.Size = new System.Drawing.Size(109, 12);
			this.label1_3.TabIndex = 2;
			this.label1_3.Text = "실수로 데미지 증가";
			// 
			// label1_2
			// 
			this.label1_2.AutoSize = true;
			this.label1_2.Location = new System.Drawing.Point(6, 38);
			this.label1_2.Name = "label1_2";
			this.label1_2.Size = new System.Drawing.Size(53, 12);
			this.label1_2.TabIndex = 1;
			this.label1_2.Text = "잠재력++";
			// 
			// label1_1
			// 
			this.label1_1.AutoSize = true;
			this.label1_1.Location = new System.Drawing.Point(6, 17);
			this.label1_1.Name = "label1_1";
			this.label1_1.Size = new System.Drawing.Size(47, 12);
			this.label1_1.TabIndex = 0;
			this.label1_1.Text = "잠재력+";
			// 
			// ResultAbilBox
			// 
			this.ResultAbilBox.Controls.Add(this.button1);
			this.ResultAbilBox.Controls.Add(this.ResultFilterBox);
			this.ResultAbilBox.Controls.Add(this.result_1);
			this.ResultAbilBox.Location = new System.Drawing.Point(520, 14);
			this.ResultAbilBox.Name = "ResultAbilBox";
			this.ResultAbilBox.Size = new System.Drawing.Size(273, 590);
			this.ResultAbilBox.TabIndex = 6;
			this.ResultAbilBox.TabStop = false;
			this.ResultAbilBox.Text = "결과";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 556);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(261, 26);
			this.button1.TabIndex = 2;
			this.button1.Text = "초기화";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Result_AllResetButton_Click);
			// 
			// ResultFilterBox
			// 
			this.ResultFilterBox.Controls.Add(this.radioButton6);
			this.ResultFilterBox.Controls.Add(this.radioButton5);
			this.ResultFilterBox.Controls.Add(this.radioButton4);
			this.ResultFilterBox.Controls.Add(this.radioButton3);
			this.ResultFilterBox.Controls.Add(this.radioButton2);
			this.ResultFilterBox.Controls.Add(this.radioButton1);
			this.ResultFilterBox.Enabled = false;
			this.ResultFilterBox.Location = new System.Drawing.Point(6, 440);
			this.ResultFilterBox.Name = "ResultFilterBox";
			this.ResultFilterBox.Size = new System.Drawing.Size(261, 110);
			this.ResultFilterBox.TabIndex = 1;
			this.ResultFilterBox.TabStop = false;
			this.ResultFilterBox.Text = "필터";
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(186, 73);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(59, 16);
			this.radioButton6.TabIndex = 5;
			this.radioButton6.TabStop = true;
			this.radioButton6.Tag = "1";
			this.radioButton6.Text = "장신구";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.radioButton6.CheckedChanged += new System.EventHandler(this.Result_CheckedChanged);
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(100, 73);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(59, 16);
			this.radioButton5.TabIndex = 4;
			this.radioButton5.TabStop = true;
			this.radioButton5.Tag = "2";
			this.radioButton5.Text = "방어구";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton5.CheckedChanged += new System.EventHandler(this.Result_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(24, 73);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(47, 16);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Tag = "4";
			this.radioButton4.Text = "무기";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.Result_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(186, 32);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(47, 16);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Tag = "8";
			this.radioButton3.Text = "회복";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.Result_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(100, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 16);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Tag = "16";
			this.radioButton2.Text = "공격";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.Result_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(24, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 16);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Tag = "32";
			this.radioButton1.Text = "재료";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.Result_CheckedChanged);
			// 
			// result_1
			// 
			this.result_1.AutoSize = true;
			this.result_1.Location = new System.Drawing.Point(7, 20);
			this.result_1.Name = "result_1";
			this.result_1.Size = new System.Drawing.Size(29, 12);
			this.result_1.TabIndex = 0;
			this.result_1.Text = "결과";
			this.result_1.Visible = false;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(466, 274);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(48, 74);
			this.button8.TabIndex = 7;
			this.button8.Text = "합성";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(805, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 파일ToolStripMenuItem
			// 
			this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.로드ToolStripMenuItem,
            this.종료ToolStripMenuItem});
			this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
			this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.파일ToolStripMenuItem.Text = "파일";
			// 
			// 저장ToolStripMenuItem
			// 
			this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
			this.저장ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.저장ToolStripMenuItem.Text = "저장";
			this.저장ToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// 로드ToolStripMenuItem
			// 
			this.로드ToolStripMenuItem.Name = "로드ToolStripMenuItem";
			this.로드ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.로드ToolStripMenuItem.Text = "로드";
			this.로드ToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// 종료ToolStripMenuItem
			// 
			this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
			this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.종료ToolStripMenuItem.Text = "종료";
			this.종료ToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 619);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.ResultAbilBox);
			this.Controls.Add(this.AddedAbilBox);
			this.Controls.Add(this.AddAbilBox);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Text = "소피의 아틀리에 특성 계산기";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.AddAbilBox.ResumeLayout(false);
			this.AddedAbilBox.ResumeLayout(false);
			this.AddedBox7.ResumeLayout(false);
			this.AddedBox7.PerformLayout();
			this.AddedBox6.ResumeLayout(false);
			this.AddedBox6.PerformLayout();
			this.AddedBox5.ResumeLayout(false);
			this.AddedBox5.PerformLayout();
			this.AddedBox4.ResumeLayout(false);
			this.AddedBox4.PerformLayout();
			this.AddedBox3.ResumeLayout(false);
			this.AddedBox3.PerformLayout();
			this.AddedBox2.ResumeLayout(false);
			this.AddedBox2.PerformLayout();
			this.AddedBox1.ResumeLayout(false);
			this.AddedBox1.PerformLayout();
			this.ResultAbilBox.ResumeLayout(false);
			this.ResultAbilBox.PerformLayout();
			this.ResultFilterBox.ResumeLayout(false);
			this.ResultFilterBox.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAbil_Add;
        private System.Windows.Forms.ComboBox abil1;
        private System.Windows.Forms.ComboBox abil2;
        private System.Windows.Forms.ComboBox abil3;
        private System.Windows.Forms.GroupBox AddAbilBox;
        private System.Windows.Forms.Button AddAbil_Reset;
		private System.Windows.Forms.GroupBox AddedAbilBox;
		private System.Windows.Forms.ToolTip Tooptip_Add;
		private System.Windows.Forms.ToolTip Tooltip_Added;
		private System.Windows.Forms.ToolTip ToolTip_Result;
		private System.Windows.Forms.GroupBox ResultAbilBox;
		private System.Windows.Forms.GroupBox AddedBox1;
		private System.Windows.Forms.Label label1_3;
		private System.Windows.Forms.Label label1_2;
		private System.Windows.Forms.Label label1_1;
		private System.Windows.Forms.GroupBox AddedBox5;
		private System.Windows.Forms.Button DeleteBtn5;
		private System.Windows.Forms.Label label5_3;
		private System.Windows.Forms.Label label5_2;
		private System.Windows.Forms.Label label5_1;
		private System.Windows.Forms.GroupBox AddedBox4;
		private System.Windows.Forms.Button DeleteBtn4;
		private System.Windows.Forms.Label label4_3;
		private System.Windows.Forms.Label label4_2;
		private System.Windows.Forms.Label label4_1;
		private System.Windows.Forms.GroupBox AddedBox3;
		private System.Windows.Forms.Button DeleteBtn3;
		private System.Windows.Forms.Label label3_3;
		private System.Windows.Forms.Label label3_2;
		private System.Windows.Forms.Label label3_1;
		private System.Windows.Forms.GroupBox AddedBox2;
		private System.Windows.Forms.Button DeleteBtn2;
		private System.Windows.Forms.Label label2_3;
		private System.Windows.Forms.Label label2_2;
		private System.Windows.Forms.Label label2_1;
		private System.Windows.Forms.Button DeleteBtn1;
		private System.Windows.Forms.GroupBox AddedBox7;
		private System.Windows.Forms.Button DeleteBtn7;
		private System.Windows.Forms.Label label7_3;
		private System.Windows.Forms.Label label7_2;
		private System.Windows.Forms.Label label7_1;
		private System.Windows.Forms.GroupBox AddedBox6;
		private System.Windows.Forms.Button DeleteBtn6;
		private System.Windows.Forms.Label label6_3;
		private System.Windows.Forms.Label label6_2;
		private System.Windows.Forms.Label label6_1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label result_1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox ResultFilterBox;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 로드ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
	}
}

