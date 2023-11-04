
using Indexer_Exceptions_Practice;
using Indexer_Exceptions_Practice.Controllers;
using Indexer_Exceptions_Practice.Helpers.Constants;


#region Indexer
//Library library = new Library();

//Book book = new Book();

//book.Name = "Test1";
//book.Id = 1;

//book.Name = "Test2";
//book.Id = 2;

//library[1] = book;

//Console.WriteLine(library[1].Name);

#endregion




static void Register(string username,string password)
{
    bool isSuccess = false;
    try
	{
			
		if (username == "Nurlan123")
		{
            Console.WriteLine("Login success");
			isSuccess = true;
        }
		else
		{
			throw new NullReferenceException();
		}
	}
	catch (Exception ex)
	{

        Console.WriteLine(ex.Message);
    }

	finally
	{
		SendEmail(isSuccess);
	}
}


//Register("Nurlan", "123");



static void SendEmail(bool isSuccess)
{
	if (isSuccess)
	{
        Console.WriteLine(AccountMessages.RegisterEmailSuccess);
	}
	else
	{
        Console.WriteLine(AccountMessages.RegisterEmailFailed);
    }
}



static void ShowText(string text)
{
	try
	{
		if(text is null)
		{
			throw new ArgumentNullException();
		}
		else
		{
            Console.WriteLine(text);
        }
	}
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }
}


//ShowText(null);



PersonController personController = new PersonController();

personController.GetById();