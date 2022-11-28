using Newtonsoft.Json;

//testing our class
// Vehicle foo = new Vehicle("Patrick",123456,"NY");
// Console.WriteLine(foo);

//store the list of vehicles
List<Vehicle> vehicles = new List<Vehicle>();

string[] menus = {
    "Add vehicle",
    "Write to file",
    "Read from file",
    "Show vehicles"
};

while(true)
{
    switch(Selection())
    {
        case "1":
            Add();
        break;
        case "2":
            Console.Write("filename:");
            string filename = Console.ReadLine();
            StreamWriter writer = new StreamWriter(filename);

            //giving our user a choice whether to write to csv or json
            Console.WriteLine("1. Write to CSV\n2.Write to JSON");
            Console.Write("Selection:");
            switch(Console.ReadLine()){
                case "1":
                    WriteToCSV(writer);
                    break;
                case "2":
                    WriteTOJSON(writer);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        break;
        case "3":
            Console.Write("filename:");
            filename = Console.ReadLine();
            StreamReader reader = new StreamReader(filename);

            //giving our user a choice whether to read from csv or json
            Console.WriteLine("1. Read from CSV\n2.Read From JSON");
            Console.Write("Selection:");
            switch(Console.ReadLine()){
                case "1":
                    ReadFromCSV(reader);
                    break;
                case "2":
                    ReadFromJSON(reader);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            break;
        case "4":
            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                Console.WriteLine();
            }
        break;
        default:
            Console.WriteLine("Try that stuff somewhere else!");
            break;
        
    }
}

 string Selection()
 {
    Console.WriteLine();
    Console.WriteLine("DMV");
    Console.WriteLine("=====");
    for(int i = 0; i< menus.Length; i++) {
        Console.WriteLine($"{i+1}. {menus[i]}");
    }

    Console.Write("Selection:");
    return Console.ReadLine();
 }

 void Add()
 {
    while(true)
    {
        // Console.Write("Name:");
        // string name = Console.ReadLine();
        // if(string.IsNullOrEmpty(name)) {
        //     Console.WriteLine("Invalid name!");
        //     continue;
        // }
        string name = Prompt("Name");
        string state =  Prompt("Plate State");
        int number = 0;

        //validation to make sure that we get a number and the length is 6
        while(true)
        {
            Console.Write("Plate Number:");
            string num = Console.ReadLine();
            if(int.TryParse(num, out number) && num.Length == 6)
            {
                break;
            }

            Console.WriteLine("Invalid license plate!");
        }

        //create the vehicle object and add it to the list of vehicles

        vehicles.Add(new Vehicle(name, number, state));
        Console.Write("Do you want to add another vehicle:");
        if(!Console.ReadLine().ToUpper().StartsWith("Y"))
            break;
    }
 }

/*
This is a method that shows the user some using the field name and return the input
if the inptu is not null. If null, the user is re-prompt
*/
 string Prompt(string field)
 {
    while(true)
    {
        Console.Write($"{field}:");
        string input = Console.ReadLine();
         if(!string.IsNullOrEmpty(input)) {
            return input;
         }

         Console.WriteLine($"{field} cannot be empty");
    }
 }
/* This method uses the streamreader to read the file from the json
    and load it back into the list of vehicles
*/
void ReadFromJSON(StreamReader reader)
{
    //unlike when reading from CSV, we need to read the whole file when working with JSON
    string record = reader.ReadToEnd();
    //the deserialize object will take the string of the records and gives us a List<Vehicle>
    //the type inside DeserializeObject<Type> must match the variable type. vehicles is a type of List<Vehicle>
    //hence DeserializeObject<List<Vehicle>>
    vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(record);

    //close the reader as we are done with it
    reader.Close();
}
 void ReadFromCSV(StreamReader reader)
 {
    //use to skip the header
    bool skipHeader = true;
    while(!reader.EndOfStream)
    {
        //we want the cursor to keep moving so we put readline outside of our if statement
        string record = reader.ReadLine();

        //we dont want to proces the header so we skip it then set the flag to false as we already skp it
        if(skipHeader){
            skipHeader = false;
        } else {
            //we dont want to attempt to spilt or process empty fields
            if(!string.IsNullOrEmpty(record)) {
                //the data is in the form of owner,plate#,plateState
                //we spilt base on ,
                string[] records = record.Split(",");

                //parsing out the data
                string name = records[0];
                int plate = int.Parse(records[1]);
                string state = records[2];

                //preventing duplication (patrick asked for this... not required)
                bool add = true;
                foreach(Vehicle vehicle in vehicles)
                {
                    //we check if the vechile already in the list and we dont add it
                    if(vehicle.Owner==name && vehicle.PlateNumber == plate){
                        add = false;
                    }
                }

                //only add vehicle to list if not added
                //I mentioned in class that if we want to prevent duplication, dictionary is the best appropach
                //as we can simply check if containKey instead of doing loop
                if(add){
                    vehicles.Add(new Vehicle(name, plate, state));
                }
            }


        }
        
        
    }

    Console.WriteLine("Data loaded");
    reader.Close();
 }

/**
THis method takes StreamWriter and write to json
*/
void WriteTOJSON(StreamWriter writer)
{
    //SerializeObject can take any object regardless of type and convert it to a string
    string record = JsonConvert.SerializeObject(vehicles);
    //we write the string to the file and we are done
    writer.WriteLine(record);
    writer.Close();
}

/**
This method takes the stream writer and write to the CSV
*/
 void WriteToCSV(StreamWriter writer)
 {
    //the first line of the csv contain the header
    writer.WriteLine("owner,plate number,plate state");
    //the rest has the data in the format as the header
    foreach(Vehicle vehicle in vehicles)
    {
        writer.WriteLine($"{vehicle.Owner},{vehicle.PlateNumber},{vehicle.PlateState}");
    }
    writer.Close();
 }
