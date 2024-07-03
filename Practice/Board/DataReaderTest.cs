using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            DataTable customer = new DataTable("Customer");

            DataColumn customerID = new DataColumn("ID", typeof(int));
            DataColumn customerName = new DataColumn("Name", typeof(string));
            DataColumn customerMobile = new DataColumn("Mobile", typeof(string));

            customer.Columns.Add(customerID);
            customer.Columns.Add(customerName);
            customer.Columns.Add(customerMobile);

            customer.Rows.Add(101, 'Sanisha', '9812345678');
            customer.Rows.Add(102, 'Chandan', '9812345678');

            DataTable orders = new DataTable("Orders");

            DataColumn orderID = new DataColumn("ID", typeof(int));
            DataColumn cID = new DataColumn("CustomerID", typeof(int));
            DataColumn orderAmount = new DataColumn("Amount", typeof(int));

            orders.Columns.Add(orderID);
            orders.Columns.Add(cID);
            orders.Columns.Add(orderAmount);

            orders.Rows.Add(1001, 101, 10000);
            orders.Rows.Add(1002, 102, 20000);

            DataSet dataSet = new DataSet();

            dataSet.Tables.Add(customer);
            dataSet.Tables.Add(orders);

            Console.WriteLine('Fetching Customer Table Data');

            foreach (DataRow row in dataSet.Tables["Customer"].Rows)
            {
                Console.WriteLine(row["ID"] + " " + row["Name"] + " " + row["Mobile"]);
            }

            Console.WriteLine('Fetching Orders Table Data');

            foreach (DataRow row in dataSet.Tables[1].Rows){
                Console.WriteLine(row["ID"] + " " + row["CustomerID"] + " " + row["Amount"]);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}