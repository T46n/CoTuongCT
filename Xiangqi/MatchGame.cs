using System.Windows.Forms;
using static Xiangqi.ChessTable;
using static Xiangqi.GameManager;

namespace Xiangqi
{
    public partial class MatchGame : Form
    {
        private bool isClicked = false;

        private GameManager manager;

        public Rectangle chessLocation;

        public readonly Bitmap banCo = new Bitmap(Xiangqi.Properties.Resources.JanggiBrown);

        private ChessTable chessTable;
        public MatchGame()
        {
            InitializeComponent();

            chessLocation.Width = 451;
            chessLocation.Height = 501;
            chessLocation.Location = new Point(225, 50);

            manager = new GameManager(this);
            chessTable = new ChessTable();
            chessTable.CreateTable();

            label3.Text = isClicked.ToString();
        }

        private void MatchGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(banCo, chessLocation);
            manager.PlaceDefaultChessItems(e);
        }

        private void testRestart_Click(object sender, EventArgs e)
        {
            chessTable.CreateTable();
            Invalidate();
        }

        private void MatchGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int[,] result;
                result = chessTable.CellIsClicked(e);
                if (result[0, 0] == -1)
                {
                    isClicked = false;
                    label3.Text = isClicked.ToString();
                    label4.Text = "Canceled";
                    return;
                }
                else
                {
                    label1.Text = ("You clicked on grid (" + result[0, 1] + ", " + result[0, 0] + ").");
                    if (manager.CheckAvailable(result[0, 1], result[0, 0]) == true)
                    {
                        label2.Text = "Available";
                    }
                    else label2.Text = "NOT Available";
                    chessTable.UpdateCellPosition(label4, result[0, 1], result[0, 0]);
                    isClicked = true;
                    label3.Text = isClicked.ToString();
                }
            } else if(e.Button == MouseButtons.Right)
            {
                isClicked = false;
                label3.Text = isClicked.ToString();
                label4.Text = "Canceled";
            }
        }
    }
}
