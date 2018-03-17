using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows;

namespace CarTradingUnlimited
{
    public class CTUConnection
    {
        public SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CTU;Integrated Security=True");// connecting or linking to the designated database //
        public SqlCommand command; // creating a command that the SQL must perform //
        public DataTable table = new DataTable(); // creating a data-table //
        public DataTable table2; // creating a data-table //
        public DataTable table3; // creating a data-table //        
        public DataRow row; // creating data - rows //  
        public SqlDataReader reader = null; //creating a reader for analysing data within SQL and setting it to an empty value //
        public DataView dataset; // creating a Data-View //
        public DataSet set;
        public SqlDataAdapter sda = new SqlDataAdapter();

        public int Count
        {
            get;
            set;
        }

        public void SelectRole()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select * from Roles", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectDepartment()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select * from Departments", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void LoginAccountEmployee(string Username, string Password, int Department)
        {
            table = new DataTable(); // refreshens the table //

            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("select * from Employee Where Username = '" + Username + "' AND [Password] = '" + Password + "' AND Department = " + Department + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            reader = command.ExecuteReader(); //Executing the reader//      

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                this.Count += 1;  // the "Count" variable will increment by 1 while the reader is continuesly being executed//  

                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable// 
            }

            if (this.Count == 1) // If the "Count" variable is at the range of "1", do the following//
            {
                MessageBox.Show("Access Granted"); //A messagebox will appear stating the user is granted access//              
            }

            else if (this.Count > 1) //If the "Count" variable has a range more than 1, do the following// 
            {
                MessageBoxResult DiaResult = MessageBox.Show("Access denied", "Warning", MessageBoxButton.OK, MessageBoxImage.Error); //A message in the format of a dialog will appear stating the user was denied access//
            }

            else //If the condition(s) previously mentioned has or have not been met, do the following//
            {
                MessageBoxResult DiaResult2 = MessageBox.Show("Access denied", "Warning", MessageBoxButton.OK, MessageBoxImage.Error); //A message in the format of a dialog will appear stating the user was denied access//
            }

            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
            reader.Close(); //*postphone the reader and use it for future reference*// 
        }




