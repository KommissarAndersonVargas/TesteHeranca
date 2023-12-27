using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class Person
    {
        public int id { get; set; }
        public string name { get; set; }

        public double divida { get; set; }
    public Person(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public virtual void Addiciona(int divida)
    {
        this.divida = divida;
        Console.WriteLine("Divida: " + divida);
    }

    public override string ToString() {

        return $"id: {id}, Nome:{name} ";
    
    }

}

