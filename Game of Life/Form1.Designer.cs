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
            Forward = new Button();
            Rewin = new Button();
            label1 = new Label();
            SpeedBar = new TrackBar();
            SpeedValue = new Label();
            NavPanel = new Panel();
            FramesToSkip = new NumericUpDown();
            FramesToSkipLabel = new Label();
            OnFrame = new TextBox();
            FrameCountLabel = new Label();
            NavStart = new Button();
            Forward3x = new Button();
            Minus = new Button();
            Plus = new Button();
            Forward1x = new Button();
            Reverse1x = new Button();
            Reverse3x = new Button();
            label3 = new Label();
            EditorParentPanel = new Panel();
            ClearGame = new Button();
            BrushSizeLable = new Label();
            BrushSizeValue = new NumericUpDown();
            EditorY = new NumericUpDown();
            EditorX = new NumericUpDown();
            GameInverse = new Button();
            EditorReset = new Button();
            EditorClear = new Button();
            CopyFrame = new Button();
            PaintMode = new Button();
            InverseEditor = new Button();
            LoadFrame = new Button();
            BrushTitle = new Panel();
            Brush = new Label();
            GameTitle = new Panel();
            GridGameLable = new Label();
            EditorTitle = new Panel();
            EditGridMenu = new Label();
            DimensionsLable = new Label();
            EditorLable = new Label();
            EditorPanel = new Panel();
            GamePanel = new Panel();
            tmrUpdate = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)SpeedBar).BeginInit();
            NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FramesToSkip).BeginInit();
            EditorParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BrushSizeValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditorY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditorX).BeginInit();
            BrushTitle.SuspendLayout();
            GameTitle.SuspendLayout();
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
            // Forward
            // 
            Forward.Location = new Point(306, 34);
            Forward.Name = "Forward";
            Forward.Size = new Size(121, 23);
            Forward.TabIndex = 2;
            Forward.Text = "--> ";
            Forward.UseVisualStyleBackColor = true;
            // 
            // Rewin
            // 
            Rewin.Location = new Point(179, 34);
            Rewin.Name = "Rewin";
            Rewin.Size = new Size(121, 23);
            Rewin.TabIndex = 3;
            Rewin.Text = "<-- ";
            Rewin.UseVisualStyleBackColor = true;
            Rewin.Click += Rewind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 38);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Speed :";
            // 
            // SpeedBar
            // 
            SpeedBar.Location = new Point(484, 24);
            SpeedBar.Maximum = 1000;
            SpeedBar.Minimum = 10;
            SpeedBar.Name = "SpeedBar";
            SpeedBar.Size = new Size(137, 45);
            SpeedBar.SmallChange = 10;
            SpeedBar.TabIndex = 5;
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
            NavPanel.Controls.Add(FramesToSkip);
            NavPanel.Controls.Add(FramesToSkipLabel);
            NavPanel.Controls.Add(OnFrame);
            NavPanel.Controls.Add(FrameCountLabel);
            NavPanel.Controls.Add(NavStart);
            NavPanel.Controls.Add(Forward3x);
            NavPanel.Controls.Add(Minus);
            NavPanel.Controls.Add(Plus);
            NavPanel.Controls.Add(Forward1x);
            NavPanel.Controls.Add(Reverse1x);
            NavPanel.Controls.Add(Reverse3x);
            NavPanel.Controls.Add(label3);
            NavPanel.Location = new Point(12, 600);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(644, 68);
            NavPanel.TabIndex = 7;
            // 
            // FramesToSkip
            // 
            FramesToSkip.Location = new Point(405, 32);
            FramesToSkip.Name = "FramesToSkip";
            FramesToSkip.Size = new Size(35, 23);
            FramesToSkip.TabIndex = 8;
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
            // OnFrame
            // 
            OnFrame.Location = new Point(519, 32);
            OnFrame.Name = "OnFrame";
            OnFrame.Size = new Size(49, 23);
            OnFrame.TabIndex = 11;
            // 
            // FrameCountLabel
            // 
            FrameCountLabel.AutoSize = true;
            FrameCountLabel.Location = new Point(467, 36);
            FrameCountLabel.Name = "FrameCountLabel";
            FrameCountLabel.Size = new Size(46, 15);
            FrameCountLabel.TabIndex = 9;
            FrameCountLabel.Text = "Frame :";
            // 
            // NavStart
            // 
            NavStart.Location = new Point(574, 5);
            NavStart.Name = "NavStart";
            NavStart.Size = new Size(67, 60);
            NavStart.TabIndex = 7;
            NavStart.Text = "Go";
            NavStart.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 5);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Navigator";
            // 
            // EditorParentPanel
            // 
            EditorParentPanel.BackColor = SystemColors.ScrollBar;
            EditorParentPanel.Controls.Add(ClearGame);
            EditorParentPanel.Controls.Add(BrushSizeLable);
            EditorParentPanel.Controls.Add(BrushSizeValue);
            EditorParentPanel.Controls.Add(EditorY);
            EditorParentPanel.Controls.Add(EditorX);
            EditorParentPanel.Controls.Add(GameInverse);
            EditorParentPanel.Controls.Add(EditorReset);
            EditorParentPanel.Controls.Add(EditorClear);
            EditorParentPanel.Controls.Add(CopyFrame);
            EditorParentPanel.Controls.Add(PaintMode);
            EditorParentPanel.Controls.Add(InverseEditor);
            EditorParentPanel.Controls.Add(LoadFrame);
            EditorParentPanel.Controls.Add(BrushTitle);
            EditorParentPanel.Controls.Add(GameTitle);
            EditorParentPanel.Controls.Add(EditorTitle);
            EditorParentPanel.Controls.Add(DimensionsLable);
            EditorParentPanel.Controls.Add(EditorLable);
            EditorParentPanel.Controls.Add(EditorPanel);
            EditorParentPanel.Location = new Point(662, 24);
            EditorParentPanel.Name = "EditorParentPanel";
            EditorParentPanel.Size = new Size(359, 644);
            EditorParentPanel.TabIndex = 8;
            // 
            // ClearGame
            // 
            ClearGame.Location = new Point(196, 579);
            ClearGame.Name = "ClearGame";
            ClearGame.Size = new Size(158, 23);
            ClearGame.TabIndex = 21;
            ClearGame.Text = "Clear";
            ClearGame.UseVisualStyleBackColor = true;
            ClearGame.Click += ClearGame_click;
            // 
            // BrushSizeLable
            // 
            BrushSizeLable.AutoSize = true;
            BrushSizeLable.Location = new Point(198, 515);
            BrushSizeLable.Name = "BrushSizeLable";
            BrushSizeLable.Size = new Size(27, 15);
            BrushSizeLable.TabIndex = 20;
            BrushSizeLable.Text = "Size";
            // 
            // BrushSizeValue
            // 
            BrushSizeValue.Location = new Point(269, 508);
            BrushSizeValue.Name = "BrushSizeValue";
            BrushSizeValue.Size = new Size(67, 23);
            BrushSizeValue.TabIndex = 19;
            BrushSizeValue.ValueChanged += BrushSize_ValueChanged;
            // 
            // EditorY
            // 
            EditorY.Location = new Point(114, 507);
            EditorY.Name = "EditorY";
            EditorY.Size = new Size(54, 23);
            EditorY.TabIndex = 10;
            // 
            // EditorX
            // 
            EditorX.Location = new Point(114, 468);
            EditorX.Name = "EditorX";
            EditorX.Size = new Size(55, 23);
            EditorX.TabIndex = 11;
            // 
            // GameInverse
            // 
            GameInverse.Location = new Point(12, 579);
            GameInverse.Name = "GameInverse";
            GameInverse.Size = new Size(177, 23);
            GameInverse.TabIndex = 16;
            GameInverse.Text = "Inverse Game";
            GameInverse.UseVisualStyleBackColor = true;
            GameInverse.Click += ReverseGame_click;
            // 
            // EditorReset
            // 
            EditorReset.Location = new Point(198, 458);
            EditorReset.Name = "EditorReset";
            EditorReset.Size = new Size(158, 23);
            EditorReset.TabIndex = 15;
            EditorReset.Text = "New Grid";
            EditorReset.UseVisualStyleBackColor = true;
            EditorReset.Click += Reset_Click;
            // 
            // EditorClear
            // 
            EditorClear.Location = new Point(198, 429);
            EditorClear.Name = "EditorClear";
            EditorClear.Size = new Size(158, 23);
            EditorClear.TabIndex = 14;
            EditorClear.Text = "Clear";
            EditorClear.UseVisualStyleBackColor = true;
            EditorClear.Click += ClearEditor_click;
            // 
            // CopyFrame
            // 
            CopyFrame.ForeColor = SystemColors.AppWorkspace;
            CopyFrame.Location = new Point(198, 400);
            CopyFrame.Name = "CopyFrame";
            CopyFrame.Size = new Size(158, 23);
            CopyFrame.TabIndex = 13;
            CopyFrame.Text = "Copy Frame";
            CopyFrame.UseVisualStyleBackColor = true;
            CopyFrame.Click += CopyEditor_click;
            // 
            // PaintMode
            // 
            PaintMode.Location = new Point(114, 429);
            PaintMode.Name = "PaintMode";
            PaintMode.Size = new Size(75, 23);
            PaintMode.TabIndex = 12;
            PaintMode.Text = "Paint";
            PaintMode.UseVisualStyleBackColor = true;
            PaintMode.Click += Paint_click;
            // 
            // InverseEditor
            // 
            InverseEditor.Location = new Point(13, 429);
            InverseEditor.Name = "InverseEditor";
            InverseEditor.Size = new Size(78, 23);
            InverseEditor.TabIndex = 11;
            InverseEditor.Text = "Inverse";
            InverseEditor.UseVisualStyleBackColor = true;
            // 
            // LoadFrame
            // 
            LoadFrame.Location = new Point(13, 400);
            LoadFrame.Name = "LoadFrame";
            LoadFrame.Size = new Size(176, 23);
            LoadFrame.TabIndex = 9;
            LoadFrame.Text = "Load Frame";
            LoadFrame.UseVisualStyleBackColor = true;
            // 
            // BrushTitle
            // 
            BrushTitle.BackColor = SystemColors.AppWorkspace;
            BrushTitle.Controls.Add(Brush);
            BrushTitle.Location = new Point(198, 487);
            BrushTitle.Name = "BrushTitle";
            BrushTitle.Size = new Size(157, 15);
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
            // GameTitle
            // 
            GameTitle.BackColor = SystemColors.AppWorkspace;
            GameTitle.Controls.Add(GridGameLable);
            GameTitle.Location = new Point(2, 555);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(353, 15);
            GameTitle.TabIndex = 7;
            // 
            // GridGameLable
            // 
            GridGameLable.AutoSize = true;
            GridGameLable.Location = new Point(0, 0);
            GridGameLable.Name = "GridGameLable";
            GridGameLable.Size = new Size(63, 15);
            GridGameLable.TabIndex = 4;
            GridGameLable.Text = "Game Grid";
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
            DimensionsLable.Location = new Point(16, 487);
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
            EditorPanel.Size = new Size(353, 350);
            EditorPanel.TabIndex = 0;
            // 
            // GamePanel
            // 
            GamePanel.BackColor = SystemColors.ControlDarkDark;
            GamePanel.Enabled = false;
            GamePanel.Location = new Point(12, 63);
            GamePanel.Name = "GamePanel";
            GamePanel.Size = new Size(644, 531);
            GamePanel.TabIndex = 9;
            // 
            // tmrUpdate
            // 
            tmrUpdate.Interval = 1000;
            tmrUpdate.Tick += tmrUpdate_tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 680);
            Controls.Add(GamePanel);
            Controls.Add(EditorParentPanel);
            Controls.Add(NavPanel);
            Controls.Add(SpeedValue);
            Controls.Add(SpeedBar);
            Controls.Add(label1);
            Controls.Add(Rewin);
            Controls.Add(Forward);
            Controls.Add(Reset);
            Controls.Add(Play);
            Name = "Form1";
            Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)SpeedBar).EndInit();
            NavPanel.ResumeLayout(false);
            NavPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FramesToSkip).EndInit();
            EditorParentPanel.ResumeLayout(false);
            EditorParentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BrushSizeValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditorY).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditorX).EndInit();
            BrushTitle.ResumeLayout(false);
            BrushTitle.PerformLayout();
            GameTitle.ResumeLayout(false);
            GameTitle.PerformLayout();
            EditorTitle.ResumeLayout(false);
            EditorTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Button Reset;
        private Button Forward;
        private Button Rewin;
        private Label label1;
        private TrackBar SpeedBar;
        private Label SpeedValue;
        private Panel NavPanel;
        private Label label3;
        private Button NavStart;
        private Button Forward3x;
        private Button Minus;
        private Button Plus;
        private Button Forward1x;
        private Button Reverse1x;
        private Button Reverse3x;
        private TextBox OnFrame;
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
        private Button EditorReset;
        private Button EditorClear;
        private Button CopyFrame;
        private Button PaintMode;
        private Button InverseEditor;
        private Button LoadFrame;
        private Panel BrushTitle;
        private Panel GameTitle;
        private Button ClearGame;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}