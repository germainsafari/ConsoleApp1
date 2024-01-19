[Serializable]
class OnCallDuty
{
    public int month;
    public int day;
    public string startTime;
    public string endTime;
 
    public OnCallDuty(int month, int day, string startTime, string endTime)
    {
        this.month = month;
        this.day = day;
        this.startTime = startTime;
        this.endTime = endTime;
    }
}
 
