namespace BD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnselectAlunos = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.btnListarGrades = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAlunosTurma = new System.Windows.Forms.Button();
            this.bntListarTurmas = new System.Windows.Forms.Button();
            this.btnDisciplina = new System.Windows.Forms.Button();
            this.btnListarCursos = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.crudDelete = new System.Windows.Forms.Button();
            this.crudUpdate = new System.Windows.Forms.Button();
            this.crudInsert = new System.Windows.Forms.Button();
            this.comboTabelas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbConsultasSalvas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.dgvConsultaLivre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(6, 22);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.ShowCellErrors = false;
            this.dgvCursos.ShowEditingIcon = false;
            this.dgvCursos.ShowRowErrors = false;
            this.dgvCursos.Size = new System.Drawing.Size(238, 108);
            this.dgvCursos.TabIndex = 0;
            // 
            // btnselectAlunos
            // 
            this.btnselectAlunos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnselectAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectAlunos.Location = new System.Drawing.Point(338, 22);
            this.btnselectAlunos.Name = "btnselectAlunos";
            this.btnselectAlunos.Size = new System.Drawing.Size(88, 51);
            this.btnselectAlunos.TabIndex = 1;
            this.btnselectAlunos.Text = "Listar todos os alunos";
            this.btnselectAlunos.UseVisualStyleBackColor = false;
            this.btnselectAlunos.Click += new System.EventHandler(this.btnselectAlunos_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 531);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 505);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "SGATI";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvHistorico);
            this.tabPage1.Controls.Add(this.dgvAlunos);
            this.tabPage1.Controls.Add(this.dgvTurmas);
            this.tabPage1.Controls.Add(this.dgvDisciplinas);
            this.tabPage1.Controls.Add(this.dgvGrades);
            this.tabPage1.Controls.Add(this.btnListarGrades);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.btnAlunosTurma);
            this.tabPage1.Controls.Add(this.bntListarTurmas);
            this.tabPage1.Controls.Add(this.btnDisciplina);
            this.tabPage1.Controls.Add(this.btnListarCursos);
            this.tabPage1.Controls.Add(this.dgvCursos);
            this.tabPage1.Controls.Add(this.btnselectAlunos);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Histórico de um aluno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(677, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Alunos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Turmas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Disciplinas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Grades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cursos:";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToResizeRows = false;
            this.dgvHistorico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(360, 268);
            this.dgvHistorico.MultiSelect = false;
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.ShowCellErrors = false;
            this.dgvHistorico.ShowEditingIcon = false;
            this.dgvHistorico.ShowRowErrors = false;
            this.dgvHistorico.Size = new System.Drawing.Size(314, 228);
            this.dgvHistorico.TabIndex = 12;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(680, 171);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.ShowCellErrors = false;
            this.dgvAlunos.ShowEditingIcon = false;
            this.dgvAlunos.ShowRowErrors = false;
            this.dgvAlunos.Size = new System.Drawing.Size(309, 325);
            this.dgvAlunos.TabIndex = 11;
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToResizeRows = false;
            this.dgvTurmas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Location = new System.Drawing.Point(514, 22);
            this.dgvTurmas.MultiSelect = false;
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurmas.ShowCellErrors = false;
            this.dgvTurmas.ShowEditingIcon = false;
            this.dgvTurmas.ShowRowErrors = false;
            this.dgvTurmas.Size = new System.Drawing.Size(467, 108);
            this.dgvTurmas.TabIndex = 10;
            // 
            // dgvDisciplinas
            // 
            this.dgvDisciplinas.AllowUserToResizeRows = false;
            this.dgvDisciplinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Location = new System.Drawing.Point(6, 268);
            this.dgvDisciplinas.MultiSelect = false;
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisciplinas.ShowCellErrors = false;
            this.dgvDisciplinas.ShowEditingIcon = false;
            this.dgvDisciplinas.ShowRowErrors = false;
            this.dgvDisciplinas.Size = new System.Drawing.Size(339, 228);
            this.dgvDisciplinas.TabIndex = 9;
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToResizeRows = false;
            this.dgvGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(6, 161);
            this.dgvGrades.MultiSelect = false;
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.ShowCellErrors = false;
            this.dgvGrades.ShowEditingIcon = false;
            this.dgvGrades.ShowRowErrors = false;
            this.dgvGrades.Size = new System.Drawing.Size(238, 83);
            this.dgvGrades.TabIndex = 8;
            // 
            // btnListarGrades
            // 
            this.btnListarGrades.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListarGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarGrades.Location = new System.Drawing.Point(250, 79);
            this.btnListarGrades.Name = "btnListarGrades";
            this.btnListarGrades.Size = new System.Drawing.Size(176, 51);
            this.btnListarGrades.TabIndex = 7;
            this.btnListarGrades.Text = "Listar grades do curso selecionado";
            this.btnListarGrades.UseVisualStyleBackColor = false;
            this.btnListarGrades.Click += new System.EventHandler(this.btnListarGrades_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(432, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "Listar histórico do aluno selecionado";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAlunosTurma
            // 
            this.btnAlunosTurma.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAlunosTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunosTurma.Location = new System.Drawing.Point(432, 136);
            this.btnAlunosTurma.Name = "btnAlunosTurma";
            this.btnAlunosTurma.Size = new System.Drawing.Size(209, 51);
            this.btnAlunosTurma.TabIndex = 5;
            this.btnAlunosTurma.Text = "Listar alunos da turma selecionada";
            this.btnAlunosTurma.UseVisualStyleBackColor = false;
            this.btnAlunosTurma.Click += new System.EventHandler(this.btnAlunosTurma_Click);
            // 
            // bntListarTurmas
            // 
            this.bntListarTurmas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bntListarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntListarTurmas.Location = new System.Drawing.Point(250, 193);
            this.bntListarTurmas.Name = "bntListarTurmas";
            this.bntListarTurmas.Size = new System.Drawing.Size(176, 51);
            this.bntListarTurmas.TabIndex = 4;
            this.bntListarTurmas.Text = "Listar turmas da disciplina selecionada";
            this.bntListarTurmas.UseVisualStyleBackColor = false;
            this.bntListarTurmas.Click += new System.EventHandler(this.bntListarTurmas_Click);
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisciplina.Location = new System.Drawing.Point(250, 136);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(176, 51);
            this.btnDisciplina.TabIndex = 3;
            this.btnDisciplina.Text = "Listar disciplinas da grade selecionada";
            this.btnDisciplina.UseVisualStyleBackColor = false;
            this.btnDisciplina.Click += new System.EventHandler(this.btnDisciplina_Click);
            // 
            // btnListarCursos
            // 
            this.btnListarCursos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCursos.Location = new System.Drawing.Point(250, 22);
            this.btnListarCursos.Name = "btnListarCursos";
            this.btnListarCursos.Size = new System.Drawing.Size(82, 51);
            this.btnListarCursos.TabIndex = 2;
            this.btnListarCursos.Text = "Listar cursos";
            this.btnListarCursos.UseVisualStyleBackColor = false;
            this.btnListarCursos.Click += new System.EventHandler(this.btnListarCursos_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cbConsultasSalvas);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnCancelarConsulta);
            this.tabPage3.Controls.Add(this.btnConsultar);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxConsulta);
            this.tabPage3.Controls.Add(this.dgvConsultaLivre);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta Livre ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.crudDelete);
            this.groupBox1.Controls.Add(this.crudUpdate);
            this.groupBox1.Controls.Add(this.crudInsert);
            this.groupBox1.Controls.Add(this.comboTabelas);
            this.groupBox1.Location = new System.Drawing.Point(581, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Delete";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(166, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Update";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Insert";
            // 
            // crudDelete
            // 
            this.crudDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crudDelete.BackgroundImage")));
            this.crudDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.crudDelete.Location = new System.Drawing.Point(303, 70);
            this.crudDelete.Name = "crudDelete";
            this.crudDelete.Size = new System.Drawing.Size(75, 64);
            this.crudDelete.TabIndex = 11;
            this.crudDelete.UseVisualStyleBackColor = true;
            this.crudDelete.Click += new System.EventHandler(this.crudDelete_Click);
            // 
            // crudUpdate
            // 
            this.crudUpdate.BackColor = System.Drawing.Color.White;
            this.crudUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crudUpdate.BackgroundImage")));
            this.crudUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.crudUpdate.Location = new System.Drawing.Point(159, 70);
            this.crudUpdate.Name = "crudUpdate";
            this.crudUpdate.Size = new System.Drawing.Size(75, 64);
            this.crudUpdate.TabIndex = 10;
            this.crudUpdate.UseVisualStyleBackColor = false;
            this.crudUpdate.Click += new System.EventHandler(this.crudUpdate_Click);
            // 
            // crudInsert
            // 
            this.crudInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crudInsert.BackgroundImage")));
            this.crudInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.crudInsert.Location = new System.Drawing.Point(29, 70);
            this.crudInsert.Name = "crudInsert";
            this.crudInsert.Size = new System.Drawing.Size(75, 64);
            this.crudInsert.TabIndex = 9;
            this.crudInsert.UseVisualStyleBackColor = true;
            this.crudInsert.Click += new System.EventHandler(this.crudInsert_Click);
            // 
            // comboTabelas
            // 
            this.comboTabelas.FormattingEnabled = true;
            this.comboTabelas.Items.AddRange(new object[] {
            "Alunos",
            "Professores",
            "Disciplinas",
            "Cursos"});
            this.comboTabelas.Location = new System.Drawing.Point(120, 19);
            this.comboTabelas.Name = "comboTabelas";
            this.comboTabelas.Size = new System.Drawing.Size(161, 23);
            this.comboTabelas.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Consultas salvas:";
            // 
            // cbConsultasSalvas
            // 
            this.cbConsultasSalvas.FormattingEnabled = true;
            this.cbConsultasSalvas.Items.AddRange(new object[] {
            "Consulta 1",
            "Consulta 2",
            "Consulta 3",
            "Consulta 4",
            "Consulta 5",
            "Consulta 6",
            "Consulta 7",
            "Consulta 8",
            "Consulta 9",
            "Consulta 10",
            "Consulta 11"});
            this.cbConsultasSalvas.Location = new System.Drawing.Point(486, 196);
            this.cbConsultasSalvas.Name = "cbConsultasSalvas";
            this.cbConsultasSalvas.Size = new System.Drawing.Size(404, 23);
            this.cbConsultasSalvas.TabIndex = 6;
            this.cbConsultasSalvas.SelectedIndexChanged += new System.EventHandler(this.cbConsultasSalvas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarConsulta.BackgroundImage")));
            this.btnCancelarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarConsulta.Location = new System.Drawing.Point(486, 108);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(76, 65);
            this.btnCancelarConsulta.TabIndex = 4;
            this.btnCancelarConsulta.UseVisualStyleBackColor = true;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.btnCancelarConsulta_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultar.Location = new System.Drawing.Point(486, 38);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 64);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite uma consulta:";
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsulta.Location = new System.Drawing.Point(3, 38);
            this.textBoxConsulta.Multiline = true;
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(477, 179);
            this.textBoxConsulta.TabIndex = 1;
            // 
            // dgvConsultaLivre
            // 
            this.dgvConsultaLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLivre.Location = new System.Drawing.Point(3, 248);
            this.dgvConsultaLivre.Name = "dgvConsultaLivre";
            this.dgvConsultaLivre.Size = new System.Drawing.Size(983, 254);
            this.dgvConsultaLivre.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SGATI - Banco de Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLivre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnselectAlunos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnListarGrades;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAlunosTurma;
        private System.Windows.Forms.Button bntListarTurmas;
        private System.Windows.Forms.Button btnDisciplina;
        private System.Windows.Forms.Button btnListarCursos;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCancelarConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.DataGridView dgvConsultaLivre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbConsultasSalvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button crudDelete;
        private System.Windows.Forms.Button crudUpdate;
        private System.Windows.Forms.Button crudInsert;
        private System.Windows.Forms.ComboBox comboTabelas;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

