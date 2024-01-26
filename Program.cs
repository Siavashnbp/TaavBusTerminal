while (true)
{
    try
    {

    }
    catch (Exception exception)
    {
        PrintStarSeprator();
        Console.WriteLine(exception.Message);
        PrintStarSeprator();
    }

}
void PrintStarSeprator()
{
    Console.WriteLine("***************");
}