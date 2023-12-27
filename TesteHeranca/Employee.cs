using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class Employee: Person
    {
    public  int cpf { get; set; }
    public double timeContr { get; set; }

    public double money { get; set; }
    public Employee(int id, string name, int cpf, double timeContr) : base(id, name)
    {
        this.id = id;
        this.name = name;
        this.cpf= cpf;
        this.timeContr= timeContr;


    }
    public override void Addiciona(int m)
    {
        money = m;
        Console.WriteLine("Dinheiro: " + money, '\n');
    }
    public override string ToString()
    {
        return $"Id:{id}, Nome: {name}, Cpf {cpf}, Tempo de contrato {timeContr} \n" ;
    }




}

