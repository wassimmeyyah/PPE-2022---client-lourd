using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_lourd___2022
{
    class DB_Pharmacie
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost; port=3306; username=root;password=;database=ppe-2022---client-lourd";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            } catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddPharmacie(Pharmacie pharma)
        {
            string sql = "INSERT INTO pharmacie VALUES (@PHARMACode, @PHARMAVille, @PHARMAAdresse, @PHARMATelephone, @PHARMAMail)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PHARMACode", MySqlDbType.VarChar).Value = pharma.PHARMACode;
            cmd.Parameters.Add("@PHARMAVille", MySqlDbType.VarChar).Value = pharma.PHARMAVille;
            cmd.Parameters.Add("@PHARMAAdresse", MySqlDbType.VarChar).Value = pharma.PHARMAAdresse;
            cmd.Parameters.Add("@PHARMATelephone", MySqlDbType.VarChar).Value = pharma.PHARMATelephone;
            cmd.Parameters.Add("@PHARMAMail", MySqlDbType.VarChar).Value = pharma.PHARMAMail;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pharmacie ajoutée avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (MySqlException ex)
            {
                MessageBox.Show("Echec de l'ajout ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }



        public static void UpdatePharmacie(Pharmacie pharma, string id)
        {
            string sql = "UPDATE pharmacie SET PHARMAVille = @PHARMAVille, PHARMAAdresse = @PHARMAAdresse, PHARMATelephone = @PHARMATelephone, PHARMAMail = @PHARMAMail WHERE PHARMACode = @PHARMACode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PHARMACode", MySqlDbType.VarChar).Value = pharma.PHARMACode;
            cmd.Parameters.Add("@PHARMAVille", MySqlDbType.VarChar).Value = pharma.PHARMAVille;
            cmd.Parameters.Add("@PHARMAAdresse", MySqlDbType.VarChar).Value = pharma.PHARMAAdresse;
            cmd.Parameters.Add("@PHARMATelephone", MySqlDbType.VarChar).Value = pharma.PHARMATelephone;
            cmd.Parameters.Add("@PHARMAMail", MySqlDbType.VarChar).Value = pharma.PHARMAMail;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pharmacie mise à jour avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la mise à jour ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(sql);
            }
            con.Close();
        }

        public static void DeletePharmacie(string id)
        {
            string sql = "DELETE FROM pharmacie WHERE PHARMACode = @PHARMACode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PHARMACode", MySqlDbType.VarChar).Value = id;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pharmacie supprimée avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la suppression ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
