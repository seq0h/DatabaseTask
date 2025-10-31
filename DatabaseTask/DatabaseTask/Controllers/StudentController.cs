using System.Text;
using DatabaseTask.Core.Domain;
using DatabaseTask.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using DatabaseTask.Models;


namespace DatabaseTask.Controllers
{

    public class StudentController : Controller
    {  
        public  DatabaseTaskDbContext _context;
        public IConfiguration _confiq;

        public StudentController
           (
             DatabaseTaskDbContext context
            , IConfiguration config

           )
        {
            _context = context;
            _confiq = config;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DynamicSQL()
        {
            string connectionString = _confiq.GetConnectionString("DefaultConnection");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dbo.spSearchCustomers";
                cmd.CommandType = System.Data.CommandType.Text;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                List<Student> model = new List<Student>();
                while (sdr.Read())
                {
                    var details = new Student();
                    details.Name = sdr["Name"].ToString();
                    
                   
                    model.Add(details);
                }
                return View(model);

            }
          
        }
        [HttpPost]
        public IActionResult DynamicSQL(string Name)
        {
            string connectionString = _confiq.GetConnectionString("DefaultConnection");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                StringBuilder sbCommand = new StringBuilder("SELECT * FROM Customers WHERE 1=1");
                if (!string.IsNullOrEmpty(Name))
                {
                    sbCommand.Append(" AND Name =@Name");
                    SqlParameter param = new
                    SqlParameter("@Name", Name);
                    cmd.Parameters.Add(param);
                }

                cmd.CommandType = System.Data.CommandType.Text;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                List<Student> model = new List<Student>();
                while (sdr.Read())
                {
                    var details = new Student();
                    details.Name = sdr["Name"].ToString();

                    model.Add(details);
                }

                return View(model);
            }
        }
    }
}
