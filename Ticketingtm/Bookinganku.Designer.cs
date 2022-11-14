
namespace Ticketingtm
{
    partial class Bookinganku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.kode_film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seat_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_tayang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_seat = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_seat_2 = new System.Windows.Forms.TextBox();
            this.txt_waktu_tayang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_film,
            this.seat_book,
            this.waktu_tayang,
            this.username});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(12, 114);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(554, 273);
            this.dataGridView.TabIndex = 42;
            // 
            // kode_film
            // 
            this.kode_film.DataPropertyName = "kode_film";
            this.kode_film.HeaderText = "Kode Film";
            this.kode_film.MinimumWidth = 6;
            this.kode_film.Name = "kode_film";
            this.kode_film.ReadOnly = true;
            this.kode_film.Width = 125;
            // 
            // seat_book
            // 
            this.seat_book.DataPropertyName = "seat_book";
            this.seat_book.HeaderText = "Seat";
            this.seat_book.MinimumWidth = 6;
            this.seat_book.Name = "seat_book";
            this.seat_book.Width = 125;
            // 
            // waktu_tayang
            // 
            this.waktu_tayang.DataPropertyName = "waktu_tayang";
            this.waktu_tayang.HeaderText = "Waktu Tayang";
            this.waktu_tayang.MinimumWidth = 6;
            this.waktu_tayang.Name = "waktu_tayang";
            this.waktu_tayang.Width = 125;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 446);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 47);
            this.button6.TabIndex = 40;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(12, 73);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 35);
            this.button8.TabIndex = 43;
            this.button8.Text = "Lihat Data Booking";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(634, 393);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(151, 35);
            this.button9.TabIndex = 44;
            this.button9.Text = "Update Data";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(634, 114);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(151, 35);
            this.button10.TabIndex = 45;
            this.button10.Text = "Hapus Data";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(169, 34);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(245, 27);
            this.txt_user.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Masukkan Username :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 47);
            this.button1.TabIndex = 48;
            this.button1.Text = "Back To Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 40);
            this.label2.TabIndex = 49;
            this.label2.Text = "Untuk Menghapus Data Masukkan \r\nkode film anda :";
            // 
            // txt_seat
            // 
            this.txt_seat.Location = new System.Drawing.Point(588, 77);
            this.txt_seat.Name = "txt_seat";
            this.txt_seat.Size = new System.Drawing.Size(245, 27);
            this.txt_seat.TabIndex = 50;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(588, 200);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(245, 27);
            this.txt_code.TabIndex = 51;
            // 
            // txt_seat_2
            // 
            this.txt_seat_2.Location = new System.Drawing.Point(588, 269);
            this.txt_seat_2.Name = "txt_seat_2";
            this.txt_seat_2.Size = new System.Drawing.Size(245, 27);
            this.txt_seat_2.TabIndex = 52;
            // 
            // txt_waktu_tayang
            // 
            this.txt_waktu_tayang.Location = new System.Drawing.Point(588, 341);
            this.txt_waktu_tayang.Name = "txt_waktu_tayang";
            this.txt_waktu_tayang.Size = new System.Drawing.Size(245, 27);
            this.txt_waktu_tayang.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Kode Film Edit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Seat Edit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Waktu Tayang Edit :";
            // 
            // Bookinganku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_waktu_tayang);
            this.Controls.Add(this.txt_seat_2);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_seat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Name = "Bookinganku";
            this.Text = "Bookinganku";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_film;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_tayang;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_seat;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_seat_2;
        private System.Windows.Forms.TextBox txt_waktu_tayang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}