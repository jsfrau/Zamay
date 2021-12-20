# Разработка информационной системы для контрольно-пропускной системы общежития

## Содержание

[Введение](#introdution)

[1 Описание предметной области](#domainDescription)

[2 Сравнительный анализ существующих программных решений](#existSoftware)

[3 Разработка](#Development)

[4 Проектирование системы](#Systemdesign)

[5 Тестирование системы](#Checkingandtestingthesystem)

[Заключение](#Conclusion)

[Список литературы](#Listofliterature)

<a name="introdution"/>

# Введение

## *Общее описание*

Ещё с древности у людей существовала потребность в отличии своих от чужих. Постепенно, вместе с развитием человечества,
у нас стали появляться разлиные решения для данной потребности. В нашем случае рассматривается задача контроля входа и
выхода в студенческое общежитие. Схожие пропускные системы существуют уже давно и успели себя зарекомендовать. Например,
в таких видах организаций, как : Военные, Образовательные, Частные.

Из данных областей нашей более близка система, используемая в образовательных или частных организациях.

<a name="domainDescription"/>

# 1 Описание предметной области

Общежи́тие — место временного проживания для приезжих студентов и учащихся на время учёбы, сезонных рабочих на время
работы, службы или ставшее постоянным для работников учреждения. Соответственно, следует различать студенческие и
рабочие общежития.

Контрольно-пропускной пункт — в военном деле, а также в гражданской сфере обеспечения безопасности имеет два значения:
специально оборудованное место на объекте для осуществления контроля в установленном порядке за проходом людей и
проездом транспортных средств на территорию объекта.

В данной системе участвует 3 лица: посетитель, вахтёр, комендант.

Посетитель - это тот, кто взаимодействет с КПП, обеспечивающем *"отсеивание"* своих от чужих. Вахтёр - важное лицо,
взаимодействующее с пропусками. Комендант - заселяет посетителей и выписывает пропуски. Все вместе, они образуют
информационную систему.

Задача:

-создание информационного сайта обеспечивающего возможность входа и выхода из общежития, регистрацию в нём и выдачу
пропусков;

Проблема :

-быстрый, регестрируемый вход и выход из общежития;

<a name="existSoftware"/>

# 2 Сравнительный анализ существующих программных решений

Во многих образовательных организациях, в том числе и в ВУЗе, которому принадлежит наше общежитие, установлена и
работает схожая система. Схожесть в участвующих лицах и их обязаннастях.

Планируется схожая контрольно пропускная система ввиде пункта, находящегося в общежитии. Отличие данного решения от
других заключается в в уникальности системы взаимодействия сущностей, в краткости и четкости, бесперебойной работе.

<a name="Development"/>

# 3 Разработка

Начинается разработка с рисования use case диаграммы, на которой будут находится основные действующие лица.

![image](https://github.com/jsfrau/Zamay/blob/main/Pictures/UseCase.drawio.svg)

Рисунок 1 - Use Case диаграмма

Затем, используя эти наброски, нарисуем DFD диаграмму для лучшего представления движения данных в нашей области. Для
наглядности, все действующие лица выделены своими цветами. Посетитель(красный) Вахтёр(синий) Комендант(желтый)

![image](https://github.com/jsfrau/Zamay/blob/main/Pictures/KPP_DFD.drawio.svg)

Рисунок 2 - Data Flow диаграмма

![image](https://github.com/jsfrau/Zamay/blob/main/Pictures/KPP_ER.svg)

На основе этой диаграммы мы создаем классы в среде C# и описываем их с параметрами и их типами данных. Для этого мы
создаем его, определяем в простраство имен и описываем класс:
![img_1.png](img_1.png)
Рисунок 3 - класс

Создаем такие классы для всех сущностей из ER - диаграммы:

![img.png](img.png)

Рисунок 4 - список классов

Пример кода класса "Посетитель":

```csharp
namespace Zamay.Domain
{
    public class Visitor
    {
        public int VisitorNumber { get; set; }
        public Document Documents { get; set; }
        public bool check { get; set; }
    }
}
```

Пример кода класса "Время входа":

```csharp
using System;

namespace Zamay.Domain
{
    public class ArrivalTime
    {
        public int ArrivalTimeNumber { get; set; }
        public DateTime EnterTime { get; set; }
        public Pass Pass { get; set; }
    }
}
```

***

Так же для работы приложения были разработаны и созданы хранилища, позволяющие хранить, актуализировать и использовать информацию

![img_2.png](img_2.png)

Рисунок 5 - Список хранилищ

Пример кода хранилища посетителей :

```csharp
using System.Collections.Generic;
using Zamay.Domain;

namespace Zamay.Repository
{
    public class VisitorStorage
    {
        private Dictionary<int, Visitor> visitors { get; } = new();

        public void Create(Visitor visitor)
        {
            visitors.Add(visitor.VisitorNumber, visitor);
        }

        public Visitor Read(int visitorNumber)
        {
            return visitors[visitorNumber];
        }

        public Visitor Update(int visitorNumber, Visitor newVisitor)
        {
            visitors[visitorNumber] = newVisitor;
            return visitors[visitorNumber];
        }

        public bool Delete(int visitorNumber)
        {
            return visitors.Remove(visitorNumber);
        }

        public bool Check(int visitorNumber)
        {
            if (visitors[visitorNumber] != null)
                return true;
            return false;
        }
    }
}
```

Пример кода хранилища входов :

```csharp
using System.Collections.Generic;

namespace Zamay.Domain
{
    public class ArrivalTimeStorage
    {
        private Dictionary<int, ArrivalTime> ArrivalTimes { get; } = new();

        public void Create(ArrivalTime arrivalTime)
        {
            ArrivalTimes.Add(arrivalTime.ArrivalTimeNumber, arrivalTime);
        }

        public ArrivalTime Read(int arrivalTimeNumber)
        {
            return ArrivalTimes[arrivalTimeNumber];
        }

        public ArrivalTime Update(int arrivalTimeNumber, ArrivalTime newArrivalTime)
        {
            ArrivalTimes[arrivalTimeNumber] = newArrivalTime;
            return ArrivalTimes[arrivalTimeNumber];
        }

        public bool Delete(int arrivalTimeNumber)
        {
            return ArrivalTimes.Remove(arrivalTimeNumber);
        }
    }
}
```

***

Затем созадём контроллеры, которые будут взаимодействовать с ранее созданными классами :

![img_3.png](img_3.png)

Рисунок 6 - Список хранилищ

Пример кода контроллера посетителя:
```csharp
using Microsoft.AspNetCore.Mvc;
using Zamay.Domain;
using Zamay.Repository;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/visitor")]
    public class VisitorController : ControllerBase
    {
        [HttpPut("Register")]
        public Visitor Create(Visitor visitor)
        {
            Storage.VisitorStorage.Create(visitor);
            return visitor; // Метод для регистрации в общежитии
        }
    }
}
```

Пример кода контроллера вахтера:
```csharp
using Microsoft.AspNetCore.Mvc;
using Zamay.Domain;
using Zamay.Repository;
using static System.DateTime;

namespace Zamay.Controllers
{
    [ApiController]
    [Route("/watchman")]
    public class Vahter : ControllerBase
    {
        [HttpPatch("RestorePass")]
        public Pass RestorePass(int PassNumber, Pass newPass)
        {
            return Storage.PassStorage.Update(PassNumber, newPass);
        }

        [HttpPut("LeavingTimeRegister")]
        public string Create(LeavingTime leavingTime, int visitorNumber)
        {
            if (!Storage.VisitorStorage.Check(visitorNumber)) return "Scam";
            leavingTime.LeaveTime = Now;
            Storage.LeavingTimeStorage.Create(leavingTime);
            return leavingTime + " " + "Добавлено!";
        }

        [HttpPut("ArrivalTimeRegister")]
        public string Create(ArrivalTime arrivalTime, int visitorNumber)
        {
            if (!Storage.VisitorStorage.Check(visitorNumber)) return "Scam";
            arrivalTime.EnterTime = Now;
            Storage.ArrivalTimeStorage.Create(arrivalTime);
            return arrivalTime + " " + "Добавлено!";
        }
        
        [HttpGet("GetInfoAboutVisitor")]
        public Visitor Read(int visitorNumber)
        {
            return Storage.VisitorStorage.Read(visitorNumber);
        }

        [HttpDelete("DeleteVisitor")]
        public bool Delete(int visitorNumber)
        {
            return Storage.VisitorStorage.Delete(visitorNumber);
        }
    }
}
```

<a name="Checkingandtestingthesystem"/>

## Тестирование системы

При запуске приложения открывается вкладка браузера Swagger UI, в котором представлены котроллеры и их операции над сущностями.

![img_5.png](img_5.png) 

Рисунок 7 - Список контроллеров

Проверка работы методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) в контроллере Watchman

![img_6.png](img_6.png)

Рисунок 8 - Список методов оператора Watchman

1. Метод Create позволяет добавлять новую запись в хранилище.

![img_7.png](img_7.png)

Рисунок 9 - Окно метода Create, в которое мы вносим значения

После ввода данных, сервер нам отвечает : 
![img_8.png](img_8.png)

Рисунок 10 - Результат срабатывания метода Create

2. Метод Read позволяет нам считать запись из хранилища.

![img_9.png](img_9.png)

Рисунок 11 - Окно метода Read

![img_10.png](img_10.png)

Рисунок 12 - Результат срабатывания метода Read

3. Функция Update, служащая для редактирования записей в хранилище по идентификатору. В окно PassNumber мы вводим номер пропуска, у которого мы желаем изменить данные, а в Request body новые данные.

![img_11.png](img_11.png)

Рисунок 13 - Окно функции Update

![img_12.png](img_12.png)

Рисунок 14 - Результат срабатывания функции Update


