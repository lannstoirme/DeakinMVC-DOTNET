using System;
using System.ComponentModel.DataAnnotations;

namespace DeakinRazorPages.Models

{
    public class Employee
    {
       
            public int ID { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Department { get; set; }
        
    }
}
