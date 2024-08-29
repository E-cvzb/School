using School;

List<Student> studets = new List<Student>();// studets listesi oluşturarak veri girişi

studets.Add(new Student { StudentId = 1, StudentName="Bob" ,ClassId=2 ,});
studets.Add(new Student { StudentId = 2, StudentName = "Kelvin", ClassId = 3, });
studets.Add(new Student { StudentId = 3, StudentName = "Alvin", ClassId = 1, });
studets.Add(new Student { StudentId = 4, StudentName = "Adam", ClassId = 1, });
studets.Add(new Student { StudentId = 5, StudentName = "Austin", ClassId = 3, });
studets.Add(new Student { StudentId = 6, StudentName = "Earl", ClassId = 2, });
studets.Add(new Student { StudentId = 7, StudentName = "Boris", ClassId = 1, });

List<Class> classes = new List<Class>();//classes listesi oluşturarak veri girişi

classes.Add(new Class { ClassId = 1,ClassName="Math" });
classes.Add(new Class { ClassId = 2, ClassName = "Biology" });
classes.Add(new Class { ClassId = 3, ClassName = "Physical" });

var classgroupstudent = classes.GroupJoin(studets,//group join oluşturma
    studets => studets.ClassId,//eşleştirme yapılacak verierlin lamda ile tanımlanması
    classes => classes.ClassId,
    (classes,classgroupstudent)=> new//yeni liste oluşturma 
    {
     className=classes.ClassName,
     student=classgroupstudent
    });

foreach(var x in classgroupstudent)//oluşturduğumuz grubu yazdırma
{
    Console.WriteLine("Ders:" +x.className);
    foreach(var y in x.student)//oluşturduğumuz grubun elemanlarını yazdırma
    {
        Console.WriteLine(y.StudentName);
    }
}