        public void SelectCustomer()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, Username, [Password], Firstname, Surname, IDnumber as [ID number], BankNo as [Bank number] from Customer", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectCustomerBooking()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, Username, [Password], Firstname +' '+ Surname as [Name of the customer], IDnumber as [ID number], BankNo as [Bank number] from Customer", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteCustomer(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from Customer where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateCustomer(string Username, string Password, string Firstname, string surname, string IDnum, string BankNo, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update Customer set Username = '" + Username + "', [Password] = '" + Password + "', Firstname = '" + Firstname + "', Surname = '" + surname + "', IDNumber ='" + IDnum + "', BankNo = '" + BankNo + "' where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetCustomer(string Username, string Password, string Firstname, string Surname, string ID, string BankNO)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Customer values('" + Username + "', '" + Password + "', '" + Firstname + "', '" + Surname + "', '" + ID + "', '" + BankNO + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchCustomerName(string CustomerName)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Firstname Like '%{0}%'", CustomerName);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchCustomerSurname(string CustomerName)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Surname Like '%{0}%'", CustomerName);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchCustomerID(string CustomerID)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[ID number] Like '%{0}%'", CustomerID);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchCustomerUsername(string CustomerUsername)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Username Like '%{0}%'", CustomerUsername);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchCustomerPassword(string CustomerPassword)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Password] Like '%{0}%'", CustomerPassword);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectEmployee()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select e.ID, e.Username, e.[Password], e.Firstname, e.Surname, e.IDnumber as [ID number], r.RoleType, d.DepartmentType from Employee e inner join Roles r on e.Roles = r.ID inner join Departments d on e.Department = d.ID ", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteEmployee(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from Employee where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateEmployee(string Username, string Password, string Firstname, string Surname, string IDno, int Role, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update Employee set Username = '" + Username + "', [Password] = '" + Password + "', Firstname = '" + Firstname + "', Surname = '" + Surname + "', IDNumber ='" + IDno + "', Roles = " + Role + " where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetEmployee(string Username, string Password, string Firstname, string Surname, string IDNo, int Department, int Role)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Employee values('" + Username + "', '" + Password + "', '" + Firstname + "', '" + Surname + "','" + IDNo + "', " + Department + ", " + Role + ")", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchEmployeeName(string EmployeeName)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Firstname Like '%{0}%'", EmployeeName);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchEmployeeSurname(string EmployeeName)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Surname Like '%{0}%'", EmployeeName);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchEmployeeID(string EmployeeID)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[ID number] Like '%{0}%'", EmployeeID);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchEmployeeUsername(string EmployeeUsername)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Username Like '%{0}%'", EmployeeUsername);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchEmployeePassword(string EmployeePassword)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Password] Like '%{0}%'", EmployeePassword);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectNewVehicle()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, BrandName as [Brand name], ModelType as Model, SerialNumber as [Serial-number], Color, Price, YearEstablished from NewVehicles", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteNewVehicle(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from NewVehicles where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateNewVehicles(string Brand, string Model, string Serial, string color, string Price, DateTime YearEstablished, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update NewVehicles set BrandName = '" + Brand + "', ModelType = '" + Model + "', SerialNumber = '" + Serial + "', Color = '" + color + "', Price ='" + Price + "', YearEstablished = '" + YearEstablished + "' where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetNewVehicles(string Brand, string Model, string Serial, string color, string Price, DateTime YearEstablished)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into NewVehicles values('" + Brand + "', '" + Model + "', '" + Serial + "', 'New','" + color + "', '" + Price + "', '" + YearEstablished + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }


        public void SearchNewBrand(string NewBrand)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Brand name] Like '%{0}%'", NewBrand);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchNewModel(string NewModel)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Model Like '%{0}%'", NewModel);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchNewColor(string NewColor)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Color Like '%{0}%'", NewColor);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchNewPrice(string NewPrice)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Price Like '%{0}%'", NewPrice);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchNewSerialNO(string NewSerialNO)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Serial-number] Like '%{0}%'", NewSerialNO);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectOldVehicle()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, BrandName as [Brand name], ModelType as Model, SerialNumber as [Serial-number], [Types] , Color, Price, ServiceHistory as [Service history], Speed as [kilometers used], Condition from OldVehicles", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteOldVehicle(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from OldVehicles where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateOldVehicles(string Brand, string Model, string Serial, string color, string Type, string Price, string ServiceHistory, Int64 Speed, string Condition, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update OldVehicles set BrandName = '" + Brand + "', ModelType = '" + Model + "', SerialNumber = '" + Serial + "',  Color = '" + color + "', [Types] = '" + Type + "', Price ='" + Price + "', ServiceHistory = '" + ServiceHistory + "', Speed = '" + Speed + "', Condition = '" + Condition + "' where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetOldVehicles(string Brand, string Model, string Serial, string color, string Type, string Price, string ServiceHistory, Int64 Speed, string Condition)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into OldVehicles values('" + Brand + "', '" + Model + "', '" + Serial + "', '" + color + "', '" + Type + "', '" + Price + "', '" + ServiceHistory + "', " + Speed + ", '" + Condition + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchOldBrand(string OldBrand)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Brand name] Like '%{0}%'", OldBrand);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchOldModel(string OldModel)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Model Like '%{0}%'", OldModel);//The data-view filters the table//
        }

        public void SearchOldColor(string OldColor)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Color Like '%{0}%'", OldColor);//The data-view filters the table//
        }

        public void SearchOldPrice(string OldPrice)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Price Like '%{0}%'", OldPrice);//The data-view filters the table//
        }

