using System;

class Program
{
    static void Main(string[] args)
    {
        Administrator admin = new Administrator();


        Doctor doctor1 = new Doctor("John", "Doe", "jdoe", "password", "Cardiologist", "12345");
        doctor1.onCallDuty.Add(new OnCallDuty(1, 1, "08:00", "20:00"));
        doctor1.onCallDuty.Add(new OnCallDuty(1, 2, "08:00", "20:00"));
        doctor1.onCallDuty.Add(new OnCallDuty(1, 3, "08:00", "20:00"));
        admin.AddUser(doctor1);

        Nurse nurse1 = new Nurse("Jane", "Doe", "jane", "password");
        nurse1.onCallDuty.Add(new OnCallDuty(1, 1, "08:00", "20:00"));
        nurse1.onCallDuty.Add(new OnCallDuty(1, 2, "08:00", "20:00"));
        nurse1.onCallDuty.Add(new OnCallDuty(1, 3, "08:00", "20:00"));
        admin.AddUser(nurse1);

        admin.DisplayUsers();


        admin.SerializeEmployees();


        admin.DeserializeEmployees();
    }
}
