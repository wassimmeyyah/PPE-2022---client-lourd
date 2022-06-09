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
    class DB_Produit
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

        public static void AddProduit(Produit prod)
        {
            string sql = "INSERT INTO Produit VALUES (@PRODRef, @PRODLibelle, @PRODPrixUnitaire)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PRODRef", MySqlDbType.VarChar).Value = prod.PRODRef;
            cmd.Parameters.Add("@PRODLibelle", MySqlDbType.VarChar).Value = prod.PRODLibelle;
            cmd.Parameters.Add("@PRODPrixUnitaire", MySqlDbType.VarChar).Value = prod.PRODPrixUnitaire;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produit ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de l'ajout ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }



        public static void UpdateProduit(Produit prod, string id)
        {
            string sql = "UPDATE Produit SET PRODRef = @PRODRef, PRODLibelle = @PRODLibelle, PRODPrixUnitaire = @PRODPrixUnitaire WHERE PRODRef = @PRODRef";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PRODRef", MySqlDbType.VarChar).Value = prod.PRODRef;
            cmd.Parameters.Add("@PRODLibelle", MySqlDbType.VarChar).Value = prod.PRODLibelle;
            cmd.Parameters.Add("@PRODPrixUnitaire", MySqlDbType.VarChar).Value = prod.PRODPrixUnitaire;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produit mis à jour avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la mise à jour ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(sql);
            }
            con.Close();
        }

        public static void DeleteProduit(string id)
        {
            string sql = "DELETE FROM Produit WHERE PRODRef = @PRODRef";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PRODRef", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produit supprimé avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
