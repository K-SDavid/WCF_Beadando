using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.MusicService;

namespace WinForm
{
    public partial class MusicForm : Form
    {
        string guid;
        Service1Client client;

        public MusicForm(string guid, Service1Client client)
        {
            this.guid = guid;
            this.client = client;

            InitializeComponent();
            InitializeDgv();
            InitializeCB();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InitializeDgv()
        {
            dgv_Music.Columns.Clear();
            dgv_Music.AutoGenerateColumns = false;
            dgv_Music.Columns.Add("Id", "Id");
            dgv_Music.Columns.Add("Name", "Name");
            dgv_Music.Columns.Add("Artist", "Artist");
            dgv_Music.Columns.Add("Album", "Album");
            dgv_Music.Columns.Add("Genre", "Genre");
            dgv_Music.Columns.Add("Likes", "Likes");
            dgv_Music.Columns.Add("Dislikes", "Dislikes");

            GetList();
        }

        private void InitializeCB()
        {
            cb_GenreInput.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_GenreInput.AutoCompleteSource = AutoCompleteSource.ListItems;
            for (int i = 0; i < Enum.GetNames(typeof(Genres)).Length; i++)
                cb_GenreInput.Items.Add(((Genres)i).ToString());
            cb_GenreInput.SelectedIndex = 0;
        }

        private void GetList()
        {
            try
            {
                dgv_Music.Rows.Clear();
                Music[] musics = client.ListMusic();

                foreach (Music m in musics)
                {
                    dgv_Music.Rows.Add(
                        m.Id,
                        m.Name,
                        m.Artist,
                        m.Album,
                        m.Genre,
                        m.Likes,
                        m.Dislikes);
                }
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show(Fex.Detail.ErrorMessage, "LIST", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LIST", MessageBoxButtons.OK);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                if (guid != null)
                {
                    LoginForm f1 = new LoginForm();
                    client.Logout(guid);
                    guid = null;
                    f1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hiba a kijelentkezés során!", "LOGOUT", MessageBoxButtons.OK);
                }
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show(Fex.Detail.ErrorMessage, "LOGOUT", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOGOUT", MessageBoxButtons.OK);
            }
        }

        private void ClearInputs()
        {
            tb_NameInput.Text = "";
            tb_ArtistInput.Text = "";
            tb_AlbumInput.Text = "";
            cb_GenreInput.SelectedIndex = 0;
            tb_LikesInput.Text = "";
            tb_DislikesInput.Text = "";
            tb_IdInput.Text = "";
            dgv_Music.ClearSelection();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_LikesInput.Text == "")
                    tb_LikesInput.Text = "0";
                if (tb_DislikesInput.Text == "")
                    tb_DislikesInput.Text = "0";
                string temp = client.AddMusic(tb_NameInput.Text.ToString(), tb_ArtistInput.Text.ToString(),
                tb_AlbumInput.Text.ToString(), (Genres)Enum.Parse(typeof(Genres), cb_GenreInput.SelectedItem.ToString()),
                int.Parse(tb_LikesInput.Text), int.Parse(tb_DislikesInput.Text), guid);
                if ("OK" == temp)
                {
                    ClearInputs();
                    MessageBox.Show("Sikeresen hozzáadtuk az adatbázishoz!", "INSERT", MessageBoxButtons.OK);
                }
                else MessageBox.Show(temp, "INSERT", MessageBoxButtons.OK);
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show(Fex.Detail.ErrorMessage, "INSERT", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "INSERT", MessageBoxButtons.OK);
            }
            GetList();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = client.DeleteMusic(int.Parse(tb_IdInput.Text), guid);
                if (temp == "OK")
                {
                    ClearInputs();
                    MessageBox.Show("Adat sikeresen törölve!", "DELETE", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(temp, "DELETE", MessageBoxButtons.OK);
                }
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show(Fex.Detail.ErrorMessage, "DELETE", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DELETE", MessageBoxButtons.OK);
            }
            GetList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_LikesInput.Text == "")
                    tb_LikesInput.Text = "0";
                if (tb_DislikesInput.Text == "")
                    tb_DislikesInput.Text = "0";
                if (tb_IdInput.Text == "")
                    tb_IdInput.Text = "0";
                string temp = client.UpdateMusic(int.Parse(tb_IdInput.Text), tb_NameInput.Text.ToString(), tb_ArtistInput.Text.ToString(),
                tb_AlbumInput.Text.ToString(), (Genres)Enum.Parse(typeof(Genres), cb_GenreInput.SelectedItem.ToString()),
                int.Parse(tb_LikesInput.Text), int.Parse(tb_DislikesInput.Text), guid);

                if ("OK" == temp)
                {
                    ClearInputs();
                    MessageBox.Show("Sikeresen módosítottuk az elemet az adatbázisban!", "UPDATE", MessageBoxButtons.OK);
                }
                else MessageBox.Show(temp, "UPDATE", MessageBoxButtons.OK);
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show(Fex.Detail.ErrorMessage, "UPDATE", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UPDATE", MessageBoxButtons.OK);
            }
            GetList();
        }

        private void dgv_Music_Click(object sender, EventArgs e)
        {
            tb_NameInput.Text = dgv_Music.CurrentRow.Cells["Name"].Value.ToString();
            tb_ArtistInput.Text = dgv_Music.CurrentRow.Cells["Artist"].Value.ToString();
            tb_AlbumInput.Text = dgv_Music.CurrentRow.Cells["Album"].Value.ToString();
            cb_GenreInput.SelectedItem = dgv_Music.CurrentRow.Cells["Genre"].Value.ToString();
            tb_LikesInput.Text = dgv_Music.CurrentRow.Cells["Likes"].Value.ToString();
            tb_DislikesInput.Text = dgv_Music.CurrentRow.Cells["Dislikes"].Value.ToString();
            tb_IdInput.Text = dgv_Music.CurrentRow.Cells["Id"].Value.ToString();
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = client.DeleteAllMusic(guid);
                if (temp == "OK")
                {
                    ClearInputs();
                    MessageBox.Show("Minden adat sikeresen törölve!", "DELETE", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(temp, "DELETE", MessageBoxButtons.OK);
                }
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show(Fex.Detail.ErrorMessage, "DELETE", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DELETE", MessageBoxButtons.OK);
            }
            GetList();
        }

        private void tb_IdInput_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(tb_IdInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számot adjon meg!");
                tb_IdInput.Text = tb_IdInput.Text.Remove(tb_IdInput.Text.Length - 1);
            }
        }

        private void tb_LikesInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_LikesInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számot adjon meg!");
                tb_LikesInput.Text = tb_LikesInput.Text.Remove(tb_LikesInput.Text.Length - 1);
            }
        }

        private void tb_DislikesInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_DislikesInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Csak számot adjon meg!");
                tb_DislikesInput.Text = tb_DislikesInput.Text.Remove(tb_DislikesInput.Text.Length - 1);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
