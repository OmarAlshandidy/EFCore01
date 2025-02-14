using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Entity
{
    // Entity
    //Poco:
    //Plain Old ClR Object 

    //Ef Core suppport 4 ways  for  mapping Classes In DataBase ;[Table ,View ,Function]
    //1 . By Convetion [Defult Behaviour]
    //2- Data Annotion  [set of attribute Used for Data Validtion]
    // 3- Fluent Api 
    // 4-Class Configuration 

    //1 . By Convetion [Defult Behaviour]
    //class Employee //Table
    //{
    //    public int Id { get; set; } // public Numeric Property Named 'id'|EmployeeId --> PK 
    //    public string Name { get; set; } // Reference Type : Requried [Not Allow Null] - nvarchar(max)
    //    public int? Age { get; set; } //nullbale Value Type :Int[Age] - Optiona - NOtAllowNull
    //    public double Salary { get; set; } // value Taype : float[Salary}- Requried 
    //    public string? Email { get; set; } //nvarchar(max) - Optional
    //    public DateTime DateOfCreation { get; set; }// datetime2-Requried

    //}
}

//2.Data Annotation
//[Table("Employee", Schema = "dbo")]
//internal class Employee
//{
//    [Key]
//    [DatabaseGenerated(DatabaseGeneratedOption.None)]
//    public int EmpId { get; set; } // PK

//    [Required]
//    [Column("EmpName", TypeName = "varchar")]
//    [MaxLength(50)]
//    [StringLength(50, MinimumLength = 10)]
//    public string? Name { get; set; }

//    [Range(20, 60)]
//    public int? Age { get; set; }
//    [Column(TypeName = "money")]
//    [DataType(DataType.Currency)]
//    public double Salary { get; set; }



//}
//fluent Api
class Employee
{
    public int EmpId { get; set; }
    public string? Name { get; set; }
    public double Salary { get; set; }
    public string? Address { get; set; }

}

