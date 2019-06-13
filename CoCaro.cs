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
    public partial class CoCaro : Form
    {
        #region
        QuanlyCaro ChessBoard;
        #endregion
        public CoCaro()
        {
            InitializeComponent();

            ChessBoard = new QuanlyCaro(pnlChessBoard,txtTennguoichoi,ptbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prsTimeDown.Step = Cons.TimeDownStep;
            prsTimeDown.Maximum = Cons.TimeDown;
            prsTimeDown.Value = 0;

            timerTimeDown.Interval = Cons.TimeDownInterval;
            NewGame();
            
        }

        #region
        void EndGame()
        {
            timerTimeDown.Stop();
            pnlChessBoard.Enabled = false;
            btDanhLai.Enabled = false;
            MessageBox.Show("Kết thúc ván cờ!!!");
        }

        void NewGame ()
        {
            timerTimeDown.Stop();
            prsTimeDown.Value = 0;
            btDanhLai.Enabled = true;
            ChessBoard.DrawChessBoard();
            

        }
        void Quit ()
        {
              Application.Exit();
        }

        void Undo()
        {
            ChessBoard.Undo();
            prsTimeDown.Value = 0;
        }
        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timerTimeDown.Start();
            prsTimeDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void timerTimeDown_Tick(object sender, EventArgs e)
        {
            prsTimeDown.PerformStep();

            if(prsTimeDown.Value >= prsTimeDown.Maximum)
            {
                EndGame();               
            }
        }

        private void btVanmoi_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btDanhLai_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void CoCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát game?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
               e.Cancel = true;
        }
        #endregion

        private void CoCaro_Load(object sender, EventArgs e)
        {

        }
    }
}