        public void SearchOldSerialNO(string OldSerialNO)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Serial-number] Like '%{0}%'", OldSerialNO);//The data-view filters the table//
        }

        public void SelectCarService()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select cs.ID, cs.CustomerCar as [Brand name of the vehicle], cs.DateBooked as [Date service was booked], cs.Problem as Details, cs.Progress, c.Firstname + ' ' + c.Surname as [Name of the customer], e.Firstname +' '+ e.Surname [Name of the mechanic] from CarService cs inner join Employee e on cs.MechanicName = e.ID inner join Invoice i on cs.CustomerName = i.ID inner join Customer c on i.CustomerName = c.ID", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectcertainCustomerService()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select i.ID, i.ServicePlan, c.Firstname +' '+ c.Surname [Name of the customer] from Invoice i  inner join Customer c on i.CustomerName = c.ID where i.ServicePlan = 'Yes' ", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//



            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectcertainMechanicService()
        {
            // create a data-table //

            table2 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select e.ID as [employ ID], r.ID, r.RoleType, e.Firstname +' '+ e.Surname as [Name of Mechanic] from Employee e inner join Roles r on e.Roles = r.ID where r.ID = 4", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//



            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table2.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table2.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table2.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteCarService(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from CarService where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateCarService(string CustomerCar, DateTime DateBooked, string Problem, string Progress, int MechName, int CustomerName, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update CarService set CustomerCar = '" + CustomerCar + "', DateBooked = '" + DateBooked + "',  Problem = '" + Problem + "', Progress = '" + Progress + "', MechanicName = " + MechName + ", CustomerName = " + CustomerName + " where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetCarServices(string CustomerCar, DateTime DateBooked, string Problem, int MechName, int CustomerName)
        {
            try
            {
                connection.Open(); // The SQL connection is reference to the designated database // 
                command = new SqlCommand("insert into CarService values('" + CustomerCar + "', '" + DateBooked + "', '" + Problem + "', 'On hold', " + MechName + ", " + CustomerName + ")", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
                command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
                connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
                command.Dispose(); //*permenetally erase the SQL-command*//

                MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
            }

            catch(SqlException)
            { }
        }

        public void SearchServiceCar(string ServiceCar)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Brand name of the vehicle] Like '%{0}%'", ServiceCar);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchServiceCust(string ServiceCust)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Name of the customer] Like '%{0}%'", ServiceCust);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchServiceMech(string ServiceMech)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Name of the mechanic] Like '%{0}%'", ServiceMech);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchServiceProb(string ServiceProb)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Details Like '%{0}%'", ServiceProb);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchServiceProgress(string ServiceProgress)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Progress Like '%{0}%'", ServiceProgress);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectWareHouseVehicle()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, BrandName as [Brand name], ModelType as Model, SerialNumber as [Serial-number], Color, Price, YearEstablished from WareHouse", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteWareHouseVehicle(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from WareHouse where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SelectcertainWareHouseVehicle(int ID)
        {
            // create a data-table //

            table2 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select * from WareHouse where ID = " + ID + "", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//



            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table2.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table2.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table2.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void UpdateWareHouseVehicles(string Brand, string Model, string Serial, string color, string Price, DateTime YearEstablished, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update WareHouse set BrandName = '" + Brand + "', ModelType = '" + Model + "', SerialNumber = '" + Serial + "', Color = '" + color + "', Price ='" + Price + "', YearEstablished = '" + YearEstablished + "' where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetWareHouseVehicles(string Brand, string Model, string Serial, string color, string Price, DateTime YearEstablished)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into WareHouse values('" + Brand + "', '" + Model + "', '" + Serial + "', 'New','" + color + "', '" + Price + "', '" + YearEstablished + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchWareHouseBrand(string NewBrand)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Brand name] Like '%{0}%'", NewBrand);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchWareHouseModel(string NewModel)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Model Like '%{0}%'", NewModel);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchWareHouseColor(string NewColor)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Color Like '%{0}%'", NewColor);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchWareHousePrice(string NewPrice)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Price Like '%{0}%'", NewPrice);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchWareHouseSerialNO(string NewSerialNO)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Serial-number] Like '%{0}%'", NewSerialNO);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectTestDrive()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select td.ID, td.BookingNo, td.DateBooked, c.Firstname +' '+ c.Surname as [Name of customer], nV.BrandName, nV.ModelType, nv.[Types], nV.SerialNumber, nV.Price from TestDrive td inner join Customer c on td.CustomerName = c.ID inner join NewVehicles nV on td.NewCarName = nV.ID", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectTestDrive2()
        {
            // create a data-table //

            table2 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select td.ID, td.BookingNo, td.DateBooked, c.Firstname +' '+ c.Surname as [Name of customer], oV.BrandName, oV.ModelType, ov.[Types], oV.SerialNumber, oV.Price from TestDrive td inner join Customer c on td.CustomerName = c.ID inner join OldVehicles oV on td.OldCarName = oV.ID", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table2.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table2.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table2.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectNewDrive()
        {
            // create a data-table //

            table2 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, BrandName +' '+ ModelType as [Name of vehicle] from NewVehicles where [Types] = 'New'", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table2.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table2.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table2.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectUsedDrive()
        {
            // create a data-table //

            table2 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, BrandName +' '+ ModelType as [Name of vehicle] from OldVehicles where [Types] = 'Used'", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table2.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table2.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table2.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectDemoDrive()
        {
            // create a data-table //

            table2 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, BrandName +' '+ ModelType as [Name of vehicle] from OldVehicles where [Types] = 'Demo'", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table2.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table2.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table2.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteTestDrive(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from TestDrive where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateTestDrive(DateTime DateBooked, int BookingNo, int CustomerName, int NewCarName, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update TestDrive set  DateBooked = '" + DateBooked + "', BookingNo = '" + BookingNo + "', CustomerName = " + CustomerName + ", NewCarName = " + NewCarName + " where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateTestDrive2(DateTime DateBooked, int BookingNo, int CustomerName, int OldCarName, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update TestDrive set  DateBooked = '" + DateBooked + "', BookingNo = '" + BookingNo + "', CustomerName = " + CustomerName + ", OldCarName = " + OldCarName + " where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetTestDrive(DateTime DateBooked, int BookingNo, int NewCarName, int CustomerName)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into TestDrive values('" + DateBooked + "', " + BookingNo + ", " + NewCarName + ", null, " + CustomerName + ")", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetTestDrive2(DateTime DateBooked, int BookingNo, int OldCarName, int CustomerName)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into TestDrive values('" + DateBooked + "', " + BookingNo + ", null, " + OldCarName + ", '" + CustomerName + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchCustBook(string CustBook)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Name of customer] Like '%{0}%'", CustBook);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchModelBook(string ModelBook)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("ModelType Like '%{0}%'", ModelBook);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchBrandBook(string BrandBook)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("BrandName Like '%{0}%'", BrandBook);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchSerialBook(string SerialBook)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("SerialNumber Like '%{0}%'", SerialBook);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchPriceBook(string PriceBook)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Price Like '%{0}%'", PriceBook);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectMotor()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select top 10 ID, BrandName as [Brand name], ModelType as Model, Color, Price, YearEstablished as [Year motor-cycle was established] from Motorcycle order by YearEstablished desc", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectMotorPic(int ID)
        {
            // create a data-table //

            connection.Open(); // The SQL connection is reference to the database allocated // 
            set = new DataSet();
            sda = new SqlDataAdapter("select ID, MotorPicture from Motorcycle where ID = " + ID + "", connection); //*refreshens the command* *creating a link to the designated datasource*//
            sda.Fill(set);
            connection.Close();
        }

        public void DeleteMoto(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from Motorcycle where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateMoto(string Brand, string Model, string Color, string Price, DateTime Date, byte[] Motopic, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update Motorcycle set BrandName = '" + Brand + "', ModelType = '" + Model + "', Color = '" + Color + "',  Price = '" + Price + "', YearEstablished = '" + Date + "', MotorPicture = '" + Motopic + "' where ID = '" + ID + "'", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetMoto(string BrandName, string Model, string Color, string Price, DateTime YearEstablished, byte[] Moto)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Motorcycle values('" + BrandName + "','" + Model + "','" + Color + "','" + Price + "', '" + YearEstablished + "', '" + Moto + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchMotoBrand(string MotoBrand)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Brand name] Like '%{0}%'", MotoBrand);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchMotoModel(string MotoModel)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Model Like '%{0}%'", MotoModel);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchMotoColor(string MotoColor)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Color Like '%{0}%'", MotoColor);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchMotoPrice(string MotoPrice)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Price Like '%{0}%'", MotoPrice);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchMotoYear(string MotoYear)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Year motor-cycle was established] Like '%{0}%'", MotoYear);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void Selectparts()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, Details, Price, Manufacturer from Parts", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void PrintQuote(int ID)
        {
            // create a data-table //

            connection.Open(); // The SQL connection is reference to the database allocated // 
            set = new DataSet();
            sda = new SqlDataAdapter("select * from Parts where ID = " + ID + "", connection); //*refreshens the command* *creating a link to the designated datasource*//
            sda.Fill(set);
            connection.Close();
        }

        public void DeleteParts(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from Parts where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void UpdateParts(string Details, string Price, string Manufacturer, byte[] PartsPic, int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("update Parts set Details = '" + Details + "', Price = '" + Price + "', Manufacturer = '" + Manufacturer + "',  PartsPicture = '" + PartsPic + "' where ID = '" + ID + "'", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been changed successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetParts(string Details, string Price, string Manufacturer, byte[] PartsPic)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Parts values('" + Details + "','" + Price + "','" + Manufacturer + "','" + PartsPic + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchPartsBrand(string PartsBrand)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Details Like '%{0}%'", PartsBrand);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchPartsManufact(string PartsManufact)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Manufacturer Like '%{0}%'", PartsManufact);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchPartsPrice(string PartsPrice)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Price Like '%{0}%'", PartsPrice);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectInvoiceNewVehicle()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select i.ID, i.ServicePlan, e.Firstname +' '+ e.Surname as [Name of employee], i.DateIssued as [Date issued], c.Firstname +' '+ c.Surname as [Name of the customer] , nv.BrandName +' '+ nv.ModelType [Name of the vehicle], nv.SerialNumber as [Serial number], nv.[Types], nv.Price from Invoice i inner join Customer c on i.CustomerName = c.ID inner join NewVehicles nv on i.NewCarPurchased = nv.ID inner join Employee e on i.SalesOrMech = e.ID", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectInvoiceOldVehicle()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select i.ID, i.ServicePlan, e.Firstname +' '+ e.Surname as [Name of employee], i.DateIssued as [Date issued], c.Firstname +' '+ c.Surname as [Name of the customer] , ov.BrandName +' '+ ov.ModelType [Name of the vehicle], ov.SerialNumber as [Serial number], ov.[Types], ov.Price from Invoice i inner join Customer c on i.CustomerName = c.ID inner join OldVehicles ov on i.OldCarPurchased = ov.ID inner join Employee e on i.SalesOrMech = e.ID", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectInvoiceService()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select i.ID, i.ServicePlan, i.SalesOrMech as [Mechanic], i.Price, i.DateIssued as [Date issued], cs.CustomerName as [Name of the customer] , cs.CustomerCar, cs.Problem from Invoice i inner join Customer c on i.CustomerName = c.ID inner join CarService cs on i.ID = cs.CustomerName", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectInvoiceParts()
        {
            // create a data-table //

            table = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select i.ID, i.DateIssued as [Date issued], c.Firstname +' '+ c.Surname as [Name of the customer], p.Price, p.Details, p.Manufacturer from Invoice i inner join Customer c on i.CustomerName = c.ID inner join Parts p on i.PartsPurchased = p.ID ", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void DeleteInvoice(int ID)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("delete from Invoice where ID = " + ID + "", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been deleted successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SearchInvoiceCustomer(string InvoiceCustomer)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Name of the customer] Like '%{0}%'", InvoiceCustomer);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchInvoiceVehicle(string InvoiceVehicle)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("[Name of the vehicle] Like '%{0}%'", InvoiceVehicle);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchInvoiceCarService(string InvoiceCarService)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("ServicePlan Like '%{0}%'", InvoiceCarService);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SearchInvoiceParts(string InvoiceParts)
        {
            dataset = new DataView(table); //refreshens the data-view and focuses on the information stored inside the data-table //
            dataset.RowFilter = string.Format("Details Like '%{0}%'", InvoiceParts);//The data-view filters the table according to the "Patient's name" when issuing an invoice//
        }

        public void SelectInvoiceCustomer2()
        {
            // create a data-table //

            table2 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select ID, Username, [Password], Firstname +' '+ Surname as [Name], IDnumber as [ID number], BankNo as [Bank number] from Customer", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table2.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table2.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table2.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectInvoiceEmployeeSalesMen()
        {
            // create a data-table //

            table3 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select e.ID, e.Username, e.[Password], e.Firstname +' '+ e.Surname as [EmName], e.IDnumber as [ID number], r.RoleType, d.DepartmentType from Employee e inner join Roles r on e.Roles = r.ID inner join Departments d on e.Department = d.ID where r.ID = 3", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader// 

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table3.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table3.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table3.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void SelectInvoiceEmployeeMech()
        {
            // create a data-table //

            table3 = new DataTable(); // refreshens the table //
            connection.Open(); // The SQL connection is reference to the database allocated // 
            command = new SqlCommand("select e.ID, e.Username, e.[Password],  e.Firstname +' '+ e.Surname as [EmName], e.IDnumber as [ID number], r.RoleType, d.DepartmentType from Employee e inner join Roles r on e.Roles = r.ID inner join Departments d on e.Department = d.ID where r.ID = 4", connection); //*refreshens the command* *creating a link to the designated datasource*//
            reader = command.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                table3.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = table3.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                table3.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               

            }
            connection.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void GetInvoiceNewCar(int SalesMan, string ServicePlan, DateTime Date, int Customer, int NewCar)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Invoice values(" + SalesMan + ", '" + ServicePlan + "', null, '" + Date + "', " + Customer + " ," + NewCar + ", null, null, null)", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetInvoiceOldCar(int SalesMan, string ServicePlan, DateTime Date, int Customer, int OldCar)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Invoice values('" + SalesMan + "', '" + ServicePlan + "', null, '" + Date + "', '" + Customer + "' ,'null', " + OldCar + ", 'PartsPurchased=null', 'ServiceDetail=null')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetInvoiceServiceCar(int Mechanic, string Price, DateTime Date, int Customer, string ServiceDetail)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Invoice values(" + Mechanic + ", null, '" + Price + "', '" + Date + "'," + Customer + " ,null, null, null, '" + ServiceDetail + "')", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void GetInvoiceParts(DateTime Date, int Customer, int Parts)
        {
            connection.Open(); // The SQL connection is reference to the designated database // 
            command = new SqlCommand("insert into Invoice values(null, null, null, 'DateIssued', 'CustomerNameNO=1' ,null , null, 'PartsPurchasedNO=1', null)", connection); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "connection" basically specifies the execution of the located database*//
            command.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            connection.Close(); //*postphone the sqlconnection and use it later for future reference*//
            command.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }
    }
}
