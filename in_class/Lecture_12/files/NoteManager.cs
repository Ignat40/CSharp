using System.Linq.Expressions;

namespace ReadingFiles
{
    public class NoteManager
    {
        private string? notesDirectory;
        public NoteManager(string? directory)
        {
            notesDirectory = directory;

            if(!Directory.Exists(notesDirectory) && notesDirectory != null)
                Directory.CreateDirectory(notesDirectory);
        }

        public void WriteNote(string? noteName, string content)
        {
            if(notesDirectory == null)
                return;

            string notePath = Path.Combine(notesDirectory, noteName + ".txt");

            //Using streamwriter to write the content ot hte note file

            try
            {
                using(var writer = new StreamWriter(notePath, true))
                {
                    writer.WriteLine(content);
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error writing to note: {ex.Message}");
            }
        }

        //Method to read from the Note
        public string? ReadNote(string noteName)
        {
            if(notesDirectory == null)
                return null;

            string notePath = Path.Combine(notesDirectory, noteName + ".txt");
            //Using StreamReader to read the content from the note file
            try
            {
                using(var reader = new StreamReader(notePath))
                {
                    return reader.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error in reading note: {ex.Message}");
                return null;
            }
        }
    }
    

}