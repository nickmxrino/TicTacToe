using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {

        }

        private void BoardCollection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayerScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopLeftField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TopLeftField.Text))
                TopLeftField.Text = "✘";
        }

        private void TopField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TopField.Text))
                TopField.Text = "✘";
        }

        private void TopRightField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TopRightField.Text))
                TopRightField.Text = "✘";
        }

        private void LeftField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LeftField.Text))
                LeftField.Text = "✘";
        }

        private void MiddleField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MiddleField.Text))
                MiddleField.Text = "✘";
        }

        private void RightField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RightField.Text))
                RightField.Text = "✘";
        }

        private void BottomLeftField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BottomLeftField.Text))
                BottomLeftField.Text = "✘";
        }

        private void BottomField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BottomField.Text))
                BottomField.Text = "✘";
        }

        private void BottomRightField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BottomRightField.Text))
                BottomRightField.Text = "✘";
        }
    }
}
