using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabInventory
{
    public partial class PowerToolsUserControl : UserControl
    {

        private static PowerToolsUserControl _instance;

        public static PowerToolsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PowerToolsUserControl();
                }
                return _instance;
            }
        }


        //Initialize the Power Tools Control
        public PowerToolsUserControl()
        {
            InitializeComponent();
        }

        //Make a connection to the SQL Database
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");

        private void PowerToolsUserControl_Load(object sender, EventArgs e)
        {
            refresh_dataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void refresh_dataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowPowerTools_Procedure", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet(); //Data set for filling in the data in the Grid View
                adaptor.Fill(dataset);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL operation: " + ex);
                }
                connection.Close();

                //Chosing the data to be displayed in the Grid View on the Screen
                PowerToolsGrid.DataSource = dataset.Tables[0];

                //Making sure that the data grid view uses up all the space avaibale on the screen
                this.PowerToolsGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.PowerToolsGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.PowerToolsGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.PowerToolsGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.PowerToolsGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.PowerToolsGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        //Adding new power items to the database
        private void AddNewButton_Click(object sender, EventArgs e)
        {

            //Make sure the user does not try to add items where there are empty fields
            if ((WNumberField.Text == "") || (ManufacturerField.Text == "") || (ConditionField.Text == "") ||
                (DescriptionField.Text == "") || (AvailableField.Text == "") || (LocationField.Text == ""))
            {
                MessageBox.Show("Please ensure that there are no empty fields");
            }
            else
            {
                MessageBox.Show("Now Attempting to Add");
                SqlCommand cmd = new SqlCommand("AddPowerTools_Procedure", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@WNumber", WNumberField.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", ManufacturerField.Text);
                cmd.Parameters.AddWithValue("@Condition", ConditionField.Text);
                cmd.Parameters.AddWithValue("@Description", DescriptionField.Text);
                cmd.Parameters.AddWithValue("@Available", AvailableField.Text);
                cmd.Parameters.AddWithValue("@Location", LocationField.Text);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL Operation: " + ex);
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
            refresh_dataGridView(); // Refresh the viewed data after you finish adding an item

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!PowerToolsUserControl.Instance.Controls.ContainsKey("ToolsUserControl"))
            {
                ToolsUserControl _tools = new ToolsUserControl();
                _tools.Dock = DockStyle.Fill;
                ToolsUserControl.Instance.Controls.Add(_tools);
            }
            ToolsUserControl.Instance.Controls["ToolsUserControl"].BringToFront();
        }
    }
}
