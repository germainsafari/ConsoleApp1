[Serializable]
class Nurse : Employee
{
    public List<OnCallDuty> onCallDuty = new List<OnCallDuty>();
 
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
 
