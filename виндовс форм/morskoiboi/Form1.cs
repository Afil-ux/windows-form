using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morskoiboi
{
    public partial class Form1 : Form
    {
        private int[,] playerField = new int[10, 10];
        private int[,] computerField = new int[10, 10];
        private Random random = new Random();
        private bool gameStarted = false;
        private int playerShipsRemaining = 10;
        private int computerShipsRemaining = 10;
        private bool playerTurn = true;
        private int shipSizeToPlace = 0;
        private bool shipPlacementHorizontal = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGrid(playerGrid);
            InitializeGrid(computerGrid);
        }
        private void InitializeGrid(DataGridView grid)
        {
            grid.RowCount = 10;
            grid.ColumnCount = 10;
            for (int i = 0; i < 10; i++)
            {
                grid.Columns[i].Width = 30;
                grid.Rows[i].Height = 30;
            }
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grid.MultiSelect = false;
        }
        private void PlaceComputerShips()
        {
            int shipsToPlace = 10;
            while (shipsToPlace > 0)
            {
                int x = random.Next(0, 10);
                int y = random.Next(0, 10);
                if (computerField[x, y] == 0)

                    computerField[x, y] = 1;
                shipsToPlace--;
            }
        }

        private void oneDeckShipButton_Click(object sender, EventArgs e)
        {
            shipSizeToPlace = 1;
        }
        private void twoDeckShipButton_Click(object sender, EventArgs e)
        {
            shipSizeToPlace = 2;
        }

        private void threeDeckShipButton_Click(object sender, EventArgs e)
        {
            shipSizeToPlace = 3;
        }

        private void fourDeckShipButton_Click(object sender, EventArgs e)
        {
            shipSizeToPlace = 4;
        }


        private bool CanPlaceShip(int startX, int startY, int size, bool horizontal, int[,] field)
        {

            if (horizontal)
            {
                if (startX + size > 10) return false;
                for (int i = startX; i < startX + size; i++)
                    if (field[i, startY] != 0) return false;
            }
            else
            {
                if (startY + size > 10) return false;
                for (int i = startY; i < startY + size; i++)
                    if (field[startX, i] != 0) return false;
            }
            return true;
        }
        private void PlaceShip(int startX, int startY, int size, bool horizontal,
         int[,] field, DataGridView grid)
        {
            if (horizontal)
            {
                for (int i = startX; i < startX + size; i++)
                {
                    field[i, startY] = 1;
                    grid.Rows[startY].Cells[i].Style.BackColor = Color.Gray;
                }
            }
            else
            {
                for (int i = startY; i < startY + size; i++)
                {
                    field[startX, i] = 1;
                    grid.Rows[i].Cells[startX].Style.BackColor = Color.Gray;
                }
            }
        }

        private void playerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gameStarted) return;
            if (shipSizeToPlace == 0)
            {
                MessageBox.Show("Выберите размер корабля.");
                return;
            }
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            if (playerField[x, y] == 0)
            {
                if (CanPlaceShip(x, y, shipSizeToPlace, shipPlacementHorizontal,
                playerField))
                {
                    PlaceShip(x, y, shipSizeToPlace, shipPlacementHorizontal,
                    playerField, playerGrid);
                    shipSizeToPlace = 0;
                }
                else
                {
                    MessageBox.Show("Нельзя разместить корабль в этом месте.");
                }
            }
            else
            {
                MessageBox.Show("Здесь уже есть корабль.");
            }
        }
        private int CountShips(int[,] field)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (field[i, j] == 1) count++;
            if (CountShips(playerField) == 5)
                startButton.Enabled = true;
            else
                startButton.Enabled = false;
            return count;
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!gameStarted && CountShips(playerField) == 10)
            {
                computerField = new int[10, 10];
                computerShipsRemaining = 10;
                playerShipsRemaining = 10;
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        computerGrid.Rows[i].Cells[j].Style.BackColor =
                        Color.LightBlue;
                PlaceComputerShips();
                gameStarted = true;
                startButton.Enabled = false;
                playerTurn = true;
                MessageBox.Show("Игра началась! Ваш ход.");
            }
        }

        private void computerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gameStarted || !playerTurn) return;
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            if (computerField[x, y] == 1)
            {
                computerField[x, y] = 3;
                computerGrid.Rows[y].Cells[x].Style.BackColor = Color.Red;
                computerShipsRemaining--;
                if (computerShipsRemaining == 0)
                {
                    MessageBox.Show("Вы победили!");
                    EndGame();
                    return;
                }
                MessageBox.Show("Попадание! Ходите еще раз.");
            }
            else if (computerField[x, y] == 0)
            {
                computerField[x, y] = 2;
                computerGrid.Rows[y].Cells[x].Style.BackColor = Color.White;
                playerTurn = false;
                MessageBox.Show("Промах. Ход компьютера.");
                ComputerTurn();
            }
            else
            {
                MessageBox.Show("Вы уже стреляли в эту клетку.");
            }
        }
        private async void ComputerTurn()
        {
            await Task.Delay(1000);
            while (!playerTurn)
            {
                int x = random.Next(0, 10);
                int y = random.Next(0, 10);
                if (playerField[x, y] == 1)
                {
                    playerField[x, y] = 3;
                    playerGrid.Rows[y].Cells[x].Style.BackColor = Color.Red;
                    playerShipsRemaining--;
                    if (playerShipsRemaining == 0)
                    {
                        MessageBox.Show("Компьютер победил!");
                        EndGame();
                        return;
                    }
                    MessageBox.Show("Компьютер попал! Ходит еще раз.");
                }
                else if (playerField[x, y] == 0)
                {
                    playerField[x, y] = 2;
                    playerGrid.Rows[y].Cells[x].Style.BackColor = Color.White;
                    playerTurn = true;
                    MessageBox.Show("Компьютер промахнулся. Ваш ход.");
                }
            }
        }
        private void EndGame()
        {
            gameStarted = false;
            startButton.Enabled = true;
        }

    }

}

    
