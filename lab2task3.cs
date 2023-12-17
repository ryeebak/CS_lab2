using System;
using KeyLibrary;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document is opened");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Document editing is available in the Pro version");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Document saving in old format is available in the Pro version. Document saving in other formats is available in Exp version.");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Document has been edited");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document saved in the old format, saving in other formats is available in the Expert version");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Document saved in the new format");
    }
}

class Program
{
    static void Main()
    {
        bool enterKey = false; // Variable to determine whether the user wants to enter a key

        Console.WriteLine("Do you want to enter a key? (yes/no):");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            enterKey = true;
        }

        DocumentWorker docWorker;

        if (enterKey)
        {
            do
            {
                Console.WriteLine("Enter the key (pro/exp):");
                string key = Console.ReadLine();

                if (key == Keys.ProKey)
                {
                    docWorker = new ProDocumentWorker();
                }
                else if (key == Keys.ExpKey)
                {
                    docWorker = new ExpertDocumentWorker();
                }
                else
                {
                    Console.WriteLine("Invalid key. Please try again.");
                    docWorker = null;
                }
            } while (docWorker == null);
        }
        else
        {
            docWorker = new DocumentWorker();
        }

        docWorker.OpenDocument();
        docWorker.EditDocument();
        docWorker.SaveDocument();
    }
}
