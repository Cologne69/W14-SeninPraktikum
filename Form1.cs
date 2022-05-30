using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W14_Praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        int currentPosition = 0;

        
        DataTable dtTeam = new DataTable();
        DataTable DGV = new DataTable();
     


        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = $"select t.team_name, concat(ma.manager_name,' ','(',n.nation,')') , concat(t.home_stadium,', ', t.city, ' (', t.capacity, ')'), t.team_id from `match` m, team t, manager ma, player p, nationality n where t.manager_id = ma.manager_id and ma.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            DataMantap(currentPosition);

            
            

            

        }
        
        
            
        private void DataMantap(int index)
        {
            lbl_namaTim.Text = dtTeam.Rows[index][0].ToString();
            lbl_Manager.Text = dtTeam.Rows[index][1].ToString();
            lbl_Stadium.Text = dtTeam.Rows[index][2].ToString();
            //lbl_topScorer.Text = dtTeam.Rows[currentPosition][5].ToString();

            sqlConnect.Open();
            sqlQuery = $"SELECT CONCAT(player_name, ' (', goal_penalty,')') FROM (SELECT p.player_name AS 'player_name', SUM(type = 'GO' OR type = 'GP'), SUM(type = 'GP') AS 'goal_penalty' FROM `dmatch` dm LEFT JOIN player p ON p.player_id = dm.player_id WHERE dm.team_id = '{dtTeam.Rows[index]["team_id"].ToString()}' GROUP BY dm.player_id ORDER BY 2 DESC LIMIT 1) dt;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            lbl_topScorer.Text = sqlCommand.ExecuteScalar().ToString();

            sqlQuery = $"SELECT CONCAT(player_name,', ', yellow_card, ' Yellow Card and ', red_card, ' Red Card') FROM(SELECT p.player_name AS 'player_name', SUM(IF(type = 'CY', 1, 3)), SUM(type = 'CY') AS 'yellow_card', SUM(type = 'CR') AS 'red_card' FROM `dmatch` dm LEFT JOIN player p ON p.player_id = dm.player_id WHERE dm.team_id = '{dtTeam.Rows[index]["team_id"].ToString()}' AND (dm.type = 'CY' OR dm.type = 'CR') GROUP BY dm.player_id ORDER BY 2 DESC LIMIT 1) dt;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            lbl_SIUUUU.Text = sqlCommand.ExecuteScalar().ToString();
            sqlConnect.Close();


            sqlQuery = $"SELECT * FROM (SELECT m.match_date, IF(m.team_home = '{dtTeam.Rows[index][3].ToString()}', 'HOME', 'AWAY') AS 'Home / Away', CONCAT('vs ', IF(m.team_home = '{dtTeam.Rows[index][3].ToString()}', tAway.team_name, tHome.team_name)) AS 'Lawan', CONCAT(goal_home, ' - ', goal_away) AS 'Score' FROM `match` m LEFT JOIN team tHome ON m.team_home = tHome.team_id LEFT JOIN team tAway ON tAway.team_id = m.team_away WHERE m.team_home = '{dtTeam.Rows[index][3].ToString()}' OR m.team_away = '{dtTeam.Rows[index][3].ToString()}' ORDER BY m.match_id DESC LIMIT 5) dt ORDER BY 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(DGV);
            dataGridView1.DataSource = DGV;
            dataGridView1.ReadOnly = true;
        }
        
       
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            currentPosition = 0;
            DataMantap(currentPosition);
            
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            currentPosition--;
            if (currentPosition < 0)
            {
                currentPosition = 0;
                MessageBox.Show("Data sudah paling awal!");
                
            }
            DataMantap(currentPosition);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentPosition++;
            
            
            if (currentPosition > dtTeam.Rows.Count - 1)
            {
                currentPosition = dtTeam.Rows.Count - 1;
                MessageBox.Show("Data sudah paling akhir!");
                
            }
            DataMantap(currentPosition);
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            currentPosition = dtTeam.Rows.Count - 1;
            DataMantap(currentPosition);
        }

        private void lbl_SIUUUU_Click(object sender, EventArgs e)
        {

        }
    }
}
