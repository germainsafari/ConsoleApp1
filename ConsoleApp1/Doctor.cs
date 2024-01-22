[Serializable]
class Doctor : Employee
{
    public string specialty;
    public string pwzNumber;
    public List<OnCallDuty> onCallDuty = new List<OnCallDuty>();

    // Corrected constructor for Doctor class
    public Doctor(string name, string surname, string username, string password, string specialty, string pwzNumber)
    {
        this.name = name;
        this.surname = surname;
        this.username = username;
        this.password = password;
        this.specialty = specialty;
        this.pwzNumber = pwzNumber;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{name} {surname} ({specialty})");
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
