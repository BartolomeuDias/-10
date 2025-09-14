namespace Laboratoy_work_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University vsu = new University("ВГУ");
            Dean fcnDean = new Dean("Крыловецкий Александр Абрамович", "krilovetskiy@mail.ru");
            Faculty fcn = new Faculty("ФКН", fcnDean);

            Institute infsys = new Institute("ИС", "к111");
            Institute dt = new Institute("ЦТ", "к222");
            Institute itu = new Institute("ИТУ", "к333");
            Institute tozi = new Institute("ТОЗИ", "к444");
            Institute piit = new Institute("ПИИТ", "к555");

            fcn.SetInstitutes(new List<Institute> { infsys , dt , itu, tozi, piit});

            ResearchAssociate ra1 = new ResearchAssociate("Михаил Михаил Михайлович", "mihail@mail.ru", "Тензорный анализ в нейронных сетях");
            ResearchAssociate ra2 = new ResearchAssociate("Васильев Василий Васильевич", "bazil@mail.ru", "Исследование алгоритмов кодирования информации");
            ResearchAssociate ra3 = new ResearchAssociate("Петров Пётр Петрович", "peter@mail.ru", "Линейная алгебра в компьютерной графике");

            infsys.SetEmployees(new List<ResearchAssociate> { ra1, ra2, ra3 });

            Lecturer lecturer1 = new Lecturer("Николаев Николай Николаевич", "nikolay@mail.ru", "Математический анализ");
            Course course1 = new Course(256, "Матанализ", 6);

            Project proj1 = new Project("Внедрение нейронных сетей в компьютерную графику", new DateTime(2024, 1, 15), new DateTime(2025,1,15));

            Participation participation1 = new Participation(100, ra1, proj1 );

            Console.WriteLine($"Университет: {vsu.Name}");
            Console.WriteLine($"Факультет: {fcn.Name} Декан: {fcn.Dean}");
            Console.WriteLine("Кафедры: \n");
            foreach(var institute in fcn.GetInstitutes())
            {
                Console.WriteLine(institute.Name);
            }
            Console.WriteLine();
            Console.WriteLine($"Научные сотрудники кафедры {infsys.Name}: \n");
            foreach(var researchAssociate in infsys.GetEmployees())
            {
                Console.WriteLine(researchAssociate.Name);
            }
            Console.WriteLine();

            Console.WriteLine($"Лекторы: {lecturer1.Name}");
            Console.WriteLine($"Лекции: {course1.Name} Длительность (еженедельная): {course1.WeeklyDuration}");

            Console.WriteLine($"Проекты: {proj1.Name}");
        }
    }
}
