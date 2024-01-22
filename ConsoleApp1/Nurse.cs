[Serializable]
class Nurse : Employee
{
    public List<OnCallDuty> onCallDuty = new List<OnCallDuty>();

    // Corrected constructor for Nurse class
    public Nurse(string name, string surname, string username, string password)
    {
        this.name = name;
        this.surname = surname;
        this.username = username;
        this.password = password;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{name} {surname} (Nurse)");
    }

    public void DisplaySchedule(int month)
    {
        foreach (OnCallDuty duty in onCallDuty)
        {
            if (duty.month == month)
            {
                Console.WriteLine($"{duty.day}: {duty.startTime} - {duty.endTime}");
            }
        }
    }
}