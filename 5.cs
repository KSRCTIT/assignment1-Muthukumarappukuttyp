using System;

class Patient
{
    public string Name { get; set; }
    public DateTime DateOfAdmission { get; set; }
    public int Age { get; set; }
    public string Disease { get; set; }
    public DateTime DateOfDischarge { get; set; }
    public double TotalBillsPaid { get; set; }

    public void GetPatientInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Disease: {Disease}, Total Bills Paid: {TotalBillsPaid}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Patient: {Name}, Admission: {DateOfAdmission.ToShortDateString()}, Discharge: {DateOfDischarge.ToShortDateString()}");
    }
}

class Hospital
{
    static void Main(string[] args)
    {
        Patient patient = new Patient();

        Console.Write("Enter Patient Name: ");
        patient.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        patient.Age = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Disease: ");
        patient.Disease = Console.ReadLine();
        
        Console.Write("Enter Date of Admission (yyyy-mm-dd): ");
        patient.DateOfAdmission = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Date of Discharge (yyyy-mm-dd): ");
        patient.DateOfDischarge = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Total Bills Paid: ");
        patient.TotalBillsPaid = double.Parse(Console.ReadLine());

        patient.GetPatientInfo();
        patient.DisplayInfo();
    }
}
