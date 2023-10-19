
namespace WinForm
{
    partial class MusicForm
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
            this.dgv_Music = new System.Windows.Forms.DataGridView();
            this.tb_LikesInput = new System.Windows.Forms.TextBox();
            this.tb_DislikesInput = new System.Windows.Forms.TextBox();
            this.tb_AlbumInput = new System.Windows.Forms.TextBox();
            this.tb_IdInput = new System.Windows.Forms.TextBox();
            this.tb_NameInput = new System.Windows.Forms.TextBox();
            this.tb_ArtistInput = new System.Windows.Forms.TextBox();
            this.cb_GenreInput = new System.Windows.Forms.ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Dislikes = new System.Windows.Forms.Label();
            this.lbl_Likes = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Album = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Music)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Music
            // 
            this.dgv_Music.AllowUserToAddRows = false;
            this.dgv_Music.AllowUserToDeleteRows = false;
            this.dgv_Music.AllowUserToResizeColumns = false;
            this.dgv_Music.AllowUserToResizeRows = false;
            this.dgv_Music.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Music.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Music.Location = new System.Drawing.Point(12, 12);
            this.dgv_Music.MultiSelect = false;
            this.dgv_Music.Name = "dgv_Music";
            this.dgv_Music.ReadOnly = true;
            this.dgv_Music.RowHeadersVisible = false;
            this.dgv_Music.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Music.Size = new System.Drawing.Size(861, 280);
            this.dgv_Music.TabIndex = 13;
            this.dgv_Music.Click += new System.EventHandler(this.dgv_Music_Click);
            // 
            // tb_LikesInput
            // 
            this.tb_LikesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_LikesInput.Location = new System.Drawing.Point(596, 335);
            this.tb_LikesInput.Name = "tb_LikesInput";
            this.tb_LikesInput.Size = new System.Drawing.Size(140, 26);
            this.tb_LikesInput.TabIndex = 4;
            this.tb_LikesInput.TextChanged += new System.EventHandler(this.tb_LikesInput_TextChanged);
            // 
            // tb_DislikesInput
            // 
            this.tb_DislikesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_DislikesInput.Location = new System.Drawing.Point(742, 335);
            this.tb_DislikesInput.Name = "tb_DislikesInput";
            this.tb_DislikesInput.Size = new System.Drawing.Size(140, 26);
            this.tb_DislikesInput.TabIndex = 5;
            this.tb_DislikesInput.TextChanged += new System.EventHandler(this.tb_DislikesInput_TextChanged);
            // 
            // tb_AlbumInput
            // 
            this.tb_AlbumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_AlbumInput.Location = new System.Drawing.Point(304, 335);
            this.tb_AlbumInput.Name = "tb_AlbumInput";
            this.tb_AlbumInput.Size = new System.Drawing.Size(140, 26);
            this.tb_AlbumInput.TabIndex = 2;
            // 
            // tb_IdInput
            // 
            this.tb_IdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_IdInput.Location = new System.Drawing.Point(12, 433);
            this.tb_IdInput.Name = "tb_IdInput";
            this.tb_IdInput.Size = new System.Drawing.Size(140, 26);
            this.tb_IdInput.TabIndex = 6;
            this.tb_IdInput.TextChanged += new System.EventHandler(this.tb_IdInput_TextChanged);
            // 
            // tb_NameInput
            // 
            this.tb_NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_NameInput.Location = new System.Drawing.Point(12, 335);
            this.tb_NameInput.Name = "tb_NameInput";
            this.tb_NameInput.Size = new System.Drawing.Size(140, 26);
            this.tb_NameInput.TabIndex = 0;
            // 
            // tb_ArtistInput
            // 
            this.tb_ArtistInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ArtistInput.Location = new System.Drawing.Point(158, 335);
            this.tb_ArtistInput.Name = "tb_ArtistInput";
            this.tb_ArtistInput.Size = new System.Drawing.Size(140, 26);
            this.tb_ArtistInput.TabIndex = 1;
            // 
            // cb_GenreInput
            // 
            this.cb_GenreInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_GenreInput.FormattingEnabled = true;
            this.cb_GenreInput.Location = new System.Drawing.Point(450, 335);
            this.cb_GenreInput.Name = "cb_GenreInput";
            this.cb_GenreInput.Size = new System.Drawing.Size(140, 28);
            this.cb_GenreInput.TabIndex = 3;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Name.Location = new System.Drawing.Point(8, 299);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(67, 20);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name*:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Id.Location = new System.Drawing.Point(8, 398);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(33, 20);
            this.lbl_Id.TabIndex = 12;
            this.lbl_Id.Text = "ID:";
            // 
            // lbl_Dislikes
            // 
            this.lbl_Dislikes.AutoSize = true;
            this.lbl_Dislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Dislikes.Location = new System.Drawing.Point(738, 299);
            this.lbl_Dislikes.Name = "lbl_Dislikes";
            this.lbl_Dislikes.Size = new System.Drawing.Size(67, 20);
            this.lbl_Dislikes.TabIndex = 13;
            this.lbl_Dislikes.Text = "Dislikes:";
            // 
            // lbl_Likes
            // 
            this.lbl_Likes.AutoSize = true;
            this.lbl_Likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Likes.Location = new System.Drawing.Point(592, 299);
            this.lbl_Likes.Name = "lbl_Likes";
            this.lbl_Likes.Size = new System.Drawing.Size(50, 20);
            this.lbl_Likes.TabIndex = 14;
            this.lbl_Likes.Text = "Likes:";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Genre.Location = new System.Drawing.Point(446, 299);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(71, 20);
            this.lbl_Genre.TabIndex = 15;
            this.lbl_Genre.Text = "Genre*:";
            // 
            // lbl_Album
            // 
            this.lbl_Album.AutoSize = true;
            this.lbl_Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Album.Location = new System.Drawing.Point(300, 299);
            this.lbl_Album.Name = "lbl_Album";
            this.lbl_Album.Size = new System.Drawing.Size(71, 20);
            this.lbl_Album.TabIndex = 16;
            this.lbl_Album.Text = "Album*:";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Artist.Location = new System.Drawing.Point(154, 299);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(64, 20);
            this.lbl_Artist.TabIndex = 17;
            this.lbl_Artist.Text = "Artist*:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(742, 392);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 34);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(596, 392);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(140, 34);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 482);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(140, 34);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(596, 510);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(286, 32);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(231, 510);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(286, 32);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear Inputs";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.Location = new System.Drawing.Point(596, 450);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(286, 34);
            this.btn_DeleteAll.TabIndex = 9;
            this.btn_DeleteAll.Text = "Delete All";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(231, 450);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(286, 32);
            this.btn_Refresh.TabIndex = 18;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 539);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_Album);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Likes);
            this.Controls.Add(this.lbl_Dislikes);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cb_GenreInput);
            this.Controls.Add(this.tb_ArtistInput);
            this.Controls.Add(this.tb_NameInput);
            this.Controls.Add(this.tb_IdInput);
            this.Controls.Add(this.tb_AlbumInput);
            this.Controls.Add(this.tb_DislikesInput);
            this.Controls.Add(this.tb_LikesInput);
            this.Controls.Add(this.dgv_Music);
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Music)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Music;
        private System.Windows.Forms.TextBox tb_LikesInput;
        private System.Windows.Forms.TextBox tb_DislikesInput;
        private System.Windows.Forms.TextBox tb_AlbumInput;
        private System.Windows.Forms.TextBox tb_IdInput;
        private System.Windows.Forms.TextBox tb_NameInput;
        private System.Windows.Forms.TextBox tb_ArtistInput;
        private System.Windows.Forms.ComboBox cb_GenreInput;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Dislikes;
        private System.Windows.Forms.Label lbl_Likes;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Album;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_DeleteAll;
        private System.Windows.Forms.Button btn_Refresh;
    }
}