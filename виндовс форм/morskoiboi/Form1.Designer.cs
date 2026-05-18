
namespace morskoiboi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerGrid = new System.Windows.Forms.DataGridView();
            this.computerGrid = new System.Windows.Forms.DataGridView();
            this.startButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.oneDeckShipButton = new System.Windows.Forms.Button();
            this.twoDeckShipButton = new System.Windows.Forms.Button();
            this.threeDeckShipButton = new System.Windows.Forms.Button();
            this.fourDeckShipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // playerGrid
            // 
            this.playerGrid.AllowUserToAddRows = false;
            this.playerGrid.AllowUserToDeleteRows = false;
            this.playerGrid.AllowUserToResizeColumns = false;
            this.playerGrid.AllowUserToResizeRows = false;
            this.playerGrid.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGrid.Location = new System.Drawing.Point(-6, 70);
            this.playerGrid.MultiSelect = false;
            this.playerGrid.Name = "playerGrid";
            this.playerGrid.RowHeadersVisible = false;
            this.playerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.playerGrid.Size = new System.Drawing.Size(240, 150);
            this.playerGrid.TabIndex = 0;
            this.playerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerGrid_CellContentClick);
            // 
            // computerGrid
            // 
            this.computerGrid.AllowUserToAddRows = false;
            this.computerGrid.AllowUserToDeleteRows = false;
            this.computerGrid.AllowUserToResizeColumns = false;
            this.computerGrid.AllowUserToResizeRows = false;
            this.computerGrid.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.computerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerGrid.ColumnHeadersVisible = false;
            this.computerGrid.Location = new System.Drawing.Point(562, 70);
            this.computerGrid.Name = "computerGrid";
            this.computerGrid.RowHeadersVisible = false;
            this.computerGrid.Size = new System.Drawing.Size(240, 150);
            this.computerGrid.TabIndex = 1;
            this.computerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.computerGrid_CellContentClick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(324, 314);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(356, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 25);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "label1";
            // 
            // oneDeckShipButton
            // 
            this.oneDeckShipButton.Location = new System.Drawing.Point(13, 313);
            this.oneDeckShipButton.Name = "oneDeckShipButton";
            this.oneDeckShipButton.Size = new System.Drawing.Size(75, 23);
            this.oneDeckShipButton.TabIndex = 4;
            this.oneDeckShipButton.Text = "1";
            this.oneDeckShipButton.UseVisualStyleBackColor = true;
            this.oneDeckShipButton.Click += new System.EventHandler(this.oneDeckShipButton_Click);
            // 
            // twoDeckShipButton
            // 
            this.twoDeckShipButton.Location = new System.Drawing.Point(167, 313);
            this.twoDeckShipButton.Name = "twoDeckShipButton";
            this.twoDeckShipButton.Size = new System.Drawing.Size(75, 23);
            this.twoDeckShipButton.TabIndex = 5;
            this.twoDeckShipButton.Text = "2";
            this.twoDeckShipButton.UseVisualStyleBackColor = true;
            this.twoDeckShipButton.Click += new System.EventHandler(this.twoDeckShipButton_Click);
            // 
            // threeDeckShipButton
            // 
            this.threeDeckShipButton.Location = new System.Drawing.Point(13, 385);
            this.threeDeckShipButton.Name = "threeDeckShipButton";
            this.threeDeckShipButton.Size = new System.Drawing.Size(75, 23);
            this.threeDeckShipButton.TabIndex = 6;
            this.threeDeckShipButton.Text = "3";
            this.threeDeckShipButton.UseVisualStyleBackColor = true;
            this.threeDeckShipButton.Click += new System.EventHandler(this.threeDeckShipButton_Click);
            // 
            // fourDeckShipButton
            // 
            this.fourDeckShipButton.Location = new System.Drawing.Point(167, 384);
            this.fourDeckShipButton.Name = "fourDeckShipButton";
            this.fourDeckShipButton.Size = new System.Drawing.Size(75, 23);
            this.fourDeckShipButton.TabIndex = 7;
            this.fourDeckShipButton.Text = "4";
            this.fourDeckShipButton.UseVisualStyleBackColor = true;
            this.fourDeckShipButton.Click += new System.EventHandler(this.fourDeckShipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fourDeckShipButton);
            this.Controls.Add(this.threeDeckShipButton);
            this.Controls.Add(this.twoDeckShipButton);
            this.Controls.Add(this.oneDeckShipButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.computerGrid);
            this.Controls.Add(this.playerGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playerGrid;
        private System.Windows.Forms.DataGridView computerGrid;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button oneDeckShipButton;
        private System.Windows.Forms.Button twoDeckShipButton;
        private System.Windows.Forms.Button threeDeckShipButton;
        private System.Windows.Forms.Button fourDeckShipButton;
    }
}

