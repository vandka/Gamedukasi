using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
using System.Data;

namespace GAMEDUKASI
{
    class Educlass
    {

        public void EduMusic(string path, bool isplay)
        {
            try
            {
                SoundPlayer my_sound = new SoundPlayer(path);
                if (isplay == true)
                {

                    my_sound.Play();
                    my_sound.PlayLooping();
                }
                else
                {
                    my_sound.Stop();
                }
            }
            catch (Exception)
            {

            }

        }
        public static bool musicplay;
        public static string loadlastmusic, proname;
        public static int uang, Skor, Friz, Next, health, hint;
        public static Image proimg;

        public static void SavedData(string connectku, string Username)
        {
            OleDbConnection connection = new OleDbConnection(connectku);
            connection.Open();
            OleDbCommand cmd;
            try
            {
                //update.ExecuteNonQuery();

                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE Profile  SET [Freeze]='" + Friz + "', [Money]='" + uang + "', [Skip]='" + Next + "', [Health]='" + health + "', [Hint]='" + hint + "'" + " WHERE User='" + Username + "'";
                cmd.ExecuteNonQuery();

            }
            catch (Exception en)
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
