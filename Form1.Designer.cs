namespace finaldemopitottube
{
    partial class FINALDEMOPITOTTUBE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FINALDEMOPITOTTUBE));
            this.title_label = new System.Windows.Forms.Label();
            this.client_label = new System.Windows.Forms.Label();
            this.pono_label = new System.Windows.Forms.Label();
            this.wono_label = new System.Windows.Forms.Label();
            this.rof_label = new System.Windows.Forms.Label();
            this.rof_comboBox = new System.Windows.Forms.ComboBox();
            this.ac_label = new System.Windows.Forms.Label();
            this.Re_label = new System.Windows.Forms.Label();
            this.velocity_label = new System.Windows.Forms.Label();
            this.client_textBox = new System.Windows.Forms.TextBox();
            this.pono_textBox = new System.Windows.Forms.TextBox();
            this.wono_textBox = new System.Windows.Forms.TextBox();
            this.rof_textBox = new System.Windows.Forms.TextBox();
            this.ac_textBox = new System.Windows.Forms.TextBox();
            this.Re_textBox = new System.Windows.Forms.TextBox();
            this.velocity_textBox = new System.Windows.Forms.TextBox();
            this.probewidth_textBox = new System.Windows.Forms.TextBox();
            this.probewidth_label = new System.Windows.Forms.Label();
            this.temp_textBox = new System.Windows.Forms.TextBox();
            this.temp_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.printpreview_button = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.calculate_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.finalprintDocument = new System.Drawing.Printing.PrintDocument();
            this.finalprintDialog = new System.Windows.Forms.PrintDialog();
            this.finalprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.DashLine = new System.Windows.Forms.Label();
            this.input_label = new System.Windows.Forms.Label();
            this.staticpressure_label = new System.Windows.Forms.Label();
            this.staticpressure_textBox = new System.Windows.Forms.TextBox();
            this.fluiddensity_label = new System.Windows.Forms.Label();
            this.fluiddensity_textBox = new System.Windows.Forms.TextBox();
            this.flow_textBox = new System.Windows.Forms.TextBox();
            this.pipeid_textBox = new System.Windows.Forms.TextBox();
            this.flow_label = new System.Windows.Forms.Label();
            this.viscocity_label = new System.Windows.Forms.Label();
            this.viscosity_textBox = new System.Windows.Forms.TextBox();
            this.pipeid_label = new System.Windows.Forms.Label();
            this.input_panel = new System.Windows.Forms.Panel();
            this.output_panel = new System.Windows.Forms.Panel();
            this.dp_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.podate_textBox = new System.Windows.Forms.TextBox();
            this.podate_label = new System.Windows.Forms.Label();
            this.tagno_textBox = new System.Windows.Forms.TextBox();
            this.tag_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.input_panel.SuspendLayout();
            this.output_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_label.Location = new System.Drawing.Point(327, 12);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(341, 29);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "PITOT TUBE DP CALCULATOR";
            this.title_label.Click += new System.EventHandler(this.title_label_Click);
            // 
            // client_label
            // 
            this.client_label.AutoSize = true;
            this.client_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_label.Location = new System.Drawing.Point(5, 58);
            this.client_label.Name = "client_label";
            this.client_label.Size = new System.Drawing.Size(62, 18);
            this.client_label.TabIndex = 2;
            this.client_label.Text = "CLIENT:";
            // 
            // pono_label
            // 
            this.pono_label.AutoSize = true;
            this.pono_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pono_label.Location = new System.Drawing.Point(5, 84);
            this.pono_label.Name = "pono_label";
            this.pono_label.Size = new System.Drawing.Size(64, 18);
            this.pono_label.TabIndex = 3;
            this.pono_label.Text = "P.O. NO.:";
            // 
            // wono_label
            // 
            this.wono_label.AutoSize = true;
            this.wono_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wono_label.Location = new System.Drawing.Point(5, 111);
            this.wono_label.Name = "wono_label";
            this.wono_label.Size = new System.Drawing.Size(69, 18);
            this.wono_label.TabIndex = 4;
            this.wono_label.Text = "W.O. NO.:";
            // 
            // rof_label
            // 
            this.rof_label.AutoSize = true;
            this.rof_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rof_label.Location = new System.Drawing.Point(8, 10);
            this.rof_label.Name = "rof_label";
            this.rof_label.Size = new System.Drawing.Size(204, 18);
            this.rof_label.TabIndex = 5;
            this.rof_label.Text = "MEASUREMENT CONDITION:";
            // 
            // rof_comboBox
            // 
            this.rof_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.rof_comboBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rof_comboBox.FormattingEnabled = true;
            this.rof_comboBox.Items.AddRange(new object[] {
            "FOR LIQUID - VOLUME RATE OF FLOW",
            "FOR LIQUID - MASS RATE OF FLOW",
            "FOR GAS AND STEAM - MASS RATE OF FLOW",
            "FOR GAS AND STEAM - VOLUME RATE OF FLOW (STANDARD CONDITIONS)",
            "FOR GAS AND STEAM - VOLUME RATE OF FLOW (ACTUAL CONDITIONS)"});
            this.rof_comboBox.Location = new System.Drawing.Point(218, 10);
            this.rof_comboBox.MaxDropDownItems = 5;
            this.rof_comboBox.Name = "rof_comboBox";
            this.rof_comboBox.Size = new System.Drawing.Size(442, 22);
            this.rof_comboBox.TabIndex = 6;
            this.rof_comboBox.SelectedIndexChanged += new System.EventHandler(this.rof_comboBox_SelectedIndexChanged);
            // 
            // ac_label
            // 
            this.ac_label.AutoSize = true;
            this.ac_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_label.Location = new System.Drawing.Point(7, 43);
            this.ac_label.Name = "ac_label";
            this.ac_label.Size = new System.Drawing.Size(178, 18);
            this.ac_label.TabIndex = 7;
            this.ac_label.Text = "ANNUBAR COEFFICIENT:";
            // 
            // Re_label
            // 
            this.Re_label.AutoSize = true;
            this.Re_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re_label.Location = new System.Drawing.Point(369, 11);
            this.Re_label.Name = "Re_label";
            this.Re_label.Size = new System.Drawing.Size(151, 18);
            this.Re_label.TabIndex = 8;
            this.Re_label.Text = "PIPE REYNOLDS NO.:";
            // 
            // velocity_label
            // 
            this.velocity_label.AutoSize = true;
            this.velocity_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocity_label.Location = new System.Drawing.Point(369, 43);
            this.velocity_label.Name = "velocity_label";
            this.velocity_label.Size = new System.Drawing.Size(127, 18);
            this.velocity_label.TabIndex = 9;
            this.velocity_label.Text = "VELOCITY in m/s:";
            // 
            // client_textBox
            // 
            this.client_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_textBox.Location = new System.Drawing.Point(74, 56);
            this.client_textBox.Name = "client_textBox";
            this.client_textBox.Size = new System.Drawing.Size(364, 22);
            this.client_textBox.TabIndex = 10;
            // 
            // pono_textBox
            // 
            this.pono_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pono_textBox.Location = new System.Drawing.Point(75, 81);
            this.pono_textBox.Name = "pono_textBox";
            this.pono_textBox.Size = new System.Drawing.Size(135, 22);
            this.pono_textBox.TabIndex = 11;
            // 
            // wono_textBox
            // 
            this.wono_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wono_textBox.Location = new System.Drawing.Point(75, 109);
            this.wono_textBox.Name = "wono_textBox";
            this.wono_textBox.Size = new System.Drawing.Size(135, 22);
            this.wono_textBox.TabIndex = 12;
            // 
            // rof_textBox
            // 
            this.rof_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rof_textBox.Location = new System.Drawing.Point(195, 10);
            this.rof_textBox.Multiline = true;
            this.rof_textBox.Name = "rof_textBox";
            this.rof_textBox.ReadOnly = true;
            this.rof_textBox.Size = new System.Drawing.Size(165, 21);
            this.rof_textBox.TabIndex = 13;
            // 
            // ac_textBox
            // 
            this.ac_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_textBox.Location = new System.Drawing.Point(195, 39);
            this.ac_textBox.Name = "ac_textBox";
            this.ac_textBox.ReadOnly = true;
            this.ac_textBox.Size = new System.Drawing.Size(139, 22);
            this.ac_textBox.TabIndex = 14;
            // 
            // Re_textBox
            // 
            this.Re_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re_textBox.Location = new System.Drawing.Point(521, 9);
            this.Re_textBox.Name = "Re_textBox";
            this.Re_textBox.ReadOnly = true;
            this.Re_textBox.Size = new System.Drawing.Size(139, 22);
            this.Re_textBox.TabIndex = 15;
            // 
            // velocity_textBox
            // 
            this.velocity_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocity_textBox.Location = new System.Drawing.Point(521, 39);
            this.velocity_textBox.Name = "velocity_textBox";
            this.velocity_textBox.ReadOnly = true;
            this.velocity_textBox.Size = new System.Drawing.Size(139, 22);
            this.velocity_textBox.TabIndex = 16;
            // 
            // probewidth_textBox
            // 
            this.probewidth_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probewidth_textBox.Location = new System.Drawing.Point(510, 36);
            this.probewidth_textBox.Name = "probewidth_textBox";
            this.probewidth_textBox.Size = new System.Drawing.Size(150, 22);
            this.probewidth_textBox.TabIndex = 20;
            // 
            // probewidth_label
            // 
            this.probewidth_label.AutoSize = true;
            this.probewidth_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probewidth_label.Location = new System.Drawing.Point(350, 40);
            this.probewidth_label.Name = "probewidth_label";
            this.probewidth_label.Size = new System.Drawing.Size(145, 18);
            this.probewidth_label.TabIndex = 19;
            this.probewidth_label.Text = "PROBE WIDTH (cm):";
            // 
            // temp_textBox
            // 
            this.temp_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_textBox.Location = new System.Drawing.Point(510, 119);
            this.temp_textBox.Name = "temp_textBox";
            this.temp_textBox.Size = new System.Drawing.Size(150, 22);
            this.temp_textBox.TabIndex = 24;
            // 
            // temp_label
            // 
            this.temp_label.AutoSize = true;
            this.temp_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_label.Location = new System.Drawing.Point(350, 119);
            this.temp_label.Name = "temp_label";
            this.temp_label.Size = new System.Drawing.Size(128, 18);
            this.temp_label.TabIndex = 23;
            this.temp_label.Text = "OPTG. TEMP. (°c):";
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Location = new System.Drawing.Point(5, 1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(310, 52);
            this.logo.TabIndex = 45;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // printpreview_button
            // 
            this.printpreview_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printpreview_button.FlatAppearance.BorderSize = 0;
            this.printpreview_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printpreview_button.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printpreview_button.Location = new System.Drawing.Point(454, 97);
            this.printpreview_button.Name = "printpreview_button";
            this.printpreview_button.Size = new System.Drawing.Size(110, 37);
            this.printpreview_button.TabIndex = 43;
            this.printpreview_button.Text = "PRINT PREVIEW";
            this.printpreview_button.UseVisualStyleBackColor = true;
            this.printpreview_button.Click += new System.EventHandler(this.printpreview_button_Click);
            // 
            // print_button
            // 
            this.print_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.print_button.FlatAppearance.BorderSize = 0;
            this.print_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.print_button.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_button.Location = new System.Drawing.Point(570, 97);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(110, 37);
            this.print_button.TabIndex = 42;
            this.print_button.Text = "PRINT";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // calculate_button
            // 
            this.calculate_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculate_button.FlatAppearance.BorderSize = 0;
            this.calculate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculate_button.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button.Location = new System.Drawing.Point(454, 56);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(110, 37);
            this.calculate_button.TabIndex = 40;
            this.calculate_button.Text = "CALCULATE";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reset_button.FlatAppearance.BorderSize = 0;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(570, 56);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(110, 37);
            this.reset_button.TabIndex = 44;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // finalprintDocument
            // 
            this.finalprintDocument.DocumentName = "pitottubecalculator";
            this.finalprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.finalprintDocument_PrintPage);
            // 
            // finalprintDialog
            // 
            this.finalprintDialog.Document = this.finalprintDocument;
            this.finalprintDialog.UseEXDialog = true;
            // 
            // finalprintPreviewDialog
            // 
            this.finalprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.finalprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.finalprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.finalprintPreviewDialog.Enabled = true;
            this.finalprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("finalprintPreviewDialog.Icon")));
            this.finalprintPreviewDialog.Name = "finalprintPreviewDialog";
            this.finalprintPreviewDialog.Visible = false;
            // 
            // DashLine
            // 
            this.DashLine.AutoSize = true;
            this.DashLine.Location = new System.Drawing.Point(37, 459);
            this.DashLine.Name = "DashLine";
            this.DashLine.Size = new System.Drawing.Size(619, 13);
            this.DashLine.TabIndex = 45;
            this.DashLine.Text = "_________________________________________________________________________________" +
    "_____________________";
            this.DashLine.Click += new System.EventHandler(this.DashLine_Click);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Noto Serif Armenian", 11.25F, System.Drawing.FontStyle.Bold);
            this.input_label.Location = new System.Drawing.Point(16, 140);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(63, 20);
            this.input_label.TabIndex = 32;
            this.input_label.Text = "INPUT:";
            // 
            // staticpressure_label
            // 
            this.staticpressure_label.AutoSize = true;
            this.staticpressure_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticpressure_label.Location = new System.Drawing.Point(8, 119);
            this.staticpressure_label.Name = "staticpressure_label";
            this.staticpressure_label.Size = new System.Drawing.Size(148, 18);
            this.staticpressure_label.TabIndex = 27;
            this.staticpressure_label.Text = "STATIC PR. (mmwc):";
            // 
            // staticpressure_textBox
            // 
            this.staticpressure_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticpressure_textBox.Location = new System.Drawing.Point(184, 119);
            this.staticpressure_textBox.Name = "staticpressure_textBox";
            this.staticpressure_textBox.Size = new System.Drawing.Size(150, 22);
            this.staticpressure_textBox.TabIndex = 28;
            // 
            // fluiddensity_label
            // 
            this.fluiddensity_label.AutoSize = true;
            this.fluiddensity_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluiddensity_label.Location = new System.Drawing.Point(7, 63);
            this.fluiddensity_label.Name = "fluiddensity_label";
            this.fluiddensity_label.Size = new System.Drawing.Size(175, 18);
            this.fluiddensity_label.TabIndex = 21;
            this.fluiddensity_label.Text = "OPTG. DENSITY (kg/m³):";
            // 
            // fluiddensity_textBox
            // 
            this.fluiddensity_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluiddensity_textBox.Location = new System.Drawing.Point(184, 63);
            this.fluiddensity_textBox.Name = "fluiddensity_textBox";
            this.fluiddensity_textBox.Size = new System.Drawing.Size(150, 22);
            this.fluiddensity_textBox.TabIndex = 22;
            // 
            // flow_textBox
            // 
            this.flow_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flow_textBox.Location = new System.Drawing.Point(184, 91);
            this.flow_textBox.Name = "flow_textBox";
            this.flow_textBox.Size = new System.Drawing.Size(150, 22);
            this.flow_textBox.TabIndex = 26;
            // 
            // pipeid_textBox
            // 
            this.pipeid_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipeid_textBox.Location = new System.Drawing.Point(184, 36);
            this.pipeid_textBox.Name = "pipeid_textBox";
            this.pipeid_textBox.Size = new System.Drawing.Size(150, 22);
            this.pipeid_textBox.TabIndex = 18;
            // 
            // flow_label
            // 
            this.flow_label.AutoSize = true;
            this.flow_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flow_label.Location = new System.Drawing.Point(8, 91);
            this.flow_label.Name = "flow_label";
            this.flow_label.Size = new System.Drawing.Size(103, 18);
            this.flow_label.TabIndex = 25;
            this.flow_label.Text = "FLOW (m³/hr):";
            // 
            // viscocity_label
            // 
            this.viscocity_label.AutoSize = true;
            this.viscocity_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viscocity_label.Location = new System.Drawing.Point(350, 67);
            this.viscocity_label.Name = "viscocity_label";
            this.viscocity_label.Size = new System.Drawing.Size(150, 18);
            this.viscocity_label.TabIndex = 29;
            this.viscocity_label.Text = "VISCOSITY (kg/m-s):";
            // 
            // viscosity_textBox
            // 
            this.viscosity_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viscosity_textBox.Location = new System.Drawing.Point(510, 64);
            this.viscosity_textBox.Name = "viscosity_textBox";
            this.viscosity_textBox.Size = new System.Drawing.Size(150, 22);
            this.viscosity_textBox.TabIndex = 30;
            // 
            // pipeid_label
            // 
            this.pipeid_label.AutoSize = true;
            this.pipeid_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipeid_label.Location = new System.Drawing.Point(8, 38);
            this.pipeid_label.Name = "pipeid_label";
            this.pipeid_label.Size = new System.Drawing.Size(102, 18);
            this.pipeid_label.TabIndex = 17;
            this.pipeid_label.Text = "PIPE ID (mm):";
            // 
            // input_panel
            // 
            this.input_panel.BackColor = System.Drawing.Color.Transparent;
            this.input_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_panel.Controls.Add(this.pipeid_label);
            this.input_panel.Controls.Add(this.viscosity_textBox);
            this.input_panel.Controls.Add(this.viscocity_label);
            this.input_panel.Controls.Add(this.flow_label);
            this.input_panel.Controls.Add(this.pipeid_textBox);
            this.input_panel.Controls.Add(this.flow_textBox);
            this.input_panel.Controls.Add(this.fluiddensity_textBox);
            this.input_panel.Controls.Add(this.staticpressure_textBox);
            this.input_panel.Controls.Add(this.fluiddensity_label);
            this.input_panel.Controls.Add(this.staticpressure_label);
            this.input_panel.Controls.Add(this.temp_textBox);
            this.input_panel.Controls.Add(this.probewidth_label);
            this.input_panel.Controls.Add(this.temp_label);
            this.input_panel.Controls.Add(this.probewidth_textBox);
            this.input_panel.Controls.Add(this.rof_comboBox);
            this.input_panel.Controls.Add(this.rof_label);
            this.input_panel.Location = new System.Drawing.Point(5, 150);
            this.input_panel.Name = "input_panel";
            this.input_panel.Size = new System.Drawing.Size(675, 155);
            this.input_panel.TabIndex = 31;
            // 
            // output_panel
            // 
            this.output_panel.BackColor = System.Drawing.Color.Transparent;
            this.output_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_panel.Controls.Add(this.dp_label);
            this.output_panel.Controls.Add(this.rof_textBox);
            this.output_panel.Controls.Add(this.ac_textBox);
            this.output_panel.Controls.Add(this.ac_label);
            this.output_panel.Controls.Add(this.Re_label);
            this.output_panel.Controls.Add(this.Re_textBox);
            this.output_panel.Controls.Add(this.velocity_label);
            this.output_panel.Controls.Add(this.velocity_textBox);
            this.output_panel.Location = new System.Drawing.Point(5, 320);
            this.output_panel.Name = "output_panel";
            this.output_panel.Size = new System.Drawing.Size(675, 74);
            this.output_panel.TabIndex = 46;
            // 
            // dp_label
            // 
            this.dp_label.AutoSize = true;
            this.dp_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_label.Location = new System.Drawing.Point(7, 13);
            this.dp_label.Name = "dp_label";
            this.dp_label.Size = new System.Drawing.Size(188, 18);
            this.dp_label.TabIndex = 17;
            this.dp_label.Text = "DIFFERENTIAL PRESSURE:";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Noto Serif Armenian", 11.25F, System.Drawing.FontStyle.Bold);
            this.output_label.Location = new System.Drawing.Point(19, 315);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(82, 20);
            this.output_label.TabIndex = 47;
            this.output_label.Text = "OUTPUT:";
            // 
            // podate_textBox
            // 
            this.podate_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podate_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.podate_textBox.Location = new System.Drawing.Point(303, 84);
            this.podate_textBox.Name = "podate_textBox";
            this.podate_textBox.Size = new System.Drawing.Size(135, 22);
            this.podate_textBox.TabIndex = 49;
            this.podate_textBox.TextChanged += new System.EventHandler(this.podate_textBox_TextChanged);
            // 
            // podate_label
            // 
            this.podate_label.AutoSize = true;
            this.podate_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podate_label.Location = new System.Drawing.Point(221, 84);
            this.podate_label.Name = "podate_label";
            this.podate_label.Size = new System.Drawing.Size(76, 18);
            this.podate_label.TabIndex = 48;
            this.podate_label.Text = "P.O. DATE:";
            // 
            // tagno_textBox
            // 
            this.tagno_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagno_textBox.Location = new System.Drawing.Point(303, 111);
            this.tagno_textBox.Name = "tagno_textBox";
            this.tagno_textBox.Size = new System.Drawing.Size(135, 22);
            this.tagno_textBox.TabIndex = 51;
            // 
            // tag_label
            // 
            this.tag_label.AutoSize = true;
            this.tag_label.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_label.Location = new System.Drawing.Point(221, 115);
            this.tag_label.Name = "tag_label";
            this.tag_label.Size = new System.Drawing.Size(68, 18);
            this.tag_label.TabIndex = 50;
            this.tag_label.Text = "TAG NO.:";
            // 
            // FINALDEMOPITOTTUBE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 401);
            this.Controls.Add(this.tagno_textBox);
            this.Controls.Add(this.tag_label);
            this.Controls.Add(this.podate_textBox);
            this.Controls.Add(this.podate_label);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.DashLine);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.printpreview_button);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.wono_textBox);
            this.Controls.Add(this.pono_textBox);
            this.Controls.Add(this.client_textBox);
            this.Controls.Add(this.wono_label);
            this.Controls.Add(this.pono_label);
            this.Controls.Add(this.client_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.input_panel);
            this.Controls.Add(this.output_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FINALDEMOPITOTTUBE";
            this.Text = "PITOT TUBE DIFFERENTIAL PRESSURE CALCULATOR";
            this.Load += new System.EventHandler(this.FINALDEMOPITOTTUBE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.input_panel.ResumeLayout(false);
            this.input_panel.PerformLayout();
            this.output_panel.ResumeLayout(false);
            this.output_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label client_label;
        private System.Windows.Forms.Label pono_label;
        private System.Windows.Forms.Label wono_label;
        private System.Windows.Forms.Label rof_label;
        private System.Windows.Forms.ComboBox rof_comboBox;
        private System.Windows.Forms.Label ac_label;
        private System.Windows.Forms.Label Re_label;
        private System.Windows.Forms.Label velocity_label;
        private System.Windows.Forms.TextBox client_textBox;
        private System.Windows.Forms.TextBox pono_textBox;
        private System.Windows.Forms.TextBox wono_textBox;
        private System.Windows.Forms.TextBox rof_textBox;
        private System.Windows.Forms.TextBox ac_textBox;
        private System.Windows.Forms.TextBox Re_textBox;
        private System.Windows.Forms.TextBox velocity_textBox;
        private System.Windows.Forms.TextBox probewidth_textBox;
        private System.Windows.Forms.Label probewidth_label;
        private System.Windows.Forms.TextBox temp_textBox;
        private System.Windows.Forms.Label temp_label;
        private System.Windows.Forms.Button printpreview_button;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.PictureBox logo;
        private System.Drawing.Printing.PrintDocument finalprintDocument;
        private System.Windows.Forms.PrintDialog finalprintDialog;
        private System.Windows.Forms.PrintPreviewDialog finalprintPreviewDialog;
        private System.Windows.Forms.Label DashLine;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label staticpressure_label;
        private System.Windows.Forms.TextBox staticpressure_textBox;
        private System.Windows.Forms.Label fluiddensity_label;
        private System.Windows.Forms.TextBox fluiddensity_textBox;
        private System.Windows.Forms.TextBox flow_textBox;
        private System.Windows.Forms.TextBox pipeid_textBox;
        private System.Windows.Forms.Label flow_label;
        private System.Windows.Forms.Label viscocity_label;
        private System.Windows.Forms.TextBox viscosity_textBox;
        private System.Windows.Forms.Label pipeid_label;
        private System.Windows.Forms.Panel input_panel;
        private System.Windows.Forms.Panel output_panel;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Label dp_label;
        private System.Windows.Forms.TextBox podate_textBox;
        private System.Windows.Forms.Label podate_label;
        private System.Windows.Forms.TextBox tagno_textBox;
        private System.Windows.Forms.Label tag_label;
    }
}

