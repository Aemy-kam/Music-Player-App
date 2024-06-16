using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Elie Hacen\\Desktop\\music-playee\\MusicPlayerApp\\Database1.mdf\";Integrated Security=True");

        private string[] files;
        private string[] paths;


        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MusicPlayerApp()
        {
            InitializeComponent();
            ApplyCustomStyles();
            displaySavedAudioFiles();


            // Event handlers for moving the form
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to Select Songs
            OpenFileDialog ofd = new OpenFileDialog();
            // Code to select multiple files
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Save the names of the track in files array
                paths = ofd.FileNames; // Save the paths of the tracks in path array
                                       // Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // Display Songs in Listbox
                }

            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // code to play music
            if (listBoxSongs.SelectedIndex != -1 && paths != null && listBoxSongs.SelectedIndex < paths.Length)
            {
                axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
            }
        }

        private void fav_btn_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex != -1 && listBoxSongs.SelectedIndex < paths.Length)
            {
                string selectedPath = paths[listBoxSongs.SelectedIndex];

                string selectedSong = System.IO.Path.GetFileName(selectedPath);
                fav_box.Items.Add(selectedSong);
                saveToFavorites(selectedSong, selectedPath);
            }
            else
            {
                MessageBox.Show("Please select a valid song first.");
            }

        }

        private void fav_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fav_box.SelectedIndex != -1)
            {
                string selectedSong = fav_box.SelectedItem.ToString();
                playFavoriteSong(selectedSong);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code to Close the App
            this.Close();
        }

        private void saveToFavorites(string songName, string fullPath)
        {
            conn.Open();

            string query = "INSERT INTO AudioFiles(FileName, FileData, MIMEType) VALUES (@fileName, @fileData, @MIMEType)";
            SqlCommand cmd = new SqlCommand(query, conn);

            byte[] fileData = System.IO.File.ReadAllBytes(fullPath);

            cmd.Parameters.AddWithValue("@fileName", songName);
            cmd.Parameters.AddWithValue("@fileData", fileData);
            cmd.Parameters.AddWithValue("@MIMEType", "audio/mp3");

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void displaySavedAudioFiles()
        {
            fav_box.Items.Clear();

            conn.Open();

            string query = "SELECT FileName FROM AudioFiles";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Get the file name from the database
                string fileName = reader["FileName"].ToString();
                // Add the file name to the favorites box
                fav_box.Items.Add(fileName);
            }

            reader.Close();
            conn.Close();
        }

 

        private void playFavoriteSong(string songName)
        {
            conn.Open();

            string query = "SELECT FileData FROM AudioFiles WHERE FileName = @fileName";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@fileName", songName);

            byte[] fileData = (byte[])cmd.ExecuteScalar();
            conn.Close();

            if (fileData != null)
            {
                // Generate a unique file name to avoid conflicts
                string tempFileName = Guid.NewGuid().ToString() + "_" + songName;
                string tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), tempFileName);

                try
                {
                    // Ensure the media player stops and releases any previous file
                    axWindowsMediaPlayerMusic.Ctlcontrols.stop();
                    axWindowsMediaPlayerMusic.URL = "";

                    // Write the file data to the temporary file
                    System.IO.File.WriteAllBytes(tempPath, fileData);

                    // Play the song using the media player
                    axWindowsMediaPlayerMusic.URL = tempPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing song: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File not found in the database.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (fav_box.SelectedIndex != -1)
            {
                string selectedSong = fav_box.SelectedItem.ToString();
                deleteFavoriteSong(selectedSong);
            }
            else
            {
                MessageBox.Show("Please select a song to delete.");
            }
        }

        private void deleteFavoriteSong(string songName)
        {
            conn.Open();

            string query = "DELETE FROM AudioFiles WHERE FileName = @fileName";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@fileName", songName);

            try
            {
                cmd.ExecuteNonQuery();
                // Remove the song from the favorites box
                fav_box.Items.Remove(songName);
                MessageBox.Show("Song deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting song: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void ApplyCustomStyles()
        {
            // ListBox styling
            listBoxSongs.BackColor = Color.FromArgb(255, 255, 255, 255); // White background
            listBoxSongs.Font = new Font("Arial", 10);
            listBoxSongs.ForeColor = Color.Black;

            fav_box.BackColor = Color.FromArgb(255, 255, 255, 255); // White background
            fav_box.Font = new Font("Arial", 10);
            fav_box.ForeColor = Color.Black;

            // Button styling
            btnSelectSongs.BackColor = Color.FromArgb(255, 70, 130, 180); // SteelBlue color
            btnSelectSongs.ForeColor = Color.White;
            btnSelectSongs.Font = new Font("Arial", 10, FontStyle.Bold);

            fav_btn.BackColor = Color.FromArgb(255, 34, 139, 34); // ForestGreen color
            fav_btn.ForeColor = Color.White;
            fav_btn.Font = new Font("Arial", 10, FontStyle.Bold);

            deleteBtn.BackColor = Color.FromArgb(255, 220, 20, 60); // Crimson color
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Font = new Font("Arial", 10, FontStyle.Bold);
        }

       
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        
    }
}
