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
    class DB_Employe
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

        public static void AddEmploye(Employe emp)
        {
            string sql = "INSERT INTO Employe VALUES (@EMPLOYCode, @EMPLOYNom, @EMPLOYPoste, @EMPLOYMail, @EMPLOYTelephone, @EMPLOYPharmacie)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@EMPLOYCode", MySqlDbType.VarChar).Value = emp.EMPLOYCode;
            cmd.Parameters.Add("@EMPLOYNom", MySqlDbType.VarChar).Value = emp.EMPLOYNom;
            cmd.Parameters.Add("@EMPLOYPoste", MySqlDbType.VarChar).Value = emp.EMPLOYPoste;
            cmd.Parameters.Add("@EMPLOYMail", MySqlDbType.VarChar).Value = emp.EMPLOYMail;
            cmd.Parameters.Add("@EMPLOYTelephone", MySqlDbType.VarChar).Value = emp.EMPLOYTelephone;
            cmd.Parameters.Add("@EMPLOYPharmacie", MySqlDbType.VarChar).Value = emp.EMPLOYPharmacie;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employé ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de l'ajout ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }



        public static void UpdateEmploye(Employe emp, string id)
        {
            string sql = "UPDATE Employe SET EMPLOYNom = @EMPLOYNom, EMPLOYPoste = @EMPLOYPoste, EMPLOYMail = @EMPLOYMail, EMPLOYTelephone = @EMPLOYTelephone, EMPLOYPharmacie = @EMPLOYPharmacie WHERE EMPLOYCode = @EMPLOYCode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@EMPLOYCode", MySqlDbType.VarChar).Value = emp.EMPLOYCode;
            cmd.Parameters.Add("@EMPLOYNom", MySqlDbType.VarChar).Value = emp.EMPLOYNom;
            cmd.Parameters.Add("@EMPLOYPoste", MySqlDbType.VarChar).Value = emp.EMPLOYPoste;
            cmd.Parameters.Add("@EMPLOYMail", MySqlDbType.VarChar).Value = emp.EMPLOYMail;
            cmd.Parameters.Add("@EMPLOYTelephone", MySqlDbType.VarChar).Value = emp.EMPLOYTelephone;
            cmd.Parameters.Add("@EMPLOYPharmacie", MySqlDbType.VarChar).Value = emp.EMPLOYPharmacie;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employé mis à jour avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Echec de la mise à jour ... \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(sql);
            }
            con.Close();
        }

        public static void DeleteEmploye(string id)
        {
            string sql = "DELETE FROM Employe WHERE EMPLOYCode = @EMPLOYCode";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@EMPLOYCode", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employé supprimé avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
