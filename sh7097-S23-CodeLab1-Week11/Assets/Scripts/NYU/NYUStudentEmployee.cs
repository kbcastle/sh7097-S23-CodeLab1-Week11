using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NYUStudentEmployee : NYUStudent
{
    public float hourlyWage = 27.5f;
    public bool healthInsurance = true;

    public NYUStudentEmployee(
        string name, string netId,
        float gpa, int credits, float hourlyWage, bool healthInsurance) :
        base(name, netId, gpa, credits)
    {
        this.hourlyWage = hourlyWage;
        this.healthInsurance = healthInsurance;

        type = "NYUStudentEmployee";
    }
    
    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nHealth Insurance: " + healthInsurance + 
                                    "\nHourly Wage:" + hourlyWage;
    }
}
