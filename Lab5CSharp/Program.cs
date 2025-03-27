//task1
//using System;

//// Базовий клас
//abstract class Employee
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public double Salary { get; set; }

//    public Employee(string name, int age, double salary)
//    {
//        Name = name;
//        Age = age;
//        Salary = salary;
//    }

//    // Поліморфний метод Show
//    public abstract void Show();
//}

//// Робітник
//class Worker : Employee
//{
//    public string WorkArea { get; set; }

//    public Worker(string name, int age, double salary, string workArea)
//        : base(name, age, salary)
//    {
//        WorkArea = workArea;
//    }

//    public override void Show()
//    {
//        Console.WriteLine($"Робітник: {Name}, Вік: {Age}, Зарплата: {Salary}, Область роботи: {WorkArea}");
//    }
//}

//// Кадри
//class HR : Employee
//{
//    public int EmployeesManaged { get; set; }

//    public HR(string name, int age, double salary, int employeesManaged)
//        : base(name, age, salary)
//    {
//        EmployeesManaged = employeesManaged;
//    }

//    public override void Show()
//    {
//        Console.WriteLine($"Кадри: {Name}, Вік: {Age}, Зарплата: {Salary}, Кількість співробітників: {EmployeesManaged}");
//    }
//}

//// Інженер
//class Engineer : Employee
//{
//    public string Specialization { get; set; }

//    public Engineer(string name, int age, double salary, string specialization)
//        : base(name, age, salary)
//    {
//        Specialization = specialization;
//    }

//    public override void Show()
//    {
//        Console.WriteLine($"Інженер: {Name}, Вік: {Age}, Зарплата: {Salary}, Спеціалізація: {Specialization}");
//    }
//}

//// Адміністрація (використання запису для зберігання даних про адміністрацію)
//record Administration(string Name, int Age, double Salary, string Position)
//{
//    public void Show() => Console.WriteLine($"Адміністрація: {Name}, Вік: {Age}, Зарплата: {Salary}, Посада: {Position}");
//}

//class Program
//{
//    static void Main()
//    {
//        Employee worker = new Worker("Іван", 35, 20000, "Будівництво");
//        Employee hr = new HR("Марина", 40, 25000, 100);
//        Employee engineer = new Engineer("Олексій", 30, 30000, "Програмування");
//        Administration admin = new("Олена", 45, 50000, "Директор");

//        worker.Show();
//        hr.Show();
//        engineer.Show();
//        admin.Show();
//    }
//}



//task2
//using System;

//// Базовий клас
//abstract class Employee
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public double Salary { get; set; }

//    public Employee()
//    {
//        Console.WriteLine("Викликано конструктор Employee (без параметрів)");
//    }

//    public Employee(string name) : this()
//    {
//        Name = name;
//        Console.WriteLine("Викликано конструктор Employee (з іменем)");
//    }

//    public Employee(string name, int age, double salary) : this(name)
//    {
//        Age = age;
//        Salary = salary;
//        Console.WriteLine("Викликано конструктор Employee (з усіма параметрами)");
//    }

//    ~Employee()
//    {
//        Console.WriteLine("Викликано деструктор Employee");
//    }

//    public abstract void Show();
//}

//// Робітник
//class Worker : Employee
//{
//    public string WorkArea { get; set; }

//    public Worker() : base()
//    {
//        Console.WriteLine("Викликано конструктор Worker (без параметрів)");
//    }

//    public Worker(string name) : base(name)
//    {
//        Console.WriteLine("Викликано конструктор Worker (з іменем)");
//    }

//    public Worker(string name, int age, double salary, string workArea) : base(name, age, salary)
//    {
//        WorkArea = workArea;
//        Console.WriteLine("Викликано конструктор Worker (з усіма параметрами)");
//    }

//    ~Worker()
//    {
//        Console.WriteLine("Викликано деструктор Worker");
//    }

//    public override void Show()
//    {
//        Console.WriteLine($"Робітник: {Name}, Вік: {Age}, Зарплата: {Salary}, Область роботи: {WorkArea}");
//    }
//}

//// Кадри
//class HR : Employee
//{
//    public int EmployeesManaged { get; set; }

//    public HR() : base()
//    {
//        Console.WriteLine("Викликано конструктор HR (без параметрів)");
//    }

//    public HR(string name) : base(name)
//    {
//        Console.WriteLine("Викликано конструктор HR (з іменем)");
//    }

//    public HR(string name, int age, double salary, int employeesManaged) : base(name, age, salary)
//    {
//        EmployeesManaged = employeesManaged;
//        Console.WriteLine("Викликано конструктор HR (з усіма параметрами)");
//    }

//    ~HR()
//    {
//        Console.WriteLine("Викликано деструктор HR");
//    }

//    public override void Show()
//    {
//        Console.WriteLine($"Кадри: {Name}, Вік: {Age}, Зарплата: {Salary}, Кількість співробітників: {EmployeesManaged}");
//    }
//}

//// Інженер
//class Engineer : Employee
//{
//    public string Specialization { get; set; }

//    public Engineer() : base()
//    {
//        Console.WriteLine("Викликано конструктор Engineer (без параметрів)");
//    }

//    public Engineer(string name) : base(name)
//    {
//        Console.WriteLine("Викликано конструктор Engineer (з іменем)");
//    }

//    public Engineer(string name, int age, double salary, string specialization) : base(name, age, salary)
//    {
//        Specialization = specialization;
//        Console.WriteLine("Викликано конструктор Engineer (з усіма параметрами)");
//    }

//    ~Engineer()
//    {
//        Console.WriteLine("Викликано деструктор Engineer");
//    }

//    public override void Show()
//    {
//        Console.WriteLine($"Інженер: {Name}, Вік: {Age}, Зарплата: {Salary}, Спеціалізація: {Specialization}");
//    }
//}

//// Адміністрація
//record Administration(string Name, int Age, double Salary, string Position)
//{
//    public void Show() => Console.WriteLine($"Адміністрація: {Name}, Вік: {Age}, Зарплата: {Salary}, Посада: {Position}");
//}

//class Program
//{
//    static void Main()
//    {
//        Employee worker = new Worker("Іван", 35, 20000, "Будівництво");
//        Employee hr = new HR("Марина", 40, 25000, 100);
//        Employee engineer = new Engineer("Олексій", 30, 30000, "Програмування");
//        Administration admin = new("Олена", 45, 50000, "Директор");

//        worker.Show();
//        hr.Show();
//        engineer.Show();
//        admin.Show();
//        Console.ReadKey();
//    }
//}
