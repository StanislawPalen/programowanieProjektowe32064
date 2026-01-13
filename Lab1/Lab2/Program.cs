using Lab2;

bool run = true;

do
{
    Console.WriteLine("CAR SHOP");
    Console.WriteLine(
        "[1] Show all, " +
        "[2] Search by year, " +
        "[3] Search by model, " +
        "[4] Search by engine capacity, " +
        "[5] Add car, " +
        "[0] Exit"
    );

    // Pamiętaj: wyszukiwarka ma działać bez względu na wielkość liter.
    // VM == vm, YAMaHa == yamaha.

    Console.WriteLine();

    char input = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (input)
    {
        case '1':
            DisplayVehicleModel();
            break;

        case '2':
            SearchByYear();
            break;

        case '3':
            SearchByModel();
            break;

        case '4':
            SearchByEngineCapacity();
            break;

        case '5':
            AddNewVehicle();
            break;

        case '0':
            run = false;
            break;

        default:
            Console.WriteLine("Invalid menu option");
            break;
    }

} while (run);

Console.WriteLine("Goodbye...");
return;
