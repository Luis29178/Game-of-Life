namespace Game_of_Life
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
            components = new System.ComponentModel.Container();
            Play = new Button();
            Reset = new Button();
            Rewin = new Button();
            label1 = new Label();
            SpeedBar = new TrackBar();
            SpeedValue = new Label();
            NavPanel = new Panel();
            OnFrame = new NumericUpDown();
            panel1 = new Panel();
            label3 = new Label();
            FramesToSkip = new NumericUpDown();
            FramesToSkipLabel = new Label();
            FrameCountLabel = new Label();
            goToFrame = new Button();
            Forward3x = new Button();
            Minus = new Button();
            Plus = new Button();
            Forward1x = new Button();
            Reverse1x = new Button();
            Reverse3x = new Button();
            ClearGame = new Button();
            GameInverse = new Button();
            EditorParentPanel = new Panel();
            InverseEditor = new Button();
            button2 = new Button();
            SetDimentions = new Button();
            button1 = new Button();
            InvertBrushbtn = new Button();
            DeathBrushbtn = new Button();
            LifeBrushbtn = new Button();
            CopyFrame = new Button();
            GridApply = new Button();
            panel2 = new Panel();
            GridTitleLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            BrushSizeLable = new Label();
            BrushSizeValue = new NumericUpDown();
            EditorY = new NumericUpDown();
            EditorX = new NumericUpDown();
            EditorClear = new Button();
            PaintMode = new Button();
            BrushTitle = new Panel();
            Brush = new Label();
            EditorTitle = new Panel();
            EditGridMenu = new Label();
            DimensionsLable = new Label();
            EditorLable = new Label();
            EditorPanel = new Panel();
            GamePanel = new Panel();
            tmrUpdate = new System.Windows.Forms.Timer(components);
            MInfoLabel = new Label();
            cInfoLabel = new Label();
            fInfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SpeedBar).BeginInit();
            NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OnFrame).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FramesToSkip).BeginInit();
            EditorParentPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BrushSizeValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditorY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditorX).BeginInit();
            BrushTitle.SuspendLayout();
            EditorTitle.SuspendLayout();
            SuspendLayout();
            // 
            // Play
            // 
            Play.BackColor = SystemColors.Control;
            Play.ForeColor = SystemColors.ControlText;
            Play.Location = new Point(12, 34);
            Play.Name = "Play";
            Play.Size = new Size(75, 23);
            Play.TabIndex = 0;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = false;
            Play.Click += Play_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(93, 34);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 1;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Rewin
            // 
            Rewin.Location = new Point(179, 34);
            Rewin.Name = "Rewin";
            Rewin.Size = new Size(121, 23);
            Rewin.TabIndex = 3;
            Rewin.Text = "-->";
            Rewin.UseVisualStyleBackColor = true;
            Rewin.Click += Rewind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 38);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Speed :";
            // 
            // SpeedBar
            // 
            SpeedBar.LargeChange = 50;
            SpeedBar.Location = new Point(357, 24);
            SpeedBar.Maximum = 1000;
            SpeedBar.Minimum = 10;
            SpeedBar.Name = "SpeedBar";
            SpeedBar.Size = new Size(264, 45);
            SpeedBar.SmallChange = 10;
            SpeedBar.TabIndex = 5;
            SpeedBar.TickFrequency = 10;
            SpeedBar.Value = 1000;
            SpeedBar.ValueChanged += hscSpeed_ValueChaned;
            // 
            // SpeedValue
            // 
            SpeedValue.AutoSize = true;
            SpeedValue.Location = new Point(615, 38);
            SpeedValue.Name = "SpeedValue";
            SpeedValue.Size = new Size(29, 15);
            SpeedValue.TabIndex = 6;
            SpeedValue.Text = "0ms";
            // 
            // NavPanel
            // 
            NavPanel.BackColor = SystemColors.ScrollBar;
            NavPanel.Controls.Add(OnFrame);
            NavPanel.Controls.Add(panel1);
            NavPanel.Controls.Add(FramesToSkip);
            NavPanel.Controls.Add(FramesToSkipLabel);
            NavPanel.Controls.Add(FrameCountLabel);
            NavPanel.Controls.Add(goToFrame);
            NavPanel.Controls.Add(Forward3x);
            NavPanel.Controls.Add(Minus);
            NavPanel.Controls.Add(Plus);
            NavPanel.Controls.Add(Forward1x);
            NavPanel.Controls.Add(Reverse1x);
            NavPanel.Controls.Add(Reverse3x);
            NavPanel.Location = new Point(12, 709);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(640, 68);
            NavPanel.TabIndex = 7;
            // 
            // OnFrame
            // 
            OnFrame.InterceptArrowKeys = false;
            OnFrame.Location = new Point(512, 32);
            OnFrame.Name = "OnFrame";
            OnFrame.Size = new Size(56, 23);
            OnFrame.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(10, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 15);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Navigator";
            // 
            // FramesToSkip
            // 
            FramesToSkip.Location = new Point(405, 32);
            FramesToSkip.Name = "FramesToSkip";
            FramesToSkip.Size = new Size(35, 23);
            FramesToSkip.TabIndex = 8;
            FramesToSkip.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // FramesToSkipLabel
            // 
            FramesToSkipLabel.AutoSize = true;
            FramesToSkipLabel.Location = new Point(316, 36);
            FramesToSkipLabel.Name = "FramesToSkipLabel";
            FramesToSkipLabel.Size = new Size(89, 15);
            FramesToSkipLabel.TabIndex = 8;
            FramesToSkipLabel.Text = "Frames Skiped :";
            // 
            // FrameCountLabel
            // 
            FrameCountLabel.AutoSize = true;
            FrameCountLabel.Location = new Point(460, 36);
            FrameCountLabel.Name = "FrameCountLabel";
            FrameCountLabel.Size = new Size(46, 15);
            FrameCountLabel.TabIndex = 9;
            FrameCountLabel.Text = "Frame :";
            // 
            // goToFrame
            // 
            goToFrame.Location = new Point(574, 32);
            goToFrame.Name = "goToFrame";
            goToFrame.Size = new Size(63, 23);
            goToFrame.TabIndex = 7;
            goToFrame.Text = "Go";
            goToFrame.UseVisualStyleBackColor = true;
            goToFrame.Click += GotoFrame_click;
            // 
            // Forward3x
            // 
            Forward3x.Location = new Point(265, 32);
            Forward3x.Name = "Forward3x";
            Forward3x.Size = new Size(45, 23);
            Forward3x.TabIndex = 6;
            Forward3x.Text = ">>";
            Forward3x.UseVisualStyleBackColor = true;
            Forward3x.Click += FramesToSkipFFX_click;
            // 
            // Minus
            // 
            Minus.Location = new Point(112, 32);
            Minus.Name = "Minus";
            Minus.Size = new Size(45, 23);
            Minus.TabIndex = 5;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += minus_click;
            // 
            // Plus
            // 
            Plus.Location = new Point(163, 32);
            Plus.Name = "Plus";
            Plus.Size = new Size(45, 23);
            Plus.TabIndex = 4;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += plus_click;
            // 
            // Forward1x
            // 
            Forward1x.Location = new Point(214, 32);
            Forward1x.Name = "Forward1x";
            Forward1x.Size = new Size(45, 23);
            Forward1x.TabIndex = 3;
            Forward1x.Text = ">";
            Forward1x.UseVisualStyleBackColor = true;
            Forward1x.Click += FramesToSkipFF_click;
            // 
            // Reverse1x
            // 
            Reverse1x.Location = new Point(61, 32);
            Reverse1x.Name = "Reverse1x";
            Reverse1x.Size = new Size(45, 23);
            Reverse1x.TabIndex = 2;
            Reverse1x.Text = "<";
            Reverse1x.UseVisualStyleBackColor = true;
            Reverse1x.Click += FramesToSkipRW_click;
            // 
            // Reverse3x
            // 
            Reverse3x.Location = new Point(10, 32);
            Reverse3x.Name = "Reverse3x";
            Reverse3x.Size = new Size(45, 23);
            Reverse3x.TabIndex = 1;
            Reverse3x.Text = "<<";
            Reverse3x.UseVisualStyleBackColor = true;
            Reverse3x.Click += FramesToSkipRWX_click;
            // 
            // ClearGame
            // 
            ClearGame.Location = new Point(180, 616);
            ClearGame.Name = "ClearGame";
            ClearGame.Size = new Size(176, 24);
            ClearGame.TabIndex = 21;
            ClearGame.Text = "Clear";
            ClearGame.UseVisualStyleBackColor = true;
            ClearGame.Click += ClearGame_click;
            // 
            // GameInverse
            // 
            GameInverse.Location = new Point(180, 649);
            GameInverse.Name = "GameInverse";
            GameInverse.Size = new Size(176, 24);
            GameInverse.TabIndex = 16;
            GameInverse.Text = "Inverse";
            GameInverse.UseVisualStyleBackColor = true;
            GameInverse.Click += ReverseGame_click;
            // 
            // EditorParentPanel
            // 
            EditorParentPanel.BackColor = SystemColors.ScrollBar;
            EditorParentPanel.Controls.Add(InverseEditor);
            EditorParentPanel.Controls.Add(button2);
            EditorParentPanel.Controls.Add(SetDimentions);
            EditorParentPanel.Controls.Add(button1);
            EditorParentPanel.Controls.Add(InvertBrushbtn);
            EditorParentPanel.Controls.Add(DeathBrushbtn);
            EditorParentPanel.Controls.Add(LifeBrushbtn);
            EditorParentPanel.Controls.Add(CopyFrame);
            EditorParentPanel.Controls.Add(GridApply);
            EditorParentPanel.Controls.Add(panel2);
            EditorParentPanel.Controls.Add(numericUpDown1);
            EditorParentPanel.Controls.Add(numericUpDown2);
            EditorParentPanel.Controls.Add(label2);
            EditorParentPanel.Controls.Add(BrushSizeLable);
            EditorParentPanel.Controls.Add(BrushSizeValue);
            EditorParentPanel.Controls.Add(ClearGame);
            EditorParentPanel.Controls.Add(EditorY);
            EditorParentPanel.Controls.Add(EditorX);
            EditorParentPanel.Controls.Add(EditorClear);
            EditorParentPanel.Controls.Add(GameInverse);
            EditorParentPanel.Controls.Add(PaintMode);
            EditorParentPanel.Controls.Add(BrushTitle);
            EditorParentPanel.Controls.Add(EditorTitle);
            EditorParentPanel.Controls.Add(DimensionsLable);
            EditorParentPanel.Controls.Add(EditorLable);
            EditorParentPanel.Controls.Add(EditorPanel);
            EditorParentPanel.Location = new Point(662, 24);
            EditorParentPanel.Name = "EditorParentPanel";
            EditorParentPanel.Size = new Size(359, 753);
            EditorParentPanel.TabIndex = 8;
            // 
            // InverseEditor
            // 
            InverseEditor.Enabled = false;
            InverseEditor.Location = new Point(198, 426);
            InverseEditor.Name = "InverseEditor";
            InverseEditor.Size = new Size(157, 23);
            InverseEditor.TabIndex = 11;
            InverseEditor.Text = "Inverse";
            InverseEditor.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(79, 655);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 33;
            button2.Text = "🔗";
            button2.UseVisualStyleBackColor = false;
            // 
            // SetDimentions
            // 
            SetDimentions.Location = new Point(56, 507);
            SetDimentions.Name = "SetDimentions";
            SetDimentions.Size = new Size(75, 23);
            SetDimentions.TabIndex = 32;
            SetDimentions.Text = "Apply";
            SetDimentions.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(79, 478);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 31;
            button1.Text = "🔗";
            button1.UseVisualStyleBackColor = false;
            // 
            // InvertBrushbtn
            // 
            InvertBrushbtn.Enabled = false;
            InvertBrushbtn.Location = new Point(307, 566);
            InvertBrushbtn.Name = "InvertBrushbtn";
            InvertBrushbtn.Size = new Size(50, 23);
            InvertBrushbtn.TabIndex = 30;
            InvertBrushbtn.Text = "Invert";
            InvertBrushbtn.UseVisualStyleBackColor = true;
            InvertBrushbtn.Click += InvertBrushbtn_Click;
            // 
            // DeathBrushbtn
            // 
            DeathBrushbtn.Location = new Point(255, 566);
            DeathBrushbtn.Name = "DeathBrushbtn";
            DeathBrushbtn.Size = new Size(50, 23);
            DeathBrushbtn.TabIndex = 29;
            DeathBrushbtn.Text = "Death";
            DeathBrushbtn.UseVisualStyleBackColor = true;
            DeathBrushbtn.Click += DeathBrushbtn_Click;
            // 
            // LifeBrushbtn
            // 
            LifeBrushbtn.Location = new Point(200, 566);
            LifeBrushbtn.Name = "LifeBrushbtn";
            LifeBrushbtn.Size = new Size(50, 23);
            LifeBrushbtn.TabIndex = 28;
            LifeBrushbtn.Text = "Life";
            LifeBrushbtn.UseVisualStyleBackColor = true;
            LifeBrushbtn.Click += LifeBrushbtn_Click;
            // 
            // CopyFrame
            // 
            CopyFrame.Location = new Point(198, 479);
            CopyFrame.Name = "CopyFrame";
            CopyFrame.Size = new Size(157, 23);
            CopyFrame.TabIndex = 27;
            CopyFrame.Text = "Copy Frame";
            CopyFrame.UseVisualStyleBackColor = true;
            CopyFrame.Click += PasteEditor_click;
            // 
            // GridApply
            // 
            GridApply.Location = new Point(56, 684);
            GridApply.Name = "GridApply";
            GridApply.Size = new Size(75, 25);
            GridApply.TabIndex = 25;
            GridApply.Text = "Apply";
            GridApply.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(GridTitleLabel);
            panel2.Location = new Point(4, 595);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 15);
            panel2.TabIndex = 9;
            // 
            // GridTitleLabel
            // 
            GridTitleLabel.AutoSize = true;
            GridTitleLabel.Location = new Point(-2, 0);
            GridTitleLabel.Name = "GridTitleLabel";
            GridTitleLabel.Size = new Size(72, 15);
            GridTitleLabel.TabIndex = 5;
            GridTitleLabel.Text = "Grid Control";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(110, 655);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(19, 655);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(55, 23);
            numericUpDown2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 637);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 22;
            label2.Text = "Dimensions :";
            // 
            // BrushSizeLable
            // 
            BrushSizeLable.AutoSize = true;
            BrushSizeLable.Location = new Point(206, 541);
            BrushSizeLable.Name = "BrushSizeLable";
            BrushSizeLable.Size = new Size(27, 15);
            BrushSizeLable.TabIndex = 20;
            BrushSizeLable.Text = "Size";
            // 
            // BrushSizeValue
            // 
            BrushSizeValue.Location = new Point(277, 534);
            BrushSizeValue.Name = "BrushSizeValue";
            BrushSizeValue.Size = new Size(76, 23);
            BrushSizeValue.TabIndex = 19;
            BrushSizeValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            BrushSizeValue.ValueChanged += BrushSize_ValueChanged;
            // 
            // EditorY
            // 
            EditorY.Location = new Point(110, 478);
            EditorY.Name = "EditorY";
            EditorY.Size = new Size(54, 23);
            EditorY.TabIndex = 10;
            // 
            // EditorX
            // 
            EditorX.Location = new Point(19, 478);
            EditorX.Name = "EditorX";
            EditorX.Size = new Size(55, 23);
            EditorX.TabIndex = 11;
            // 
            // EditorClear
            // 
            EditorClear.Location = new Point(198, 400);
            EditorClear.Name = "EditorClear";
            EditorClear.Size = new Size(156, 23);
            EditorClear.TabIndex = 14;
            EditorClear.Text = "Clear";
            EditorClear.UseVisualStyleBackColor = true;
            EditorClear.Click += ClearEditor_click;
            // 
            // PaintMode
            // 
            PaintMode.Enabled = false;
            PaintMode.Location = new Point(198, 505);
            PaintMode.Name = "PaintMode";
            PaintMode.Size = new Size(156, 23);
            PaintMode.TabIndex = 12;
            PaintMode.Text = "Paint";
            PaintMode.UseVisualStyleBackColor = true;
            PaintMode.Click += PaintEditor_click;
            // 
            // BrushTitle
            // 
            BrushTitle.BackColor = SystemColors.AppWorkspace;
            BrushTitle.Controls.Add(Brush);
            BrushTitle.Location = new Point(198, 458);
            BrushTitle.Name = "BrushTitle";
            BrushTitle.Size = new Size(161, 15);
            BrushTitle.TabIndex = 8;
            // 
            // Brush
            // 
            Brush.AutoSize = true;
            Brush.Location = new Point(-2, 0);
            Brush.Name = "Brush";
            Brush.Size = new Size(37, 15);
            Brush.TabIndex = 5;
            Brush.Text = "Brush";
            // 
            // EditorTitle
            // 
            EditorTitle.BackColor = SystemColors.AppWorkspace;
            EditorTitle.Controls.Add(EditGridMenu);
            EditorTitle.Location = new Point(3, 379);
            EditorTitle.Name = "EditorTitle";
            EditorTitle.Size = new Size(353, 15);
            EditorTitle.TabIndex = 6;
            // 
            // EditGridMenu
            // 
            EditGridMenu.AutoSize = true;
            EditGridMenu.Location = new Point(0, 0);
            EditGridMenu.Name = "EditGridMenu";
            EditGridMenu.Size = new Size(52, 15);
            EditGridMenu.TabIndex = 2;
            EditGridMenu.Text = "Edit Grid";
            // 
            // DimensionsLable
            // 
            DimensionsLable.AutoSize = true;
            DimensionsLable.Location = new Point(56, 458);
            DimensionsLable.Name = "DimensionsLable";
            DimensionsLable.Size = new Size(75, 15);
            DimensionsLable.TabIndex = 3;
            DimensionsLable.Text = "Dimensions :";
            // 
            // EditorLable
            // 
            EditorLable.AutoSize = true;
            EditorLable.Location = new Point(3, 5);
            EditorLable.Name = "EditorLable";
            EditorLable.Size = new Size(38, 15);
            EditorLable.TabIndex = 1;
            EditorLable.Text = "Editor";
            // 
            // EditorPanel
            // 
            EditorPanel.BackColor = SystemColors.Control;
            EditorPanel.Location = new Point(3, 23);
            EditorPanel.Name = "EditorPanel";
            EditorPanel.Size = new Size(350, 350);
            EditorPanel.TabIndex = 0;
            // 
            // GamePanel
            // 
            GamePanel.BackColor = SystemColors.ControlDarkDark;
            GamePanel.Enabled = false;
            GamePanel.Location = new Point(12, 63);
            GamePanel.Name = "GamePanel";
            GamePanel.Size = new Size(640, 640);
            GamePanel.TabIndex = 9;
            // 
            // tmrUpdate
            // 
            tmrUpdate.Interval = 1000;
            tmrUpdate.Tick += tmrUpdate_tick;
            // 
            // MInfoLabel
            // 
            MInfoLabel.AutoSize = true;
            MInfoLabel.Location = new Point(825, 788);
            MInfoLabel.Name = "MInfoLabel";
            MInfoLabel.Size = new Size(117, 15);
            MInfoLabel.TabIndex = 10;
            MInfoLabel.Text = "Mode: Coming Soon";
            // 
            // cInfoLabel
            // 
            cInfoLabel.AutoSize = true;
            cInfoLabel.Location = new Point(149, 788);
            cInfoLabel.Name = "cInfoLabel";
            cInfoLabel.Size = new Size(79, 15);
            cInfoLabel.TabIndex = 11;
            cInfoLabel.Text = "Cell Info: N/A";
            // 
            // fInfoLabel
            // 
            fInfoLabel.AutoSize = true;
            fInfoLabel.Location = new Point(548, 788);
            fInfoLabel.Name = "fInfoLabel";
            fInfoLabel.Size = new Size(63, 15);
            fInfoLabel.TabIndex = 12;
            fInfoLabel.Text = "Frame: 0/0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 808);
            Controls.Add(fInfoLabel);
            Controls.Add(cInfoLabel);
            Controls.Add(MInfoLabel);
            Controls.Add(GamePanel);
            Controls.Add(EditorParentPanel);
            Controls.Add(NavPanel);
            Controls.Add(SpeedValue);
            Controls.Add(SpeedBar);
            Controls.Add(label1);
            Controls.Add(Rewin);
            Controls.Add(Reset);
            Controls.Add(Play);
            Name = "Form1";
            Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)SpeedBar).EndInit();
            NavPanel.ResumeLayout(false);
            NavPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OnFrame).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FramesToSkip).EndInit();
            EditorParentPanel.ResumeLayout(false);
            EditorParentPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BrushSizeValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditorY).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditorX).EndInit();
            BrushTitle.ResumeLayout(false);
            BrushTitle.PerformLayout();
            EditorTitle.ResumeLayout(false);
            EditorTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Button Reset;
        private Button Rewin;
        private Label label1;
        private TrackBar SpeedBar;
        private Label SpeedValue;
        private Panel NavPanel;
        private Label label3;
        private Button goToFrame;
        private Button Forward3x;
        private Button Minus;
        private Button Plus;
        private Button Forward1x;
        private Button Reverse1x;
        private Button Reverse3x;
        private Label FrameCountLabel;
        private Label FramesToSkipLabel;
        private NumericUpDown FramesToSkip;
        private Panel EditorParentPanel;
        private Label Brush;
        private Label GridGameLable;
        private Label DimensionsLable;
        private Label EditGridMenu;
        private Label EditorLable;
        private Panel EditorPanel;
        private Panel GamePanel;
        private Panel EditorTitle;
        private Label BrushSizeLable;
        private NumericUpDown BrushSizeValue;
        private NumericUpDown EditorY;
        private NumericUpDown EditorX;
        private Button button14;
        private Button button13;
        private Button GameInverse;
        private Button EditorClear;
        private Button PaintMode;
        private Button InverseEditor;
        private Panel BrushTitle;
        private Panel GameTitle;
        private Button ClearGame;
        private System.Windows.Forms.Timer tmrUpdate;
        private Panel panel1;
        private Label MInfoLabel;
        private Label cInfoLabel;
        private Label fInfoLabel;
        private NumericUpDown OnFrame;
        private Panel panel2;
        private Label GridTitleLabel;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private Button GridApply;
        private Button CopyFrame;
        private Button InvertBrushbtn;
        private Button DeathBrushbtn;
        private Button LifeBrushbtn;
        private Button button1;
        private Button SetDimentions;
        private Button button2;
    }
}