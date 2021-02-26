using System;
using System.Windows.Forms;
using Model;
using System.Drawing;

namespace GoL
{
    public partial class Form1 : Form
    {

        Board board;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        // unchecks other options of theme selection.
        private void lsThemes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && lsThemes.CheckedItems.Count > 0)
            {
                lsThemes.ItemCheck -= lsThemes_ItemCheck;
                lsThemes.SetItemChecked(lsThemes.CheckedIndices[0], false);
                lsThemes.ItemCheck += lsThemes_ItemCheck;
            }
        }

        private void lsThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        // reset conditionals
        private void cbGrid_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void nrSize_ValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void nrDensity_ValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset(bool randomize = true)
        {
            board = new Board(pictureBox1.Width, pictureBox1.Height, (int)nrSize.Value);
            if (randomize)
                board.Randomize((double)nrDensity.Value / 100);

            Render();
        }

        private void Reset(string startingPattern)
        {
            string[] lines = startingPattern.Split('\n');
            int yOffset = (board.Rows - lines.Length) / 2;
            int xOffset = (board.Columns - lines[0].Length) / 2;

            Reset(randomize: false);
            for (int y = 0; y < lines.Length; y++)
                for (int x = 0; x < lines[y].Length; x++)
                    board.Cells[x + xOffset, y + yOffset].isAlive = lines[y].Substring(x, 1) == "X";

            Render();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void nrDelay_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)nrDelay.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            board.Advance();
            Render();
        }

        private void Render()
        {
            using (var bmp = new Bitmap(board.Width, board.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var brush = new SolidBrush(Color.Orange))
            {
                gfx.Clear(ColorTranslator.FromHtml("#2f3539"));

                var cellSize = (cbGrid.Checked && board.CellSize > 1) ?
                                new Size(board.CellSize - 1, board.CellSize - 1) :
                                new Size(board.CellSize, board.CellSize);

                for (int col = 0; col < board.Columns; col++)
                    for (int row = 0; row < board.Rows; row++)
                    {
                        var cell = board.Cells[col, row];
                        if (cell.isAlive)
                        {
                            var cellLocation = new Point(col * board.CellSize, row * board.CellSize);
                            var cellRect = new Rectangle(cellLocation, cellSize);
                            gfx.FillRectangle(brush, cellRect);
                        }
                    }

                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }
        }

        private void btnGlider_Click(object sender, EventArgs e)
        {
            string startingPattern = "-X-\n" +
                                     "--x\n" +
                                     "xxx";

            Reset(startingPattern);
        }

        private void btnRow_Click(object sender, EventArgs e)
        {
            string complexRow =
                "XXXXXXXX-XXXXX---XXX------XXXXXXX-XXXXX\n";

            Reset(complexRow);
        }

        private void btnGliderGun_Click(object sender, EventArgs e)
        {
            string gliderGun =
                "-------------------------X----------\n" +
                "----------------------XXXX----X-----\n" +
                "-------------X-------XXXX-----X-----\n" +
                "------------X-X------X--X---------XX\n" +
                "-----------X---XX----XXXX---------XX\n" +
                "XX---------X---XX-----XXXX----------\n" +
                "XX---------X---XX--------X----------\n" +
                "------------X-X---------------------\n" +
                "-------------X----------------------";

            Reset(gliderGun);
        }
    }
}
