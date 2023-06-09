using Game_of_Life.Editor;
using Game_of_Life.Stucts;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        GameManager gameManager;
        EditorMode editor;
        LabelGrid gameGrid;
        LabelGrid editorGrid;


        public Form1()
        {
            InitializeComponent();
            gameGrid = new LabelGrid(GamePanel, 5, 5, 35, 35, 1);
            editorGrid = new LabelGrid(EditorPanel, 4, 4, 10, 10, 1);
            gameManager = new GameManager(gameGrid);
            editor = new EditorMode(gameGrid, editorGrid);

            tmrUpdate.Interval = SpeedBar.Value;

            UpdateInfoDisplay();
            UpdateControlsDisplay();

            SpeedValue.Text = $"{SpeedBar.Value} ms";

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
            int currentFrameNb = gameManager.frameManager.CurrentFrameIndex + 1;
            int nbFrames = gameManager.frameManager.NbFrames;

            // Todo: add footer InfoLable named --> FrameNum displaying --> $"Frame: {crrentFrameNb}/{nbFrames}"

            int nbAliveCells = 0;
            foreach (bool state in gameGrid.GetStatesfromLabels())
            {
                if (state) nbAliveCells++;

            }
            int nbCells = gameGrid.labels.Count;
            int nbDeadCells = nbCells - nbAliveCells;

            // Todo: add footer InfoLable named --> CellInfo displaying --> $"Live Cells: {nbAliveCells} | Dead Cells: {nbDeadCells} | Total Cells: {nbCells}"

            string mode = editor.mode.ToString();

            // Todo: add footer InfoLable named --> ModeState displaying --> $"Mode: {mode}"


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
            gameManager.frameManager.SkipToFrame((int)0/*Pull value From property*/);
            gameManager.Draw();
            UpdateInfoDisplay();
        }

        private void CopyEditor_click(object sender, EventArgs e)
        {
            editor.copiedFrame = new Frames.Frame(editorGrid.GetStatesfromLabels(), editorGrid.cols, editorGrid.rows);
            UpdateInfoDisplay();

        }
        private void PasteEditor_click(Object sender, EventArgs e)
        {
            editor.mode = EditorMode.editorMode.paste;
            UpdateInfoDisplay();
        }
        private void PaintEditor_click(Object obj, EventArgs e)
        {
            editor.mode = EditorMode.editorMode.paint;
            UpdateInfoDisplay();
        }
        private void NewGrid_click(object sender, EventArgs e)
        {
            editorGrid.ChangeDimentions((int)EditorX.Value, (int)EditorY.Value);
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

        private void Paint_click(Object obj, EventArgs e)
        {
            editor.mode = EditorMode.editorMode.paint;
            UpdateInfoDisplay();
        }


    }
}