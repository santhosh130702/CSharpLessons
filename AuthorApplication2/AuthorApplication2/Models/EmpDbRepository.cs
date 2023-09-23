using Microsoft.Data.SqlClient;
using System.Data;

namespace AuthorApplication2.Models
{
    public class EmpDbRepository
    {
        public static List<CreateEMP> GetEmpList()
        {   
            List<CreateEMP> emplist = new List<CreateEMP>();
            using (SqlConnection cn = SqlHelper.CreateConnection()) 
            {
                if(cn.State != ConnectionState.Open)
                {
                    cn.Open(); 
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "select * from emptbl_x";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr= selectempcmd.ExecuteReader();  
                while(empdr.Read())
                {
                    CreateEMP emp = new CreateEMP
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3),

                    };
                    emplist.Add(emp);
                }


            }
            return emplist;
        }

        public static CreateEMP GetEmpById(int id)
        {


            CreateEMP empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                    cn.Open();
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectEmp = "Select * from emptbl_x where eno=@id";
                selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectEmp;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new CreateEMP
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3)
                    };
                }
            }
            return empFound;
        }
        public static int AddNewEmp(CreateEMP newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl_x  values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.Id;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.Name;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.Salary;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.City; 
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int UpdateEmp(CreateEMP modifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl_X set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.Id;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.Name;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.City;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.Salary;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteEmp(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl_x where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}

