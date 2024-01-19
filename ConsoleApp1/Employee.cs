using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
 
[Serializable]
abstract class Employee
{
    public string name;
    public string surname;
    public string pesel;
    public string username;
    public string password;
 
    public abstract void DisplayInfo();
}
