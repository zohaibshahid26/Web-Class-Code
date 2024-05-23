using Dapper;
using Microsoft.Data.SqlClient;

namespace WebApplication5.Models
{
    public class CategoryRepository
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True;";
        public CategoryRepository() { }


        public List<Category> GetCategories() {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string query = "select * from category";
           return connection.Query<Category>(query).ToList();
            }
        
        }

        public void AddCategory(Category category) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string query = "insert into category(name, description) values(@name,@description)";
                connection.Execute(query,category);

            
            
            
            }
        
        }
        public void UpdateCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "update category set name=@name, description=@description where id=@id";
                connection.Execute(query, category);




            }

        }

        public void DeleteCategory(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "delete from category where id=@id";
                connection.Execute(query, new {Id=id });




            }

        }
    }
}
