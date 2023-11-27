using System.Globalization;
using System.IO;
using System.XML;


namespace Lecture13
{
    public class StudentManager
    {
        //Define constants for the file paths and XML Schema
        private const string XmlFilePath = "students.xml";
        private const string JsonFilePath = "student.json";
        private const string XmlSchema = "student.xsd";
        public void SaveStudentsToXml(List<Student> students)
        {
            //Xml writer setting for indentation
            var settings = new XmlWriterSettings {Indent = true};

            //Creating an xml writer with the specific settings
            using var writer = XmlWriter.Create(XmlFilePath, settings)
            
            writer.WriteStartDocument();
            writer.WriteStartElement("Students");

            //iterate over every student and write their data to XML
            foreach(var student in students)
            {
                writer.WriteStartElement("Student");
                writer.WriteElementString("StudentId", student.StudentId.ToString());
                writer.WriteElementString("Name", student.name);
                writer.WriteElementString("Email", student.email);
                writer.WriteElementString("Course", student.course);

                writer.WriteEndEelemnts();

            }
            writer.WriteEndEelemnts();
            writer.WriteEndDocument();
        }
        public List<Student> LoadStudentFromXml()
        {
            var studnets = new List<Students>();
            var settings = new XmlReaderSeettings();
            settings.Shemas.Add("", XmlSchemaPath);
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationEventHandler = new ValidateEventHandler(XmlValidationEvenHandler);

            //Creating the xml reader
            using var reader = XmlReader.Create(XmlFilePath, settings);
            //Reading through the file
            while(reader.Read())
            {
                //Check for 'student' element start
                if(reader.NodeType==XmlNodeType.Element && reader.Name == "Student")
                {
                    reader.ReadToFollowing("StudnetId");
                    int id = reader.ReadElementContentAsInt();
                    string name = reader.ReadElementContentAsString();
                    string email = reader.ReadElementContentAsString();
                    string course = reader.ReadElementContentAsString();

                    //Create a student object and add it to the list
                    var student = new Student
                    {
                        StudnetId = id,
                        Name = name,
                        Email = email,
                        Course = course
                    };

                    studnets.Add(student);
                }
            }

        }
        public void SearchStudnetInXml(string xpathQuery)
        {
            var doc = new XmlDocument(); 
            doc.Load(XmlFilePath);
            var navigator = doc.CreateNavigator();
            var nodes = navigator.Select(xpathQuery);
            while(nodes.MoveNext())
            {
                Console.WriteLine(nodes.Current.OuterXml);
            }
        }
        public void SerializeStudentsToJson(List<Student> students)
        {
            //Convert the studetn list to json string
            var jsonString = JsonConvert.SerializeObject(students, Formating.Indented);
            //write the json string to the file
            File.WriteAllText(JsonFilePath ,jsonString);
        }
        public List<Student> DeserializeStudentsFromJson()
        {
            //Read the JSON back and to the list of students 
            var jsonString = File.ReadAllText(JsonFilePath);
            return jsonConvert.DeserializeObject<List<Student>>(jsonString);

        }
        private static void XmlValidationEvenHandler(object sender, ValidationEventArgs e)
        {
            //Print the validation error message
            Console.WriteLine($"XML Validate Error: {e.Message}");
        }
        public void AddStudnets()
        {

        }   
        public void ViewAllStudnets()
        {
            var studnets = LoadStudentFromXml();
            foreach(var student in studnets)
            {
                Console.WriteLine($"ID: {student.Studentid}, Name: {student.StudentName}, Course: {student.StudentCourse}");
            }
        }
        public void SearchStudent()
        {
            string name;
            Console.WriteLine("Enter the sutdent's name to search: ");
            while(string.IsNullOrEmpty(name == Console.ReadLine()))
            {
                Console.WriteLine("Invalid input. Name can't be empty");
            }

            //Perform an Xpath seatch
            SearchStudnetInXml($"/Studnets/Student/[Name='{name}]");
        }
    }
}