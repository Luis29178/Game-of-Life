using Game_of_Life.Editor;
using Game_of_Life.Frames;
using Game_of_Life.Stucts;
using System;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        GameManager gameManager;
        EditorMode editor;
        LabelGrid gameGrid;
        LabelGrid editorGrid;
        string mode = "Paint";
        string brush = "Invert";
        bool editorLinkDimentionsCheck = false;
        bool gameLinkDimentionsCheck = false;


        public Form1()
        {
            InitializeComponent();
            gameGrid = new LabelGrid(GamePanel, 25, 25, 35, 35, 1);
            editorGrid = new LabelGrid(EditorPanel, 5, 5, 10, 10, 1);
            gameManager = new GameManager(gameGrid);
            editor = new EditorMode(gameGrid, editorGrid);


            tmrUpdate.Interval = SpeedBar.Value;

            UpdateInfoDisplay();
            UpdateControlsDisplay();

            SpeedValue.Text = $"{SpeedBar.Value} ms";

            MInfoLabel.Text = $"Mode : {mode} | Brush: {brush}";

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (tmrUpdate.Enabled)
            {
                tmrUpdate.Stop();
                Play.Text = "Play";
            }
            else
            {
                tmrUpdate.Start();
                Play.Text = "Pause";

            }
            UpdateControlsDisplay();

        }

        private void Reset_Click(object sender, EventArgs e)
        {

            gameManager = new GameManager(gameGrid);
            gameGrid.Clear();
            UpdateInfoDisplay();
            UpdateControlsDisplay();

        }
        private void Rewind_Click(object sender, EventArgs e)
        {
            gameManager.RewindButton();

            Rewin.Text = (gameManager.frameManager.rewind) ? "<--" : "-->";
        }

        private void tmrUpdate_tick(object sender, EventArgs e)
        {
            gameManager.Update();
            gameManager.Draw();
            UpdateInfoDisplay();

        }
        private void hscSpeed_ValueChaned(object sender, EventArgs e)
        {
            tmrUpdate.Interval = SpeedBar.Value;
            SpeedValue.Text = $"{SpeedBar.Value} ms";

        }
        private void UpdateInfoDisplay()
        {


            cInfoLabel.Text = $" Cells Alive: {gameGrid.GetCellStateCount(Globals.Alive)} | Cells Dead: {gameGrid.GetCellStateCount(Globals.Dead)} | Total Cells: {(gameGrid.cols * gameGrid.rows)} ";
            int tempframe = gameManager.frameManager.frames.Count - 1;
            if (tempframe < 0)
            {
                tempframe = 0;
            }
            fInfoLabel.Text = $"Frame: {gameManager.frameManager.CurrentFrameIndex}/{tempframe}";



            OnFrame.Maximum = tempframe;





        }

        private void UpdateControlsDisplay()
        {
            EditorParentPanel.Enabled = !tmrUpdate.Enabled;
            NavPanel.Enabled = !tmrUpdate.Enabled;
            GamePanel.Enabled = !tmrUpdate.Enabled;
            Reset.Enabled = !tmrUpdate.Enabled;
        }

        private void minus_click(object sender, EventArgs e)
        {
            gameManager.frameManager.PrevFrame();
            gameManager.Draw();
            UpdateInfoDisplay();
        }

        private void plus_click(object sender, EventArgs e)
        {
            gameManager.frameManager.NextFrame();

            gameManager.Draw();
            UpdateInfoDisplay();
        }

        private void FramesToSkipRW_click(object sender, EventArgs e)
        {
            gameManager.frameManager.SkipToFrame(gameManager.frameManager.CurrentFrameIndex - (int)FramesToSkip.Value);
            gameManager.Draw();
            UpdateInfoDisplay();

        }

        private void FramesToSkipFF_click(object sender, EventArgs e)
        {
            gameManager.frameManager.SkipToFrame(gameManager.frameManager.CurrentFrameIndex + (int)FramesToSkip.Value);
            gameManager.Draw();
            UpdateInfoDisplay();

        }
        private void FramesToSkipRWX_click(object sender, EventArgs e)
        {
            gameManager.frameManager.SkipToFrame(gameManager.frameManager.CurrentFrameIndex - (((int)FramesToSkip.Value) * 3));
            gameManager.Draw();
            UpdateInfoDisplay();
        }

        private void FramesToSkipFFX_click(object sender, EventArgs e)
        {
            gameManager.frameManager.SkipToFrame(gameManager.frameManager.CurrentFrameIndex + (((int)FramesToSkip.Value) * 3));
            gameManager.Draw();
            UpdateInfoDisplay();
        }
        private void SkipToFirst_click(object sender, EventArgs e)
        {
            gameManager.frameManager.FirstFrame();
            gameManager.Draw();
            UpdateInfoDisplay();
        }
        private void SkipToLast_click(object sender, EventArgs e)
        {
            gameManager.frameManager.LastFrame();
            gameManager.Draw();
            UpdateInfoDisplay();
        }

        private void BrushSize_ValueChanged(object sender, EventArgs e)
        {
            editor.brushThickness = (int)BrushSizeValue.Value;
        }

        private void GotoFrame_click(object sender, EventArgs e)
        {
            gameManager.frameManager.SkipToFrame((int)OnFrame.Value);
            gameManager.Draw();
            UpdateInfoDisplay();
        }

        private void PasteEditor_click(Object sender, EventArgs e)
        {
            editor.copiedFrame = new Frames.Frame(editorGrid.GetStatesfromLabelsSlim(), editorGrid.pasteCols, editorGrid.pasteRows);
            editor.mode = EditorMode.editorMode.paste;
            PaintMode.Enabled = true;
            mode = "Copy/Paste";
            MInfoLabel.Text = $"Mode : {mode}";
            UpdateInfoDisplay();
        }
        private void PaintEditor_click(Object obj, EventArgs e)
        {
            editor.mode = EditorMode.editorMode.paint;
            PaintMode.Enabled = false;
            mode = "Paint";
            MInfoLabel.Text = $"Mode : {mode} | Brush: {brush}";
            UpdateInfoDisplay();
        }
        private void NewGrid_click(object sender, EventArgs e)
        {
            editorGrid.ChangeDimentions((int)editorX.Value, (int)editorY.Value);
            editor.AssignLabelEvent(editorGrid);
            UpdateInfoDisplay();
        }
        private void ClearEditor_click(object sender, EventArgs e)
        {
            editorGrid.Clear();
            UpdateInfoDisplay();
        }
        private void ClearGame_click(object sender, EventArgs e)
        {
            gameGrid.Clear();
            UpdateInfoDisplay();
        }
        private void ReverseEditor_click(Object sender, EventArgs e)
        {
            editorGrid.Reverse();
            UpdateInfoDisplay();
        }
        private void ReverseGame_click(Object sender, EventArgs e)
        {
            gameGrid.Reverse();
            UpdateInfoDisplay();
        }

        private void import_click(object sender, EventArgs e)
        {
            //TODO: import from editor to game ase New game with the editor Frame as the center 
            UpdateInfoDisplay();
        }
        private void InvertBrushbtn_Click(object sender, EventArgs e)
        {
            editor.brush = EditorMode.brushMode.Invert;
            InvertBrushbtn.Enabled = false;
            DeathBrushbtn.Enabled = true;
            LifeBrushbtn.Enabled = true;
            brush = "Invert";
            MInfoLabel.Text = $"Mode : {mode} | Brush: {brush}";
        }

        private void DeathBrushbtn_Click(object sender, EventArgs e)
        {
            editor.brush = EditorMode.brushMode.Death;
            InvertBrushbtn.Enabled = true;
            DeathBrushbtn.Enabled = false;
            LifeBrushbtn.Enabled = true;
            brush = "Death";
            MInfoLabel.Text = $"Mode : {mode} | Brush: {brush}";
        }

        private void LifeBrushbtn_Click(object sender, EventArgs e)
        {
            editor.brush = EditorMode.brushMode.Life;
            InvertBrushbtn.Enabled = true;
            DeathBrushbtn.Enabled = true;
            LifeBrushbtn.Enabled = false;
            brush = "Life";
            MInfoLabel.Text = $"Mode : {mode} | Brush: {brush}";
        }

        private void editorLinkDimentions_Click(object sender, EventArgs e)
        {
            editorLinkDimentionsCheck = !editorLinkDimentionsCheck;
            editorY.Value = editorX.Value;
        }

        private void gameLinkDimentions_Click(object sender, EventArgs e)
        {
            gameLinkDimentionsCheck = !gameLinkDimentionsCheck;
            gameY.Value = gameX.Value;
        }

        private void editorSetDimentions_Click(object sender, EventArgs e)
        {
            EditorPanel.Controls.Clear();
            editorGrid = new LabelGrid(EditorPanel, (int)editorX.Value, (int)editorY.Value, 10, 10, 1);
            editor = new EditorMode(gameGrid, editorGrid);
        }

        private void gameSetDimentions_Click(object sender, EventArgs e)
        {
            GamePanel.Controls.Clear();
            gameGrid = new LabelGrid(GamePanel, (int)gameX.Value, (int)gameY.Value, 10, 10, 1);
            editor = new EditorMode(gameGrid, editorGrid);
            gameManager = new GameManager(gameGrid);
        }
        private void editorX_change(object sender, EventArgs e)
        {
            if (editorLinkDimentionsCheck)
            {
                editorY.Value = editorX.Value;
            }
        }
        private void editorY_change(object sender, EventArgs e)
        {
            if (editorLinkDimentionsCheck)
            {
                editorX.Value = editorY.Value;
            }
        }
        private void gameX_change(object sender, EventArgs e)
        {
            if (gameLinkDimentionsCheck)
            {
                gameY.Value = gameX.Value;
            }
        }
        private void gameY_change(object sender, EventArgs e)
        {
            if (gameLinkDimentionsCheck)
            {
                gameX.Value = gameY.Value;
            }
        }
    }
}