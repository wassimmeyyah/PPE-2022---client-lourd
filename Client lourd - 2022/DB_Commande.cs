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
    class DB_Commande
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost; port=3306; username=root;password=;database=ppe-2022---client-lourd";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddCommande(Commande com)
        {
            string sql = "INSERT INTO Commande VALUES (@COMRef, @COMDate, @UTILCode)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@COMRef", MySqlDbType.Int32).Value = com.COMRef;
            cmd.Parameters.Add("@COMDate", MySqlDbType.VarChar).Value = com.COMDate;
            cmd.Parameters.Add("@UTILCode", MySqlDbType.Int32).Value = com.UTILCode;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de l'ajout ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }



        public static void UpdateCommande(Commande com, string id)
        {
            string sql = "UPDATE Commande SET COMRef = @COMRef, COMDate = @COMDate, UTILCode = @UTILCode WHERE COMRef = @COMRef";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@COMRef", MySqlDbType.Int32).Value = com.COMRef;
            cmd.Parameters.Add("@COMDate", MySqlDbType.VarChar).Value = com.COMDate;
            cmd.Parameters.Add("@UTILCode", MySqlDbType.Int32).Value = com.UTILCode;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande mis à jour avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la mise à jour ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(sql);
            }
            con.Close();
        }

        public static void DeleteCommande(string id)
        {
            string sql = "DELETE FROM Commande WHERE COMRef = @COMRef";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@COMRef", MySqlDbType.Int32).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande supprimé avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
