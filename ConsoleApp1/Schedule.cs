[Serializable]

class Schedule
{
    public List<OnCallDuty> duties = new List<OnCallDuty>();
 
    public void AddDuty(OnCallDuty duty)
    {
        duties.Add(duty);
    }
 
    public bool CheckDuty(OnCallDuty duty)
    {
        int count = 0;
        foreach (OnCallDuty d in duties)
        {
            if (d.month == duty.month && d.day == duty.day)
            {
                count++;
            }
        }
        if (count >= 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
 
    public bool AssignDuty(OnCallDuty duty)
    {
        if (CheckDuty(duty))
        {
            duties.Add(duty);
            return true;
        }
        else
        {
            return false;
        }
    }
}
