using Caro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public class QuanlyCaro
    {

        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<NguoiChoi> nguoichoi;
        public List<NguoiChoi> NguoiChoi
        {
            get { return nguoichoi; }
            set { nguoichoi = value; }
        }

        private int nguoidangchoi;
        public int Nguoidangchoi
        {
            get { return nguoidangchoi; }
            set { nguoidangchoi = value; }
        }

        private TextBox tennguoichoi;
        public TextBox Tennguoichoi
        {
            get { return tennguoichoi; }
            set { tennguoichoi = value; }
        }

        private PictureBox playerMark;
        public PictureBox PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value; }
        }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked += value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame += value;
            }
        }

        private Stack<ThongTin> playTimeLine;
        public Stack<ThongTin> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value; }
        }
        #endregion

        #region Initialize
        public QuanlyCaro(Panel chessBoard, TextBox tennguoichoi, PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.Tennguoichoi = tennguoichoi;
            this.PlayerMark = mark;
            this.NguoiChoi = new List<NguoiChoi>()
            {
                new NguoiChoi("Người chơi 1", Image.FromFile(Application.StartupPath + "\\Resources\\x.png")),
                new NguoiChoi("Người chơi 2", Image.FromFile(Application.StartupPath + "\\Resources\\o.png"))
            };
           
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();
            PlayTimeLine = new Stack<ThongTin>();
            Nguoidangchoi = 0;
            DoiNguoiChoi();

            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.Chess_board_height; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.Chess_board_width; j++)
                {

                    Button btn = new Button()
                    {
                        Width = Cons.Chess_width,
                        Height = Cons.Chess_height,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;

                    ChessBoard.Controls.Add(btn);
                    oldButton = btn;
                    Matrix[i].Add(btn);
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.Chess_height);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new ThongTin(GetChessPoint(btn), Nguoidangchoi));
            DoiNguoiChoi();

            if (playerMarked != null)
                playerMarked(this, new EventArgs());

            if (IsEndGame(btn))
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());          
        }

        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0)
            {
                Nguoidangchoi = 0;
            }
            else
            {
                ThongTin oldPoint = PlayTimeLine.Pop();
                Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
                btn.BackgroundImage = null;

                Nguoidangchoi = oldPoint.Nguoidangchoi == 1 ? 0 :1;
            }
            DoiNguoiChoi();
            return true;
        }
        private bool IsEndGame(Button btn)
        {
            return IsHangNgang(btn) || IsHangDoc(btn) || IsCheoChinh(btn) || IsCheoPhu(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int doc = Convert.ToInt32(btn.Tag);
            int ngang = Matrix[doc].IndexOf(btn);

            Point point = new Point(ngang, doc);
            return point;
        }
        private bool IsHangNgang(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.Chess_board_width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }
        private bool IsHangDoc(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.Chess_board_height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        private bool IsCheoChinh(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.Chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cons.Chess_board_height || point.X + i >= Cons.Chess_board_width)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;

        }
        private bool IsCheoPhu(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.Chess_board_width || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.Chess_board_width - point.X; i++)
            {
                if (point.Y + i >= Cons.Chess_board_height || point.X - i <0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = NguoiChoi[Nguoidangchoi].Mark;
            Nguoidangchoi = Nguoidangchoi == 0 ? 1 : 0;
        }

        private void DoiNguoiChoi()
        {
            Tennguoichoi.Text = NguoiChoi[Nguoidangchoi].Name;
            PlayerMark.Image = NguoiChoi[Nguoidangchoi].Mark;
        }
        #endregion
    }
}



