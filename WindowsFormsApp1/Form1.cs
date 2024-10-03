using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration.Provider;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DbConnection connection;
        DbDataAdapter adapter;
        DbProviderFactory factory;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void UpdateDataset(object sender, EventArgs e) => ds = new DataSet();
        private void ConnectToDataBase(object sender, EventArgs e)
        {
            ds = new DataSet();
            try
            {
                factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                connection = factory.CreateConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["string1"].ConnectionString;
                connection.Open();
                MessageBox.Show("Подключение открыто");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisconnectToDataBase(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Подключение закрыто");
            }
            else { MessageBox.Show("Не удалось закрыть подключение\nПодключение было уже закрыто"); }
        }
        private void SelectTeaInfo(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("TeaInfo")) dataGridView1.DataSource = ds.Tables["TeaInfo"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand updateTeaInfoCommand = connection.CreateCommand(); ;
                    updateTeaInfoCommand.CommandText = "select * from TeaInfo";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = updateTeaInfoCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "TeaInfo");
                    dataGridView1.DataSource = ds.Tables["TeaInfo"];
                }
            }
            catch { MessageBox.Show("Для начала откройте подключение!!!"); }
        }
        private void SelectNamesOfTea(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("NamesOfTea")) dataGridView1.DataSource = ds.Tables["NamesOfTea"];
                else
                {
                    adapter = factory.CreateDataAdapter();

                    DbCommand selectNamesOfTeas = connection.CreateCommand();
                    selectNamesOfTeas.CommandText = "select Name from TeaInfo";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectNamesOfTeas;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "NamesOfTea");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["NamesOfTea"];
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SelectGreenTeas(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("GreenTeas")) dataGridView1.DataSource = ds.Tables["GreenTeas"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select Name,Cost,Grammes from TeaInfo " +
                        "join TypeOfTea on TypeOfTea.ID = TeaInfo.TypeId " +
                        "where ColorOfTea = 'green'";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "GreenTeas");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["GreenTeas"];
                }
            
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void SelectBlackTeas(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("BlackTeas")) dataGridView1.DataSource = ds.Tables["BlackTeas"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select Name,Cost,Grammes from TeaInfo " +
                        "join TypeOfTea on TypeOfTea.ID = TeaInfo.TypeId " +
                        "where ColorOfTea = 'black'";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "BlackTeas");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["BlackTeas"];
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void SelectOtherTeas(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("OtherTeas")) dataGridView1.DataSource = ds.Tables["OtherTeas"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select Name,Cost,Grammes from TeaInfo " +
                        "join TypeOfTea on TypeOfTea.ID = TeaInfo.TypeId " +
                        "where ColorOfTea not like 'black' or ColorOfTea not like 'green'";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "OtherTeas");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["OtherTeas"];
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SelectTeasPerGrammes (object sender, EventArgs e)
        {
            DataSet dsWithParam = new DataSet();
            try
            {
                adapter = factory.CreateDataAdapter();
                DbCommand selectGreenTeasCommand = connection.CreateCommand();
                selectGreenTeasCommand.CommandText = "select Name,Cost,Grammes from TeaInfo where Grammes < @grammes";

                DbParameter param = selectGreenTeasCommand.CreateParameter();
                param.ParameterName = "@grammes";
                param.DbType = DbType.Int32;
                param.Value = Convert.ToInt32(textBox1.Text);
                selectGreenTeasCommand.Parameters.Add(param);

                DbCommandBuilder builder = factory.CreateCommandBuilder();
                adapter.SelectCommand = selectGreenTeasCommand;
                builder.DataAdapter = adapter;
                adapter.Fill(dsWithParam, "SelectWithParameter");

                dataGridView1.DataSource = dsWithParam.Tables["SelectWithParameter"];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SelectMinMaxAvgCost(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("LowestCost")) dataGridView1.DataSource = ds.Tables["LowestCost"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select min(cost) as Lowest, max(cost), avg(cost) as Maximum from TeaInfo";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "LowestCost");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["LowestCost"];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void LastZadaniye1(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("lastZad1")) dataGridView1.DataSource = ds.Tables["lastZad1"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select count(Name) from TeaInfo where cost = (select min(cost) from TeaInfo)";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "lastZad1");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["lastZad1"];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void LastZadaniye2(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("lastZad2")) dataGridView1.DataSource = ds.Tables["lastZad2"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select count(Name) from TeaInfo where cost = (select max(cost) from TeaInfo)";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "lastZad2");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["lastZad2"];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void LastZadaniye3(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("lastZad3")) dataGridView1.DataSource = ds.Tables["lastZad3"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select count(Name) from TeaInfo where cost > (select avg(cost) from TeaInfo)";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "lastZad3");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["lastZad3"];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void LastZadaniye4(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables.Contains("lastZad4")) dataGridView1.DataSource = ds.Tables["lastZad4"];
                else
                {
                    adapter = factory.CreateDataAdapter();
                    DbCommand selectGreenTeasCommand = connection.CreateCommand();
                    selectGreenTeasCommand.CommandText = "select count(Name), TypeOfTea.ColorOfTea from TeaInfo join TypeOfTea on TypeOfTea.ID = TeaInfo.TypeId group by  TypeOfTea.ColorOfTea\r\n\r\n\r\n";

                    DbCommandBuilder builder = factory.CreateCommandBuilder();

                    adapter.SelectCommand = selectGreenTeasCommand;
                    builder.DataAdapter = adapter;
                    adapter.Fill(ds, "lastZad4");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["lastZad4"];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
