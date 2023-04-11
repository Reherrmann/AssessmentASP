using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Paginas.Pages
{
    public class BookModel : PageModel
    {
        public List<BookInfo> listBooks = new List<BookInfo>();
        public void OnGet()
        {
            try 
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\017552631\\source\\repos\\Reherrmann\\AssessmentASP\\CreateCodeLivros\\App_Data\\DefaultConnection.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM books";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) 
                            { 
                              BookInfo book = new BookInfo();
                                book.BookId = reader.GetInt32(0);
                                book.Isbn = reader.GetString(1);
                                book.Title = reader.GetString(2);

                                listBooks.Add(book);
                            }
                        }
                    }
                }
            }

            catch (Exception ex) 
            {

            }
        }
    }

    public class BookInfo
    {
        public int BookId;
        public string Isbn;
        public string Title;
    }
}
