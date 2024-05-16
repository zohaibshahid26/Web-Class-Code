using Microsoft.Data.SqlClient;
namespace WebApplication3.Models
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
    {
        private readonly string connectionString;
        public GenericRepository(string c) {
        connectionString=c;
        }

        public void Add(TEntity entity) { 
        
        //get table name
        var tableName= typeof(TEntity).Name;

        var properties =
                typeof(TEntity).GetProperties().Where(p => p.Name != "Id");
            var columnNames = 
                string.Join(",", properties.Select(x=> x.Name));
            var parameterNames =
                string.Join(",", properties.Select(y=> "@" +y.Name));

            var query = $"insert into  {tableName} ({columnNames}) values({parameterNames})";

            using (var connection = new SqlConnection(connectionString)) {
                connection.Open();
                var command = new SqlCommand(query, connection);
                foreach (var property in properties)
                {
                    command.Parameters.AddWithValue("@"+property.Name,
                        property.GetValue(entity));
                }
                command.ExecuteNonQuery();
            
            
            
            }
        
        }

        public void Update(TEntity entity)
        {
            var tableName = typeof(TEntity).Name;
            var primaryKey = "Id";
            var properties =
                typeof(TEntity).GetProperties().Where(x=> x.Name != primaryKey);

            var setClause = string.Join(",", properties.Select(a => $"{a.Name}=@{a.Name}"));

            var query = $"update {tableName} set  {setClause} where {primaryKey} = @{primaryKey}";
        }
    }
}
