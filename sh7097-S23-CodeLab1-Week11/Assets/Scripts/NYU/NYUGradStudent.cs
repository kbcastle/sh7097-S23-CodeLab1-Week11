using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUGradStudent : NYUStudent
{
    public string degree;
    
    public NYUGradStudent(
        string name, string netId,
        float gpa, int credits, string degree) :
        base(name, netId, gpa, credits)
    {
        this.degree = degree;

        type = "NYUGradStudent";
    }
    
    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nDegree:" + degree;
    }
}
